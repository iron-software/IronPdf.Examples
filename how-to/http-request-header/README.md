# Utilizing HTTP Request Headers in .NET

***Based on <https://ironpdf.com/how-to/http-request-header/>***


HTTP request headers are key metadata elements transmitted from a client—like a web browser or an API client—to a server during an HTTP request. These headers convey essential information regarding the request, including details about authentication, the type of content being requested, the user's agent, and other significant data.

When converting a URL to a PDF, it's possible to include custom HTTP header information within the request, enhancing control over how requests are handled by the server.

```cs
:title=Incorporating custom HTTP headers easily!
new IronPdf.ChromePdfRenderer { RenderingOptions = { HttpRequestHeaders = new Dictionary<string, string> { { "Authorization", "Bearer your_token_here" }, { "User-Agent", "MyApp/1.0" } } } }
    .RenderUrlAsPdf("https://httpbin.org/bearer")
    .SaveAs("withHeaders.pdf");
```


## Implementing HTTP Request Headers Example

To effectively use the **HttpRequestHeaders** property for setting HTTP request headers, it's necessary to initialize an appropriate HTTP request header object first. This will ensure that the specified headers are included in the URL request during PDF rendering. For illustration, we will employ [httpbin.org](https://httpbin.org), a service that displays request headers.

```csharp
using IronPdf;
using System.Collections.Generic;

var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.HttpRequestHeaders = new Dictionary<string, string>
{
    { "Authorization", "Bearer test-token-123" }
};

// Generate a PDF from a page that requires authentication
var pdf = renderer.RenderUrlAsPdf("https://httpbin.org/bearer");
pdf.SaveAs("output.pdf");
```

### Key HTTP Request Headers

- **Authorization**: Transmits authorization credentials (such as Bearer tokens, Basic authentication, etc.)
- **Content-Type**: Indicates the type of the content in the request body (for example, application/json)
- **Accept**: Specifies the desired format for the response (such as text/html, application/json)
- **User-Agent**: Identifies the client making the request (like a browser or an API client)
- **Referer**: Shows the page that directed to the current request
- **Cookie**: Transfers cookies to manage sessions