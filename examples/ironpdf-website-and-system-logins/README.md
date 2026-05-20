***Based on <https://ironpdf.com/examples/ironpdf-website-and-system-logins/>***

ASP.NET applications often support network authentication, which is typically more dependable than relying on HTML form submissions. With IronPDF, you can leverage full support for TLS network authentication, ensuring secure operations within .NET web applications.

Consider the following example where we utilize IronPDF's state-of-the-art Chromium-based rendering engine to emulate a web browser viewing experience. During this process, headers and footers are dynamically crafted and appended to the document. Subsequently, we apply appropriate margins and styles before saving the content as a professionally formatted PDF.

## Steps to Generate PDFs from TLS-Protected Websites with Authentication

1. **Identify the Web Page URL:**  
   - Begin by identifying the URL of the web page to be transformed into a PDF. We establish a new `uri` object to represent the URL, which in this scenario is hosted locally at `"http://localhost:51169/Invoice"`.

2. **Initialize the PDF Rendering Engine:**  
   - Instantiate a new `ChromePdfRenderer`. This object is responsible for converting web pages into PDFs, equipped with robust conversion capabilities.

3. **Configure Rendering Parameters:**  
   - Adjust the `RenderingOptions` to set up custom margins and specify the media type for the print styles (`IronPdf.Rendering.PdfCssMediaType.Print`), tailoring the PDF to your needs.

4. **Input Login Credentials:**  
   - If the web page is secured with basic authentication, configure the `LoginCredentials` by supplying a `Username` and `Password`.

5. **Convert the URL to PDF:**  
   - Employ the `RenderUrlAsPdf` function to load the specified `uri` in a headless Chromium browser and convert the web page into a PDF, utilizing the defined rendering settings.

6. **Store the PDF File:**  
   - Conclude by saving the PDF using the `SaveAs` method in the current directory, with the file named `"UrlToPdfExample2.Pdf"`.

[Learn to Secure PDFs with Login Integration Here](https://ironpdf.com/how-to/logins/ "code_content__related-link__doc-cta-link")