# How to Convert HTML to PDF Utilizing Login Authentication

***Based on <https://ironpdf.com/how-to/logins/>***


For optimal results, bypass login pages directly by rendering HTML from a local file or directly from a string when possible.

## Recommended Practices

IronPDF offers support for TLS network authentication, including username and password combinations, providing a high level of security. This is well-supported in .NET web applications using the [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

It is advisable to use either `System.Net.WebClient` or `HttpClient` for retrieving HTML content and related resources. This approach supports custom request headers and authentication. After acquiring the HTML content, IronPDF can efficiently convert it into a PDF file. It's practical to utilize `HtmlAgilityPack` for parsing HTML, which enables downloading of associated assets like CSS and images with `System.Net.WebClient`.

```cs
string htmlContent;
using (var webClient = new WebClient()) {
    htmlContent = webClient.DownloadString("http://www.google.com");
}
HtmlDocument document = new HtmlDocument();
document.LoadHtml(htmlContent);
foreach(HtmlNode image in document.DocumentNode.SelectNodes("//img")) {
    Console.WriteLine(image.GetAttributeValue("src", ""));
}
```

For handling relative URLs in HTML, use the `System.Uri` class to convert them into absolute URLs. To anchor relative paths within a document, implement a `<base>` tag in the HTML head, as explained [here](https://www.w3schools.com/tags/tag_base.asp).

## Network Authentication in Login

Network authentication is robust and commonly used in ASP.NET applications, surpassing methods like HTML form submissions in reliability.

```cs
using System;
using IronPdf;
namespace ironpdf.Logins
{
    public class NetworkLoginExample
    {
        public void Execute()
        {
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer
            {
                // Set up credentials to navigate through basic authentication
                LoginCredentials = new ChromeHttpLoginCredentials()
                {
                    NetworkUsername = "demoUser",
                    NetworkPassword = "demoPass"
                }
            };

            var targetUri = new Uri("http://localhost:51169/Invoice");

            // Convert web page to PDF
            PdfDocument document = pdfRenderer.RenderUrlAsPdf(targetUri);

            // Save the generated PDF
            document.SaveAs("WebToPdfExample.pdf");
        }
    }
}
```

## HTML Form Login

Logging in through HTML forms can be managed using the **ChromeHttpLoginCredentials** class as showcased earlier. More details at IronPDF's [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

**Points to Remember:**

- Ensure the login details are posted to the URL specified in the HTML form's ACTION attribute, which should be assigned to the *\[LoginFormUrl\](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html)* property of the `HttpLoginCredentials`.
- Input data fields should match the `name` attributes specified within the HTML form (ignore the `id` attributes).
- Note that some sites may have defenses against automated logins.

## MVC Approach

Below is a method enabling programmatic rendering of .NET MVC views into strings, which is particularly useful for evading logins while maintaining accurate view rendering.

```cs
public static string RenderViewToString(this Controller controller, string viewName, object viewModel = null)
{
    try
    {
        var controllerContext = controller.ControllerContext;

        controller.ViewData.Model = viewModel;

        using (var writer = new StringWriter())
        {
            var viewFindResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);

            if (viewFindResult.View == null)
            {
                throw new Exception($"The partial view {viewName} was not found.");
            }

            var viewCtx = new ViewContext(controllerContext, viewFindResult.View, controller.ViewData, controller.TempData, writer);

            viewFindResult.View.Render(viewCtx, writer);
            viewFindResult.ViewEngine.ReleaseView(controllerContext, viewFindResult.View);

            return writer.GetStringBuilder().ToString();
        }
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}
```
This markdown content utilizes friendly, professional language aimed at offering clear and structured guidance on integrating authentication with HTML to PDF conversions using IronPDF.