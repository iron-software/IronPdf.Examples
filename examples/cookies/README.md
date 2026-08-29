> Full guide: [Cookies](https://ironpdf.com/examples/cookies/)

This snippet outlines the use of IronPDF to authenticate a request with network credentials and to append cookies, which is crucial for converting web pages to PDF format.

- **`ChromePdfRenderer`**: This is utilized to convert HTML content to PDF.
- **`RequestContexts.Global`**: By maintaining a consistent browsing context throughout the lifespan of the process, this supports the use of cookies and authentication across multiple requests.
- **`ChromeHttpLoginCredentials`**: This facilitates network authentication for accessing web pages that are protected by login credentials.
- **`ApplyCookies`**: This method attaches the defined cookies and credentials to the HTTP request, essential for processing secure web pages.
- **`uri`**: This denotes the URL of the web page to be converted into a PDF, often requiring user login. For demonstration, it points to a webpage hosted locally.

This configuration is highly beneficial for generating PDFs from protected pages, such as invoices, reports, or dashboards, where user credentials are necessary.

[Learn to Apply Cookies in PDF Rendering with IronPDF.](https://ironpdf.com/how-to/cookies)