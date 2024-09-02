# Print PDF Documents in C#

In this tutorial, you will learn how to employ C# to print PDF documents in .NET applications using either Visual Basic or C#. It provides a step-by-step guide on leveraging the C# capabilities to initiate printing programmatically.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>C# PDF Printer Procedures</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-ironpdf-for-c-print-to-pdf">Setting Up IronPDF for C# Printing</a></li>
        <li><a href="#anchor-2-create-a-pdf-and-print">Generating and Printing a PDF</a></li>
        <li><a href="#anchor-4-specify-printer-name">Designating a Printer Name</a></li>
        <li><a href="#anchor-5-set-printer-resolution">Determining Printer Resolution</a></li>
        <li><a href="#anchor-7-tracing-printing-processes-using-c-num">Monitoring Printing Procedures with C# and More</a></li>
      </ul>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="https://www.ironpdf.com/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="https://www.ironpdf.com/img/faq/pdf-in-csharp-no-button.svg" class="img-responsive learn-how-to-img">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## Set Up IronPDF in Your C# Project

To commence, download and integrate the IronPDF C# PDF Library to enable all the programmatic printing functions showcased in this tutorial. You may [download the package for development](https://www.ironpdf.com/packages/IronPdf.Package.For.Print.CSharp.Programmatically.zip) or proceed to [install it via NuGet](https://www.nuget.org/packages/IronPdf) and include it in your Visual Studio project.

<br>

```shell
/Install-Package IronPdf
```

<hr class="separator">
<h4 class="tutorial-segment-title">Step-by-Step Guide</h4>

## Create and Print a PDF Quietly or Via UI

Whether you aim for silent printing or utilizing GUI print dialogs, you can handle PDF documents as shown below:

```cs
/**
Create and Print PDF
**/
using IronPdf;

// Instantiate a new PDF renderer
IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();

// Render a URL as PDF
using PdfDocument Pdf = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Send the PDF to the printer
Pdf.Print();

// For finer control over printing options:
System.Drawing.Printing.PrintDocument PrintDocumentRef = Pdf.GetPrintDocument();
```

Explore further through [C# PDF printer use cases](https://www.ironpdf.com/use-case/csharp-pdf-printer/).

<hr class="separator">

## Advanced Printing Functions

Delve deeper into advanced features of IronPDF for customizing your printing jobs, including printer name selection and resolution settings.

## Define Printer Name

Configure the printer by extracting the printer name from the [GetPrintDocument](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) method, and set it using the `PrinterSettings.PrinterName` property:

```cs
/**
Define Printer Name
**/
using (var ChromePdfRenderer = new ChromePdfRenderer())
{
    using (var pdfDocument = ChromePdfRenderer.RenderHtmlAsPdf("Sample HTML string"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Your Preferred Printer";
            printDocument.Print();
        }
    }
}
```
<hr class="separator">

## Adjust Printer Resolution

Modify the resolution settings using the `PrinterResolution` property to specify the desired dpi settings:

```cs
/**
Adjust Printer Resolution
**/
using (var ChromePdfRenderer = new ChromePdfRenderer())
{
    using (var pdfDocument = ChromePdfRenderer.RenderHtmlAsPdf("Sample HTML string"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Adobe PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };
            printDocument.Print();
        }
    }
}
```
Observe that the resolution has been personalized to 1200x1200 dpi both for the vertical and horizontal dimensions.

<hr class="separator">

## Printing to a File

Utilize the `PrintToFile` method from `PdfDocument` to direct your output to a file without requiring a print preview:

```cs
/**
Print to File
**/
printDocument.PrintToFile("DesiredFilePath", false);
```

This method enables you to specify the file path and opt out of previewing before printing.

<hr class="separator">

## Monitor Printing Activities in C#

Leveraging C# and IronPDF simplifies the process of tracking print operations and adjusting printer settings:

```cs
/**
Monitor Printing Activities
**/
using (var ChromePdfRenderer = new ChromePdfRenderer())
{
    using (var pdfDocument = ChromePdfRenderer.RenderHtmlAsPdf("Sample HTML string"))
    {
        using (var printDocument = pdfDocument.GetPrintDocument())
        {
            printDocument.PrinterSettings.PrinterName = "Adobe PDF";
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom, 
                X = 1200, 
                Y = 1200
            };
            
            int printedPages = 0;
            printDocument.PrintPage += (sender, args) => printedPages++;
            printDocument.Print();
        }
    }
}
```