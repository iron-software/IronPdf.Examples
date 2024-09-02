# Converting HTML to PDF When Authentication is Required

For handling logins, a recommended approach is to bypass them altogether by rendering HTML from files or strings directly when feasible.

## Recommended Practices

IronPDF provides support for TLS network authentication (username and password), which offers a high level of security. .NET web applications can easily implement this through the [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

A good practice is to employ `System.Net.WebClient` or `HttpClient` for fetching the HTML content along with its dependencies. This method supports full header management and authentication requirements.
Once the HTML is locally available, either in memory or on disk, IronPDF can then convert it into a PDF format. Furthermore, dependencies like stylesheets and images should be identified using `HtmlAgilityPack` and downloaded through `System.Net.WebClient`.

```cs
string fetchedHtml;
using (WebClient webClient = new WebClient()) {
    fetchedHtml = webClient.DownloadString("http://www.google.com");
}
HtmlDocument htmlDoc = new HtmlDocument();        
htmlDoc.LoadHtml(fetchedHtml);
foreach(HtmlNode image in htmlDoc.DocumentNode.SelectNodes("//img")) {
    Console.WriteLine(image.GetAttributeValue("src", null));
}
```
To convert relative URLs to absolute within an HTML document, consider using a `<base>` tag in the document head, as outlined at [w3schools base tag example](https://www.w3schools.com/tags/tag_base.asp).

## Implementing Login via Network Authentication

Network authentication is generally more consistent and reliable than employing HTML forms, and is well-supported in most ASP.NET applications.

```cs
using IronPdf;
using System;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer
{
    // Setting the login credentials to avoid basic authentication prompts
    LoginCredentials = new ChromeHttpLoginCredentials()
    {
        NetworkUsername = "testUser",
        NetworkPassword = "testPassword"
    }
};

Uri webpageUri = new Uri("http://localhost:51169/Invoice");

// Converting web URL to PDF
PdfDocument generatedPdf = pdfRenderer.RenderUrlAsPdf(webpageUri);

// Saving the generated PDF
generatedPdf.SaveAs("UrlToPdfExample.Pdf");
```

## Login through an HTML Form

Logging in by sending data through an HTML form is feasible using the **ChromeHttpLoginCredentials** class, similar to the method discussed above. For more details, refer to IronPDF's [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

**Important Considerations:**

- Make sure the data is posted to the correct URL, as specified in the `ACTION` attribute of the HTML form. This should be set in the _[LoginFormUrl](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html)_ attribute of `HttpLoginCredentials`.
- It is necessary to send data representing all input elements and textareas of the form, wherein the `name` attribute of each form element is critical.
- Beware that some sites might actively prevent such automated logins.

## Bypassing MVC Authentications

The method below demonstrates how to programmatically render a .NET MVC view to a string, which can be especially handy for avoiding MVC-based authentications and still obtaining an accurate rendering of the view.

```cs
public static string RenderPartialViewToString(this Controller controller, string viewName, object model = null)
{
    try
    {
        var controllerContext = controller.ControllerContext;

        controller.ViewData.Model = model;

        using (var writer = new StringWriter())
        {
            var viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);

            if (viewResult.View == null)
            {
                throw new Exception($"The partial view {viewName} could not be located.");
            }

            var viewContext = new ViewContext(controllerContext, viewResult.View, controller.ViewData, controller.TempData, writer);

            viewResult.View.Render(viewContext, writer);
            viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);

            return writer.GetStringBuilder().ToString();
        }
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}
```