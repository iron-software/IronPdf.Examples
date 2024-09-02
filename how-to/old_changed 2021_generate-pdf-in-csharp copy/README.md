# Generate PDF in C#

Creating and managing PDF documents quickly and effectively within C# projects is a continual goal for developers. Utilizing user-friendly functions from a library streamlines the process significantly, allowing us to concentrate on more important development tasks rather than the overhead involved in PDF generation whether we're working with .NET Core or .NET Framework.

Here are several practical examples for your C# projects on generating PDFs including from HTML strings and ASPX inputs, among others.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>C# PDF Generator</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-free-c-library">Install the IronPDF library for PDF generation</a></li>
        <li><a href="#anchor-4-generate-pdf-from-html-string">Create PDFs from HTML strings</a></li>
        <li><a href="#anchor-5-generate-pdf-from-aspx">Generate PDFs from ASPX inputs</a></li>
        <li><a href="#anchor-7-generate-pdf-with-custom-viewport">Configure custom viewport settings for JavaScript and more</a></li>
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

## 1. Install the Free C# Library

Begin this tutorial by installing the IronPDF C# HTML to PDF Library. It's available for free during development within your projects. 

You can acquire the software either via [direct file download](https://ironpdf.com/packages/IronPdf.Package.For.Generate.PDF.Documents.zip) or by installing the latest [NuGet Package](https://www.nuget.org/packages/IronPdf) directly into your Visual Studio project.

<br>

```shell
/Install-Package IronPdf
```

<hr class="separator">
<h4 class="tutorial-segment-title">How to Tutorial</h4>

## 2. Utilize .NET Framework & .NET Core

IronPDF turns complex PDF interactions into simple, meaningful .NET methods, boosting developer productivity and development speed for projects based on both frameworks. IronPDF is fully adaptable with .NET Framework versions 4 and above, as well as with .NET Core starting from version 2.

<hr class="separator">

## 3. Master Simplified Naming Conventions

The efficiency and simplicity of IronPDF stem from its quick output generation and developer-friendly method names in the IronPDF library.

Key advantages include the speed of execution and intuitive method names which make the library straightforward to use, enhancing productivity in managing PDFs with .NET, for both VB.NET and C# developers.

<hr class="separator">

## 4. Generate PDF from HTML String

Generating a PDF in IronPDF is straightforward. Here’s how you can create a PDF from an HTML string.

```cs
/**
PDF from HTML String Tutorial
anchor-generate-pdf-from-html-string
**/
private void ConvertHtmlToStringPDF()
        {
            // Instantiates a PDF renderer
            var Renderer = new IronPdf.ChromePdfRenderer();
            using var PDF = Renderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF</h1>");

            var OutputPath = "OutputPDF.pdf";
            PDF.SaveAs(OutputPath);
        }
```

This snippet creates a PDF using five lines of code, showcasing well-named methods:
* `ChromePdfRenderer`
* `RenderHtmlAsPdf`
* `SaveAs`

Both newcomers and seasoned developers can recognize and utilize these methods in their VB.NET or C# applications to effortlessly create PDF files.

<hr class="separator">

## 5. Generate PDF from ASPX  

Here's how simple it is to generate a PDF from an ASPX file using IronPDF.

```cs
/**
PDF from ASPX Example
anchor-generate-pdf-from-aspx
**/
protected void ASPXtoPDF_Conversion(object sender, EventArgs e)
        {

            IronPdf.AspxToPdf.RenderThisPageAsPdf();
        }

```

<hr class="separator">

## 6. Support for JavaScript

IronPDF excels at handling responsive layouts and JavaScript, making it an invaluable resource for developers. With its capability to understand both CSS and JavaScript, there’s seldom a need for another .NET PDF library.

<hr class="separator">

## 7. Generate PDF with Custom Viewport  

Explore how to implement responsive designs and JavaScript in your PDFs with this example.

This code allows you to set a custom viewport size when generating PDFs to ensure optimal rendering.

```cs
/**
Responsive PDF Generation
anchor-generate-pdf-with-custom-viewport
**/
using IronPdf;
IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();

 //Specify CSS media type, screen, or print
Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;

//Set the width of the viewport in pixels
Renderer.ViewPortWidth = 1280; 

// Render a responsive HTML file or snippet as a PDF
Renderer.RenderHTMLFileAsPdf("Assets/ResponsivePage.html");

```

IronPDF also accommodates JavaScript, with settings available to manage JavaScript execution time effectively during PDF generation:

```cs
Renderer.RenderingOptions.EnableJavaScript = true;
Renderer.RenderingOptions.RenderDelay = 500; //milliseconds
```