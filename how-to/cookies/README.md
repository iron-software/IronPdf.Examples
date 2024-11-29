# Working with Cookies in IronPDF

***Based on <https://ironpdf.com/how-to/cookies/>***


Cookies are crucial data elements that a website deposits on a user's computer. They help in numerous functions such as maintaining user sessions by keeping users signed in, and in tracking and analytics by capturing data about user interactions for website enhancement. Despite these roles, the usage of cookies has raised privacy concerns, giving rise to regulations like GDPR and CCPA. Consequently, modern web browsers enable users to manage cookies, ensuring adherence to these privacy concerns.

## Example of Applying Cookies

To start applying cookies, first set the `RequestContext` property to `RequestContexts.Global`. This setup involves using the `ChromeHttpLoginCredentials` class and invoking the `ApplyCookies` method. Afterward, the renderer can proceed to convert HTML content into PDFs while incorporating cookies.

```cs
using IronPdf;
namespace ironpdf.Cookies
{
    public class ApplyingCookiesSection
    {
        public void Execute()
        {
            // Create an instance of ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set global request context
            renderer.RenderingOptions.RequestContext = IronPdf.Rendering.RequestContexts.Global;
            
            // Define credentials for HTTP login
            ChromeHttpLoginCredentials credentials = new ChromeHttpLoginCredentials() {
                NetworkUsername = "demoUser",
                NetworkPassword = "demoPass"
            };
            
            string uri = "http://example.com/ContentPage";
            
            // Apply cookies to the specified URI
            renderer.ApplyCookies(uri, credentials);
        }
    }
}
```

The `RequestContexts` enumeration: This enum is pivotal in defining browser request contexts that help maintain consistency across renders and manage cookies efficiently.

- **Isolated**: Sets up a new and detached request context, ensuring no interference from past or future renders.
- **Global**: Maintains a shared request context across all renders, useful for persisting browser states over multiple renders.
- **Auto**: Defaults to `IronPdf.Rendering.RequestContexts.Isolated`, but changes to `IronPdf.Rendering.RequestContexts.Global` if `ApplyCookies` has previously been used.

## Example of Applying Custom Cookies

To apply custom cookies, configure the `CustomCookies` property, which accepts a dictionary containing cookies in the form of key-value string pairs.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.Cookies
{
    public class CustomCookiesSection
    {
        public void Execute()
        {
            // Initialize ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Creating a dictionary for custom cookies
            Dictionary<string, string> customCookies = new Dictionary<string, string>();
            
            // Assigning custom cookies to renderer
            renderer.RenderingOptions.CustomCookies = customCookies;
            
            var uri = new Uri("https://example.com/InvoicePage");
            PdfDocument pdf = renderer.RenderUrlAsPdf(uri);
        }
    }
}
```

In both examples, cookies are carefully managed and applied to ensure the typical functionalities like authentication and session maintenance during the PDF rendering process with IronPDF.