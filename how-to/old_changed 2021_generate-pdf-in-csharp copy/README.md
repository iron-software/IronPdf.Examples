# Create PDFs in C&num;

***Based on <https://ironpdf.com/how-to/old_changed 2021_generate-pdf-in-csharp copy/>***


Creating and managing PDF documents efficiently in C# is a common requirement across multiple projects. Leveraging a comprehensive library for these tasks focuses our effort more on core development rather than getting bogged down in intricate PDF generation details applicable to both .NET Core and .NET Framework.

Below are several scenarios demonstrating how to integrate PDF generation into your C# projects, including creating PDFs from HTML strings and ASPX input.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>PDF Creation with C#</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-free-c-library">Install the IronPDF Library</a></li>
        <li><a href="#anchor-4-generate-pdf-from-html-string">Create PDF from HTML Strings</a></li>
        <li><a href="#anchor-5-generate-pdf-from-aspx">Create PDF from ASPX Inputs</a></li>
        <li><a href="#anchor-7-generate-pdf-with-custom-viewport">Implement Custom Viewports with JavaScript</a></li>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" class="img-responsive learn-how-to-img">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Installing IronPDF

To get started with this guide, install the IronPDF C# HTML to PDF library. This library is free for development use and can be implemented as demonstrated below.

Get the IronPDF tools via [direct file download](https://ironpdf.com/packages/IronPdf.Package.For.Generate.PDF.Documents.zip) or the latest [NuGet package installation](https://www.nuget.org/packages/IronPdf) for integration into your Visual Studio project.

```shell
Install-Package IronPdf
```

<hr class="separator">
<h4 class="tutorial-segment-title">Guide Tutorial</h4>

## 2. Integration with .NET Framework & .NET Core 

IronPDF offers a straightforward API that significantly enhances coding productivity and speeds up project development, perfectly aligning with .NET Framework (from Version 4) and .NET Core (from Version 2).

<hr class="separator">

## 3. Utilizing Clear Naming Conventions 

Why is IronPDF exceptional for .NET-based PDF production?

Primarily, it's the efficiency. IronPDF accelerates PDF processing, aiding developers with clear and intuitive method names within its library, making it simple to quickly incorporate PDF functionalities in both VB.NET and C#.

Additionally, its straightforward usability is a standout feature, simplifying the engagement with method names and their functions, so .NET developers can effortlessly implement PDF generation.

<hr class="separator">

## 4. PDF Creation from HTML Content 

Here's how simple it is to create a PDF from HTML content using IronPDF:

```cs
/**
PDF from HTML Content
anchor-generate-pdf-from-html-string
**/
private void GenerateFromHTMLString()
        {
            // Convert HTML content directly to PDF
            var pdfRenderer = new IronPdf.ChromePdfRenderer();
            using var document = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF</h1>");
            
            var filePath = "OutputPDF.pdf";
            document.SaveAs(filePath);

        }
```

The concise C# code snippet above demonstrates converting an HTML string into a PDF document efficiently using clearly named methods.

<hr class="separator">

## 5. Creating PDF from ASPX

Convert ASPX to PDF effortlessly:

```cs
/**
PDF from ASPX
anchor-generate-pdf-from-aspx
**/
protected void OnPageLoad(object sender, EventArgs e)
        {
            IronPdf.AspxToPdf.RenderThisPageAsPdf();
        }
```

<hr class="separator">

## 6. Enhanced JavaScript Support

IronPDF is renowned for its competent handling of CSS and JavaScript within PDFs, providing versatility and functionality that are essential for modern .NET applications.

<hr class="separator">

## 7. Customizing Viewport Dimensions  

Responsive designs and JavaScript implementation within PDFs are made easy with IronPDF:

```cs
/**
Customize Viewport
anchor-generate-pdf-with-custom-viewport
**/
using IronPdf;
IronPdf.ChromePdfRenderer pdfRenderer = new IronPdf.ChromePdfRenderer();

pdfRenderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
pdfRenderer.ViewPortWidth = 1280; 

pdfRenderer.RenderHtmlFileAsPdf("Assets/Responsive.html");

```

To accommodate JavaScript execution during PDF conversion, consider adding:

```cs
pdfRenderer.RenderingOptions.EnableJavaScript = true;
pdfRenderer.RenderingOptions.RenderDelay = 500; //milliseconds
```