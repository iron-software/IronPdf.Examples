# Utilizing Cookies in IronPDF

Cookies are tiny data fragments stored on an individual's computer or device by websites. They fulfill multiple roles, from managing user sessions—ensuring users remain logged in—to tracking user activities for enhancing website functionalities. Nonetheless, concerns regarding user privacy have arisen, prompting the advent of regulations like GDPR and CCPA. Additionally, contemporary web browsers empower users with capabilities to manage their cookies, addressing privacy issues.

## Implementing Cookies with IronPDF

To commence integrating cookies, first configure the **RequestContext** property of the renderer to `RequestContexts.Global`. Subsequently, generate an instance of the `ChromeHttpLoginCredentials` class, assigning it credentials, and apply it using the `ApplyCookies` method. Following these steps, the renderer is prepared for converting HTML content into PDFs while accommodating cookie data.

```cs
using IronPdf;

// Initialize ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure the global request context
renderer.RenderingOptions.RequestContext = IronPdf.Rendering.RequestContexts.Global;

// Define login credentials
ChromeHttpLoginCredentials credentials = new ChromeHttpLoginCredentials() {
    NetworkUsername = "testUser",
    NetworkPassword = "testPassword"
};

// URL where cookies will be applied
string uri = "http://localhost:51169/Invoice";

// Implement cookies
renderer.ApplyCookies(uri, credentials);
```

### Understanding RequestContexts Enum:
This enumeration is vital for determining browser request contexts, which manage how cookies and user settings are handled in each rendering session.

- **Isolated**: Initiates a fresh request context, segregating it from previous sessions, ensuring unaffected new renders.
- **Global**: Employs a universal request context shared across multiple renders, applicable where persisting browser conditions is necessary.
- **Auto**: By default, it sets to `RequestContexts.Isolated` but switches to `RequestContexts.Global` when the user employs the `ApplyCookies` method.

<hr>

## Example of Applying Custom Cookies

When dealing with custom cookies, set the **CustomCookies** property using a dictionary where both keys and values are strings, allowing for tailored cookie management.

```cs
using IronPdf;
using System;
using System.Collections.Generic;

// Create a new ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Dictionary for custom cookies
Dictionary<string, string> customCookies = new Dictionary<string, string>();

// Set custom cookies
renderer.RenderingOptions.CustomCookies = customCookies;

// Set the URL object
Uri uri = new Uri("https://localhost:44362/invoice");

// Render PDF from the specified URL with custom cookies
PdfDocument pdf = renderer.RenderUrlAsPdf(uri);
```
This process facilitates the customization of cookies in PDF rendering, enhancing the flexibility of the IronPDF library in handling web content.