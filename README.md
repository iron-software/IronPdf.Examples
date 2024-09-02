![Nuget](https://img.shields.io/nuget/v/IronPdf?color=informational&label=latest)
![Installs](https://img.shields.io/nuget/dt/IronPdf?color=informational&label=installs&logo=nuget)
![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%203158%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)
[![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)](https://ironpdf.com/docs/questions/installation/)
[![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)](https://ironpdf.com/docs/questions/macos/)
[![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)](https://ironpdf.com/docs/questions/linux/)
[![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)](https://ironpdf.com/docs/questions/docker-linux/)
[![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)](https://ironpdf.com/docs/questions/creating-pdfs-csharp-amazon-aws-lambda/)
[![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)](https://ironpdf.com/docs/questions/azure/)
[![livechat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironpdf.com/#helpscout-support)

## IronPDF - Comprehensive PDF Management in .NET

[![IronPDF NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPDF-readme/nuget-trial-banner-large.png)](https://ironpdf.com/#trial-license)

[Get Started](https://ironpdf.com/docs/) | [Features](https://ironpdf.com/features/) | [How-Tos](https://ironpdf.com/how-to/html-file-to-pdf/) | [Code Examples](https://ironpdf.com/examples/using-html-to-create-a-pdf/) | [Licensing](https://ironpdf.com/licensing/) | [Free Trial](https://ironpdf.com/docs/#trial-license)

IronPDF, developed by Iron Software, empowers C# Programmers to construct, modify, and extract content from PDFs in .NET projects.

#### Standout Features of IronPDF:

  * Create PDFs from sources like [HTML](https://ironpdf.com/examples/using-html-to-create-a-pdf/), [URLs](https://ironpdf.com/examples/converting-a-url-to-a-pdf/), [JavaScript](https://ironpdf.com/examples/javascript-html-to-pdf/), [CSS](https://ironpdf.com/docs/questions/base-urls/), and various [image formats](https://ironpdf.com/examples/image-to-pdf/)
  * Edit PDFs by adding [headers and footers](https://ironpdf.com/examples/headers-and-footers/), [digital signatures](https://ironpdf.com/examples/digitally-sign-a-pdf/), [attachments](https://ironpdf.com/examples/csharp-add-attachment-to-pdf/), and [security features](https://ironpdf.com/examples/security-and-metadata/)
  * Supports [multithreading](https://ironpdf.com/examples/threading/) and asynchronous operations with full [Async](https://ironpdf.com/examples/async/) capabilities
  * Integrates PDF viewing, and extensions are available for [MAUI](https://ironpdf.com/how-to/net-maui-create-pdf-tutorial) and [ASP.NET](https://ironpdf.com/how-to/razor-to-pdf-blazor-server/)
  * Explore more! Check out all [code samples](https://ironpdf.com/examples/using-html-to-create-a-pdf/) and the [complete list of over 50 features](https://ironpdf.com/features/) on our website.

#### Cross-Platform Compatibility of IronPDF:

  * **.NET 8, .NET 7, .NET 6**, .NET 5, and .NET Core, Standard, and Framework
  * Compatible with Windows, macOS, Linux, Docker, Azure, AWS environments
  * Support for Console, Desktop, Web Apps, including [MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/), [Blazor](https://ironpdf.com/how-to/razor-to-pdf-blazor-server/), [MAUI](https://ironpdf.com/how-to/xaml-to-pdf-maui/), [Razor Pages](https://ironpdf.com/how-to/cshtml-to-pdf-razor/), [Web Forms](https://ironpdf.com/how-to/aspx-to-pdf/)

[![IronPDF Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPDF-readme/cross-platform-compatibility.png)](https://ironpdf.com/docs/)

Visit our [API reference](https://ironpdf.com/object-reference/api/) and [complete licensing details](https://ironpdf.com/licensing/#trial-license) available on our site.

### Implementing IronPDF

Quick and straightforward, install the IronPDF NuGet package via:

    PM> Install-Package IronPdf
    
Add `using IronPdf` to your file post-installation. Below is a sample going from HTML to PDF:

    // HTML to PDF conversion
    using IronPdf;
    
    var chromeRenderer = new ChromePdfRenderer(); // Initialize Chrome Renderer
    var document = chromeRenderer.RenderHtmlAsPdf(" <h1> ~Hello World~ </h1> Made with IronPDF!");
    document.SaveAs("html_example.pdf"); // Store the PDF file

Alternatively, convert a URL to PDF:

    // Convert URL to PDF
    using IronPdf;
    
    var chromeRenderer = new ChromePdfRenderer(); // Initialize Chrome Renderer
    
    // Choose screen view, preserving page elements usually removed in print
    chromeRenderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
    
    var webPdf = chromeRenderer.RenderUrlAsPdf("https://ironpdf.com/");
    webPdf.SaveAs("web_page.pdf");
    

### Feature Overview

[![IronPDF Features](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPDF-readme/features-table.png)](https://ironpdf.com/features/)

### Licensing & Support

Explore our [comprehensive code examples, tutorials, licensing data, and detailed documentation](https://ironpdf.com/). For additional assistance, contact us via email at: support@ironsoftware.com

### Documentation Links

  * How-To Guides: [https://ironpdf.com/how-to/](https://ironpdf.com/how-to/html-file-to-pdf/)
  * Live Demos: [https://ironpdf.com/demos/](https://ironpdf.com/demos/)
  * Code Samples: [https://ironpdf.com/examples/](https://ironpdf.com/examples/)
  * API Reference: [https://ironpdf.com/object-reference/api/](https://ironpdf.com/object-reference/api/)
  * Tutorials: [https://ironpdf.com/tutorials/](https://ironpdf.com/tutorials/)
  * Licensing Information: [https://ironpdf.com/licensing/](https://ironpdf.com/licensing/)
  * Live Chat: [https://ironpdf.com/#helpscout-support](https://ironpdf.com/#helpscout-support)