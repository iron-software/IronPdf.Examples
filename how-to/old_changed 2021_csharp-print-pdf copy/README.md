# C# Print PDF Documents

***Based on <https://ironpdf.com/how-to/old_changed 2021_csharp-print-pdf copy/>***


Utilizing C# or Visual Basic within .NET applications makes printing PDFs straightforward. This guide will lead you through the process of printing PDF documents programmatically using C#.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Steps for Printing PDFs in C#</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-for-c-print-to-pdf">Begin by Installing IronPDF for C# Printing</a></li>
        <li><a href="#anchor-2-create-a-pdf-and-print">Generate and Directly Print PDFs</a></li>
        <li><a href="#anchor-4-specify-printer-name">Choose Your Printer Name</a></li>
        <li><a href="#anchor-5-set-printer-resolution">Adjust the Printer Resolution</a></li>
        <li><a href="#anchor-7-tracing-printing-processes-using-c-num">Monitor Your Print Processes and More with C#</a></li>
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

## 1. Initialize IronPDF in Your C# Project

The first step is to integrate the IronPDF C# PDF Library to enable all the printing capabilities showcased in this tutorial. You may either [download the library for free for development purposes directly from IronPDF's official website](https://ironpdf.com/packages/IronPdf.Package.For.Print.CSharp.Programmatically.zip), or [install it using NuGet](https://www.nuget.org/packages/IronPdf) and incorporate it into your Visual Studio project.

<br>

```shell
Install-Package IronPdf
```

<hr class="separator">
<h4 class="tutorial-segment-title">How to Tutorial</h4>

## 2. Generate and Directly Print PDFs

Directly printing a PDF to a printer or leveraging the `[System.Drawing.Printing.PrintDocument](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument)` for GUI alterations and detailed control is straightforward.

The code snippet below will help you with both approaches:

```cs
/**
Generate and Print a PDF
anchor-create-a-pdf-and-print
**/
using IronPdf;

// Instantiate a new PDF renderer
IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();

// Render a PDF from a URL
using (PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf"))
{
    // Directly send PDF document to the default printer
    pdf.Print();

    // To manipulate print settings and silent printing, utilize the GetPrintDocument method
    System.Drawing.Printing.PrintDocument printDoc = pdf.GetPrintDocument(); // Ensure you reference System.Drawing.dll
}
```

This is by far the simplest approach to utilize the [C# PDF printing capabilities provided by IronSoftware](https://ironpdf.com/use-case/csharp-pdf-printer).

<hr class="separator">

## 3. Advanced Printing Features

IronPDF supports a variety of advanced features for printing, like choosing a printer or adjusting its settings.

## 4. Define the Printer Name

Setting your desired printer is easy by accessing the current print document object using IronPDF’s `GetPrintDocument` method, and modifying the `PrinterSettings.PrinterName` property accordingly:

```cs
/**
Define Printer Name
anchor-specify-printer-name
**/
using (var renderer = new ChromePdfRenderer())
{
    using (var pdfDocument = renderer.RenderHtmlAsPdf("<html>...</html>"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.Print(); // Executing the print command
        }
    }
}
```

<hr class="separator">

## 5. Configure Printer Resolution

Resolution impacts the crispness of your print output. Adjust it in IronPDF by manipulating the `DefaultPageSettings.PrinterResolution` property:

```cs
/**
Adjust Printer Resolution
anchor-set-printer-resolution
**/
using (var renderer = new ChromePdfRenderer())
{
    using (var pdfDocument = renderer.RenderHtmlAsPdf("<html>...</html>"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom,
                X = 1200, // Horizontal resolution
                Y = 1200 // Vertical resolution
            };
            printDocument.Print(); // Execute print
        }
    }
}
```

Here, the resolution is configured to a custom setting of 1200 pixels both vertically and horizontally.

<hr class="separator">

## 6. Printing PDFs to Files

The `PDFDocument.PrintToFile` method allows you to output the PDF to a file. You can choose whether to include a print preview:

```cs
/**
Method to Print PDF to File
anchor-printtofile-method
**/
printDocument.PrintToFile("PathToFile", false); // Specify path and if preview is desired
```

This method directly outputs your PDF to the specified filepath without including a preview.

<hr class="separator">

## 7. Monitoring Printing Operations with C#

C# combined with IronPDF makes it easy to track and manage your print jobs. The next example demonstrates how to modify printer settings and monitor page counts during printing:

```cs
/**
Monitor Print Operations
anchor-tracing-printing-processes-using-c-num
**/
using (var renderer = new ChromePdfRenderer())
{
    using (var pdfDocument = renderer.RenderHtmlAsPdf("<html>...</html>"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };

            int pageCount = 0; // Variable to track the number of printed pages
            printDocument.PrintPage += (sender, args) => pageCount++; // Increment pageCount for each printed page
            printDocument.Print(); // Execute the print command
        }
    }
}
```