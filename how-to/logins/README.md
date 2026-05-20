# HTML to PDF Conversion with Access-Controlled Content

***Based on <https://ironpdf.com/how-to/logins/>***


Direct integration without login when possible allows straightforward HTML to PDF conversions from files or strings.

## Quickstart: Convert Protected HTML Pages to PDF using IronPDF

Effortlessly transform HTML pages locked behind authentication forms into PDF files with IronPDF’s robust API. This quickstart guide will help you employ the `ChromeHttpLoginCredentials` method to authenticate and access secured content efficiently, making your conversion process smooth. It covers scenarios from network to HTML form authentications using IronPDF to facilitate rapid, hassle-free conversions.

```cs
:title=Easily convert a protected URL to a PDF
new ChromePdfRenderer { LoginCredentials = new ChromeHttpLoginCredentials("username", "password") }
    .RenderUrlAsPdf("https://example.com/protected")
    .SaveAs("secured-output.pdf");
```

## Best Practices

IronPDF handles TLS network authentication effectively, and .NET web applications can manage it smoothly using: [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html)

Downloading HTML and its resources first (via `System.Net.WebClient` or `HttpClient`) is advisable. This method also extends support for headers and other necessities. After getting content into memory or on disk, IronPDF can convert the HTML into a PDF. For downloading dependent assets like stylesheets and images, use the `HtmlAgilityPack`.

```csharp
// Code snippet to download and explore HTML content
string htmlContent;
using (WebClient webClient = new WebClient())
{
    htmlContent = webClient.DownloadString("http://www.google.com");
}

HtmlDocument htmlDoc = new HtmlDocument();
htmlDoc.LoadHtml(htmlContent);

foreach(HtmlNode imageNode in htmlDoc.DocumentNode.SelectNodes("//img"))
{
    Console.WriteLine(imageNode.GetAttributeValue("src", null));
}
```

Adjust any relative URLs to absolute using `System.Uri` or by inserting a `<base>` tag in the header with HtmlAgilityPack as shown [here](https://www.w3schools.com/tags/tag_base.asp).

## Leveraging Network Authentication

ASP.NET apps generally support network authentication efficiently:

```csharp
using IronPdf;
using System;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer
{
    LoginCredentials = new ChromeHttpLoginCredentials
    {
        NetworkUsername = "demoUser",
        NetworkPassword = "demoPassword"
    }
};

Uri websiteUri = new Uri("http://localhost:51169/Invoice");

PdfDocument generatedPdf = pdfRenderer.RenderUrlAsPdf(websiteUri);
generatedPdf.SaveAs("NetworkAuthPDF.pdf");
```

## Managing HTML Form Logins

Logging in via HTML form data using the **ChromeHttpLoginCredentials** class is straightforward. Refer to the detailed guide on [ChromeHttpLoginCredentials API](https://ironpdf.com/object-reference/api/IronPdf.ChromeHttpLoginCredentials.html).

**To Consider:**

- Post data directly to the URL indicated in the form’s ACTION attribute using the `LoginFormUrl` attribute from `ChromeHttpLoginCredentials`.
- Ensure data packaging includes all form `input` and `textarea` names. Avoid common misconceptions surrounding the use of `id` attributes.
- Be aware some sites may actively block automated logins.

## Rendering MVC Views as Strings

This method permits rendering .NET MVC views directly to strings, bypassing MVC-based authentication:

```csharp
// Method to convert a MVC partial view into a string representation.
public static string RenderPartialViewToString(Controller controller, string viewName, object viewModel = null)
{
    controller.ViewData.Model = viewModel;
    var controllerContext = controller.ControllerContext;

    using (var stringWriter = new StringWriter())
    {
        var viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
        if (viewResult.View == null)
            throw new Exception($"Unable to find the view {viewName}.");

        var viewContext = new ViewContext(controllerContext, viewResult.View, controller.ViewData, controller.TempData, stringWriter);
        viewResult.View.Render(viewContext, stringWriter);
        viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);
        return stringWriter.GetStringBuilder().ToString();
    }
}
```

Explore more capabilities and tutorials here: [Convert PDFs](https://ironpdf.com/tutorials/convert-pdf/)