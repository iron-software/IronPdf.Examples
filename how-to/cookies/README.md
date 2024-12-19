# Utilizing Cookies with IronPDF

***Based on <https://ironpdf.com/how-to/cookies/>***


Cookies play a crucial role in web technologies, facilitating functionalities ranging from maintaining user sessions to gathering data on user activities for website enhancements. The application of cookies, however, does raise privacy concerns, which have been addressed through regulations such as the GDPR and CCPA. In response, modern web browsers have enhanced cookie management features to mitigate these issues.

### Introduction to IronPDF

---

## Implementing Cookies with IronPDF

To begin using cookies with IronPDF, first configure the **RequestContext** to use `RequestContexts.Global`. Subsequently, initialize the `ChromeHttpLoginCredentials` and employ them through the `ApplyCookies` method. With this setup, the renderer is prepared to generate PDFs from HTML content while appropriately managing cookies.

```cs
using IronPdf;

// Create a ChromePdfRenderer instance
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure the renderer to use global request contexts
renderer.RenderingOptions.RequestContext = IronPdf.Rendering.RequestContexts.Global;

// Set up login credentials
ChromeHttpLoginCredentials credentials = new ChromeHttpLoginCredentials() {
    NetworkUsername = "testUser",
    NetworkPassword = "testPassword"
};

// Define the URL for PDF rendering
string uri = "http://localhost:51169/Invoice";

// Implement cookie application
renderer.ApplyCookies(uri, credentials);
```

### Explaining RequestContext Enum

This enumeration manages browser request contexts crucial for handling cookies and user settings efficiently:

- **Isolated**: Establishes a new and separate request context for each render, recommended to avoid interference from previous outputs.
- **Global**: Applies a global request context shared across renders, which can be advantageous for maintaining consistent browser states across sessions.
- **Auto**: Initially, the context is set to `RequestContexts.Isolated` but switches to `RequestContexts.Global` if the `ApplyCookies` method has been utilized previously.

---

## Example of Custom Cookie Implementation

Creating a personalized request with distinct cookies involves setting the `CustomCookies` attribute. This attribute accepts a dictionary where both keys and values are strings. Here's how to set it up:

```cs
using IronPdf;
using System;
using System.Collections.Generic;

// Initialize ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Prepare custom cookies
Dictionary<string, string> customCookies = new Dictionary<string, string>();

// Set custom cookies
renderer.RenderingOptions.CustomCookies = customCookies;

// URL setup for PDF rendering
var uri = new Uri("https://localhost:44362/invoice");
// Render URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf(uri);
```