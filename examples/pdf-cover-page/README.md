***Based on <https://ironpdf.com/examples/pdf-cover-page/>***

Here is a paraphrased and reformatted version of the markdown content related to Iron Software:

---

# Iron Software: A Premier C# Library for PDF Tasks

## Effortlessly Convert HTML to PDF with IronPDF

IronPDF enables .NET developers to create PDF documents directly from HTML, using a straightforward method that supports multiple .NET environments including .NET versions 8, 7, 6, Core, and Framework.

### Key Features:

- **Convert from HTML**: Easily convert HTML documents, MVC, ASPX, and images to PDF.
- **Enhanced PDF Manipulation**: Sign, edit, and manage PDFs with over 50 robust features.
- **Quick Installation**: Seamlessly integrate into your development environment using NuGet. Simply execute the command:
  ```
  PM > Install-Package IronPdf
  ```
Visit [IronSoftware](https://ironpdf.com) or contact us via email at [support](mailto:support@ironsoftware.com) for more support.

### Contact Information:
Iron Software LLC
205 N. Michigan Ave., Chicago, IL 60611, USA
Email: [support@ironsoftware.com](mailto:support@ironsoftware.com)
Website: [ironsoftware.com](https://www.ironsoftware.com)
Phone: +1 (312) 500-3060

## Licensing Unlimited with IronPDF

IronPDF offers flexible licensing, including both Monthly ($500/month with no lock-in contract) and Enterprise options which provide a perpetual license with no tracking in live deployment environments. For unlimited API calls and more details, visit our [Iron Suite Licensing details page](https://ironsoftware.com/csharp/webscraper/licensing/#licensing-unlimited).

## Developer Tools and Compatibility

IronPDF is aligned with numerous application environments and configurations:

- **Supported OS**: Windows (10+, Server 16+), Linux (Ubuntu, Debian, CentOS, etc.), and macOS (10+).
- **Integrated Development Environments (IDE)**: Compatible with Microsoft Visual Studio and JetBrains ReSharper & Rider.
- **Language Support**: Works with C#, VB.NET, and F#.

For detailed compatibility and to ensure smooth integration with various development setups, refer to the comprehensive guide available on our website.

## Advanced Usage: Integrating External HTML Assets

IronPDF not only allows the conversion of HTML strings and web URLs into PDF files but also supports the inclusion of CSS and images from external directories, ensuring your PDF looks as expected.

Example of adding an HTML with assets:
```csharp
string htmlContent = "<h1>Html with CSS and Images</h1><img src='icons/iron.png'>";
var pdf = Renderer.RenderHtmlAsPdf(htmlContent);
pdf.SaveAs("html-with-assets.pdf");
```

Ensure your assets' correct path is set to prevent missing data:
```csharp
Renderer.RenderingOptions.BaseUrl = @"C:\site\assets\";
```

For deeper insights into the capabilities of handling complex PDF generation and manipulation, IronPDF is your go-to library. It's designed to handle the heavy lifting of PDF generation while providing control and quality in your application’s document management capabilities. 

---

By using IronPDF, developers are equipped with a powerful tool to integrate PDF functionalities into their applications seamlessly, adhering to modern development standards and requirements.