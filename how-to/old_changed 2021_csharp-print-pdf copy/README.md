# Printing PDFs in C# with IronPDF

***Based on <https://ironpdf.com/how-to/old_changed 2021_csharp-print-pdf copy/>***


This guide elucidates the process of printing PDF documents in C# using the IronPDF library. Whether you are coding in Visual Basic or C#, this tutorial will guide you through the steps required for programmatic PDF printing.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Guide to C# PDF Printing</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-for-c-print-to-pdf">Install IronPDF for C# PDF Printing</a></li>
        <li><a href="#anchor-2-create-a-pdf-and-print">Generate and Print a PDF</a></li>
        <li><a href="#anchor-4-specify-printer-name">Select a Printer</a></li>
        <li><a href="#anchor-5-set-printer-resolution">Configure Printer Resolution</a></li>
        <li><a href="#anchor-7-tracing-printing-processes-using-c-num">Monitor Printing Activities in C#</a></li>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img src="https://ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" style="box-shadow: none; width: 308px; height: 320px;" class="img-responsive learn-how-to-img">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1: Installation</h4>

## Install IronPDF for C# PDF Printing

Begin by integrating the IronPDF library into your project to enable all the printing functionalities demonstrated in this guide. Download the development DLL for free from IronPDF's website [here](https://ironpdf.com/packages/IronPdf.Package.For.Print.CSharp.Programmatically.zip), or install IronPDF through NuGet in your Visual Studio environment.

```shell
Install-Package IronPdf
```

<hr class="separator">

<h4 class="tutorial-segment-title">Step 2: PDF Creation and Printing</h4>

## Generate and Print a PDF Document

Seamlessly send a PDF to a printer or manipulate it using the `System.Drawing.Printing.PrintDocument` object for GUI-based printing dialogs.

See the code example below to get started:

```cs
/* PDF Creation and Printing */
using IronPdf;

// Instantiate a PDF renderer
IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();

// Generate a PDF from a URL
using PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Print the PDF using the default printer
pdf.Print();

// For more robust printing options, get the PrintDocument object
System.Drawing.Printing.PrintDocument printDoc = pdf.GetPrintDocument();
```

This is a straightforward approach for leveraging [IronPDF's C# PDF printing capabilities](https://ironpdf.com/use-case/csharp-pdf-printer/).

<hr class="separator">

## Advanced Printing Features

Explore how IronPDF supports detailed printer configurations like selecting printer names and adjusting printing resolutions.

## Specify Printer

Configure the printer by retrieving the active print document and modifying its `PrinterSettings.PrinterName` property:

```cs
/* Select Printer */
using IronPdf;

using (var renderer = new ChromePdfRenderer()) {
    using (var pdfDocument = renderer.RenderHtmlAsPdf(TestSources.HtmlTemplateBasicText())) {
        using (var printDocument = pdfDocument.GetPrintDocument()) {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.Print();
        }
    }
}
```

<hr class="separator">

## Set Printing Resolution

Adjust the resolution to define the clarity of your printed PDF. Here's a brief example to set a custom resolution:

```cs
/* Adjust Printer Resolution */
using IronPdf;

using (var renderer = new ChromePdfRenderer()) {
    using (var pdfDocument = renderer.RenderHtmlAsPdf(TestSources.HtmlTemplateBasicText())) {
        using (var printDocument = pdfDocument.GetPrintDocument()) {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };
            printDocument.Print();
        }
    }
}
```

<hr class="separator">

## Print to File Option

You can also direct the printing output to a file. Just specify the destination:

```cs
/* Direct PDF Printing to File */
using (var printDocument = pdfDocument.GetPrintDocument()) {
    printDocument.PrintToFile("PathToFile", false);
}
```

<hr class="separator">

## Monitoring Printing Processes in C&#35;

Track printing details such as printer configuration changes and page counts effortlessly:

```cs
/* Monitoring Print Details */
using IronPdf;

using (var renderer = new ChromePdfRenderer()) {
    using (var pdfDocument = renderer.RenderHtmlAsPdf(TestSources.HtmlTemplateBasicText())) {
        using (var printDocument = pdfDocument.GetPrintDocument()) {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };

            int printedPages = 0;
            printDocument.PrintPage += (_, _) => printedPages++;
            printDocument.Print();
        }
    }
}
```