# Managing Cookies with IronPDF

***Based on <https://ironpdf.com/how-to/cookies/>***


Cookies are tiny data segments stored on a user's device by websites. They handle various tasks, from keeping sessions active to tracking user activities for enhancements. Due to privacy implications, they've prompted regulatory measures like GDPR and CCPA. Modern browsers also equip users with tools to manage cookie settings, addressing privacy concerns effectively.

## Getting Started: Implementing Cookies with IronPDF

IronPDF simplifies the process of incorporating cookies into your PDF generation workflow. This quick guide demonstrates how to manipulate cookies using the IronPDF API to preserve session details and user preferences in your HTML-to-PDF transformations. With a minimal amount of code, developers can embed standard or specific cookies seamlessly. Start improving your PDF outputs today!

```cs
:title=Efficient Cookie Management in PDF Rendering
// Initialize the PDF renderer with cookie settings
new IronPdf.ChromePdfRenderer { RenderingOptions = { RequestContext = IronPdf.Rendering.RequestContexts.Global, CustomCookies = new Dictionary<string, string> { { "sessionId", "your_cookie_value" } } } }
    .RenderUrlAsPdf("https://example.com/protected")
    .SaveAs("secureWithCookies.pdf");
```

## Detailed Cookie Usage Example

To apply cookies, first configure the **RequestContext** to `RequestContexts.Global`. Then, prepare a `ChromeHttpLoginCredentials` and use it with the `ApplyCookies` method. This prepares the renderer for PDF conversions from HTML content that require cookie information.

Here's how to use cookies effectively with IronPDF:

```csharp
using IronPdf;

// Create an instance of ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.RequestContext = IronPdf.Rendering.RequestContexts.Global;

ChromeHttpLoginCredentials credentials = new ChromeHttpLoginCredentials() {
    NetworkUsername = "demoUser",
    NetworkPassword = "demoPass"
};

string uri = "http://localhost:51169/Invoice";

// Implementing cookies for PDF rendering
renderer.ApplyCookies(uri, credentials);
```

`RequestContexts` Enum: This enumeration determines the browser context for requests, crucial for cookie and preference management.

- `Isolated`: Establishes a standalone request context, avoiding interference from past or future renders. This setting is advisable for consistent results.
- `Global`: Links renders through a shared global request context, beneficial for maintaining some browser aspects across renders.
- `Auto`: Starts with `IronPdf.Rendering.RequestContexts.Isolated` however, switches to `IronPdf.Rendering.RequestContexts.Global` if `IronPdf.ChromePdfRenderer.ApplyCookies(System.String, IronPdf.ChromeHttpLoginCredentials)` has been previously called.

<hr>

## Implementing Custom Cookies

Setting custom cookies requires adjusting the **CustomCookies** property. This property takes a dictionary with string keys and values.

Illustrative guidance for applying custom cookies with IronPDF:

```csharp
using IronPdf;
using System;
using System.Collections.Generic;

// Configuring the ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

Dictionary<string, string> customCookies = new Dictionary<string, string>();

// Setting up custom cookies
renderer.RenderingOptions.CustomCookies = customCookies;

var uri = new Uri("https://localhost:44362/invoice");
PdfDocument pdf = renderer.RenderUrlAsPdf(uri);
```