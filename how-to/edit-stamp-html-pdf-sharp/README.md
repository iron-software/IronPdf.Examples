***Based on <https://ironpdf.com/how-to/edit-stamp-html-pdf-sharp/>***

Here is the paraphrased version of the article, with all relative URL paths resolved to ironpdf.com:

---

## IronPdf Overview

**IronPdf** offers C# developers a robust library to manage HTML-to-PDF conversion on .NET platforms including .NET 8, .NET 7, .NET 6, .NET Core, and the .NET Framework. Employing this library, you can create rich, well-formatted PDF documents directly from HTML, MVC, ASPX pages, or directly from image files. The library comes packed with features allowing PDF signing, editing, and reading, with over 50 functionalities available to streamline PDF management in your applications.

Quickly integrate into your projects using `"PM> Install-Package IronPdf"` and enhance your application capabilities within minutes.

**Company Details:**
Iron Software LLC,
205 N. Michigan Ave., Suite 810, 
Chicago, IL 60601, 
USA
Email: [support@ironsoftware.com](mailto:support@ironsoftware.com)
[Website](https://www.ironpdf.com)

For detailed licensing options including enterprise and perpetual licenses, visit their dedicated pages:
- Unlimited license: [IronPdf Unlimited Licensing](https://ironpdf.com/licensing/#licensing-unlimited)
- Help Scout support details: [Help Scout for IronPdf](https://ironpdf.com/licensing/#helpscout-support)

**Compatibility and Supported Technologies:**
- Languages: C#, VB.NET, F#
- App Frameworks: .NET versions (8, 7, 6), .NET Core (starting 2.0+), .NET Standard (from 2.0+), .NET Framework (4.6.2+)
- Project Applications: Web (includes Blazor & WebForms), Desktop (supports WPF & MAUI), Console (both App & Library types)
- Environments: Windows (7, 10, Server 2016+), Linux (Ubuntu, Debian, CentOS), MacOS (10.14+), Cloud (Azure, AWS Docker compatible) 
- IDEs supported: Visual Studio, ReSharper, Rider
- Certified by DigiCert ensuring trusted, secure binary distributions.

### Features for PDF Generation
- **HTML to PDF**: Transform HTML pages directly into PDF files.
- **URL to PDF**: Directly render web pages to PDF documents by URL references.
- **JS & CSS Rendering**: Full support for JavaScript, CSS, and HTML5 during PDF generation.
- **Editing and Security**: Edit existing PDFs, add digital signatures, and secure with password protections.
- **Advanced Rendering Options**: Configure headers, footers, pagination, and fine-tune rendering settings.

### Advanced Usage:
- **External Asset Loading**: Set up a base path like `C:\\site\\assets\\` for seamless asset loading during PDF generation.

```csharp
// Prepare HTML with assets for PDF transformation
var Renderer = new IronPdf.HtmlToPdf();
var PDF = Renderer.RenderHtmlAsPdf("<h1>Heading</h1><img src='https://ironpdf.com/icons/iron.png'>", @"C:\\site\\assets\\");
PDF.SaveAs("html-with-assets.pdf");
```

For more guidance on deploying and leveraging the IronPdf library in your applications, refer to the comprehensive documentation at [IronPdf Docs](https://ironpdf.com/documentation/).

*Note: All product and feature updates are diligently posted on their website, ensuring you stay updated with the latest enhancements and capabilities of IronPdf.*

---

This paraphrased content retains the same factual, technical information as the original while enhancing readability and incorporating direct links to Iron Software's licensing and support pages.