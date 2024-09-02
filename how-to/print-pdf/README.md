# Printing PDF Documents with Iron Software

<div class="alert alert-info iron-variant-1" role="alert">
	Explore IronPrint, the latest .NET printing library from <a href="https://ironsoftware.com/csharp/print/">Iron Software</a>. Compatible across various platforms such as Windows, macOS, Android, and iOS. Start using <a href="https://ironsoftware.com/csharp/print/docs/">IronPrint</a> today!
</div>

Initiating a PDF print job directly from .NET C# spares you the manual task, integrating printing solutions within your applications seamlessly. This ensures uniformity in PDF outputs and provides detailed management of the printing settings.

IronPDF introduces a streamlined method to initiate printing to any physical printer swiftly, supporting multiple document printouts in a single function call. You can specify printer resolutions by setting both vertical and horizontal DPI, offering a robust way to manage print quality. For enhanced control, integrate Microsoft's `PrinterSettings` and `PrintController`.

## Example: Printing a PDF File

To print PDF files, whether newly generated or pre-existing, use the `Print` method from the `PdfDocument` object. You can easily print to the default system printer or specify another by passing the printer's name to the `Print` method.

Remember, printing functionalities are currently supported solely on Windows platforms.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument document = renderer.RenderHtmlAsPdf("<h1>Example PDF Print</h1>");

// Direct printing to the "Microsoft Print to PDF" printer
document.Print("Microsoft Print to PDF");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/print-pdf/print-queue.webp" alt="Visual of print queue" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Setting the Printer Resolution

You can adjust a PDF’s print resolution by inputting a desired DPI value into the `Print` method, affecting both the horizontal and vertical DPI uniformly. For independent DPI settings, two parameters may be used: the first for horizontal (x) and the second for vertical (y).

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument document = renderer.RenderHtmlAsPdf("<h1>Example Document</h1>");

// Set custom resolution
document.Print(300);  // Uniform DPI setting

// Custom resolution for each direction
document.Print(10, 10, "Microsoft Print to PDF");  // Specific DPI settings
```

Let's dive further into an example of how to rasterize and preserve a PDF file.

<hr>

## Rasterize and Preserve PDF as File

The `PrintToFile` method allows for the rasterization of PDFs, converting them into a bitmap format before saving. This conversion is handled by your system's built-in printer capabilities and saves the resultant file on your disk without sending it to an external printer.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument document = renderer.RenderHtmlAsPdf("<h1>Rasterize and Save PDF</h1>");

// Save rasterized PDF to file
document.PrintToFile("OutputFilename.pdf");  // specify the file name as needed
```

<hr>

## Understanding Print Document Settings

For finer control over printing preferences, employ the `GetPrintDocument` method. This method accepts configurations via both `PrinterSettings` and `PrintController`, facilitating detailed management of your print jobs.

```cs
using IronPdf;
using System.Drawing.Printing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument document = renderer.RenderHtmlAsPdf("<h1>Detailed Printing</h1>");

PrinterSettings settings = new PrinterSettings() {
    PrinterName = "Microsoft Print to PDF",
    Copies = 2,
    FromPage = 2,
    ToPage = 4
};

PrintDocument printDoc = document.GetPrintDocument(settings);

// Execute print job
printDoc.Print();
```

PrinterSettings and PrintController offer numerous properties to customize, such as duplex printing, collation, dealing with exceptions, progress reports, and more. These tools ensure your application meets all your printing requirements perfectly.

For setting up your preferred default printer, navigate to the "Printers & Scanners" settings on your device.