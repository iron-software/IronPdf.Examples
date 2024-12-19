# Converting HTML to PDF with Login Authentication

***Based on <https://ironpdf.com/how-to/logins/>***


It is generally advisable to bypass login requirements when converting HTML to PDF. This can typically be achieved by exporting HTML from a file or directly from a string.

<h3>Introducing IronPDF</h3>

----

## Recommended Approaches

IronPDF provides robust support for TLS network authentication, where both username and password can be securely implemented. .NET web applications can integrate this seamlessly using [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

A successful strategy includes using `System.Net.WebClient` or `HttpClient` to retrieve the HTML content and its associated resources. This approach not only handles headers and logins but also ensures all elements, such as stylesheets and images, are accounted for. Once the content is in memory or on disk, IronPDF can efficiently convert the HTML into a PDF. To manage assets effectively, `HtmlAgilityPack` offers a method to locate and download them using `System.Net.WebClient`.

```cs
string htmlContent;
// Using WebClient to fetch HTML
using (WebClient webClient = new WebClient()) {
    htmlContent = webClient.DownloadString("http://www.google.com");
}

// Loading HTML into the HtmlDocument
HtmlDocument htmlDocument = new HtmlDocument();        
htmlDocument.LoadHtml(htmlContent);

// Extract and print image sources
foreach(HtmlNode imageNode in htmlDocument.DocumentNode.SelectNodes("//img")) {
    Console.WriteLine(imageNode.GetAttributeValue("src", null));
}
```

For handling relative URLs, one can use the overloaded constructor for the `System.Uri` class. You can integrate a `<base>` tag within the header of an HTML document to set a base path for all relative URLs using HtmlAgilityPack. [Learn how to use the base tag](https://www.w3schools.com/tags/tag_base.asp).

## Implementing Network Authentication in Login

Network authentication is commonly supported in most ASP.NET applications and offers more reliability than traditional HTML form submissions.

```cs
using IronPdf;
using System;

// Configuring PDF renderer with network credentials
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer
{
    // Establishing credentials
    LoginCredentials = new ChromeHttpLoginCredentials()
    {
        NetworkUsername = "testUser",
        NetworkPassword = "testPassword"
    }
};

// Specifying the URI to render
var targetUri = new Uri("http://localhost:51169/Invoice");

// Convert the URL to PDF
PdfDocument document = pdfRenderer.RenderUrlAsPdf(targetUri);

// Saving the PDF document
document.SaveAs("UrlToPdfExample.Pdf");
```

## Using HTML Form for Login

Logging in via an HTML form can also utilize the **ChromeHttpLoginCredentials** class, akin to above examples. *See details in IronPDF's [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).* 

**Important notes:**

- The ACTION attribute of the HTML form should correspond to the *[LoginFormUrl](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html)* setting in your `HttpLoginCredentials`.
- The form data should reflect all inputs and text areas as defined by their 'name' attributes.
- Note that some sites may shield against automated form posts.

## Handling MVC Views

For programmatically rendering .NET MVC views into strings while sidestepping MVC logins, use the following method:

```cs
public static string RenderPartialViewToString(this Controller controller, string viewName, object model = null)
{
    try
    {
        var controllerContext = controller.ControllerContext;
        controller.ViewData.Model = model;

        using (var stringWriter = new StringWriter())
        {
            // Finding and rendering the partial view
            var viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
            if (viewResult.View == null)
            {
                throw new Exception($"View \"{viewName}\" is unavailable.");
            }

            // Setting the view context and rendering
            var viewContext = new ViewContext(controllerContext, viewResult.View, controller.ViewData, controller.TempData, stringWriter);
            viewResult.View.Render(viewContext, stringWriter);
            viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);

            return stringWriter.GetStringBuilder().ToString();
        }
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}
```