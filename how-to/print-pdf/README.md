# How to Print PDF Files in C#

***Based on <https://ironpdf.com/how-to/print-pdf/>***


<div class="alert alert-info iron-variant-1" role="alert">
Explore the [IronPrint .NET Printing Library](https://ironsoftware.com/csharp/print/), Iron Software's cutting-edge .NET printing library that supports multiple platforms including Windows, macOS, Android, and iOS. [Get started with IronPrint](https://ironsoftware.com/csharp/print/docs/) today!
</div>

Automating PDF printing from a .NET C# application enhances functional integration within applications, streamlines document handling, and ensures uniformity in PDF output. This automation provides meticulous control over the print management.

IronPDF introduces an efficient solution that allows for printing PDFs directly to a physical printer through a simple method call, facilitating the printing of multiple documents concurrently. It also enables users to define the printer resolution with customizable DPI settings for both horizontal and vertical dimensions. You can gain additional control by utilizing methods that accept both `PrinterSettings` and `PrintController`.

## Quickstart: Print PDFs in .NET with IronPDF

IronPDF simplifies the process of printing PDF documents in .NET applications. In just a few steps, you can integrate PDF printing capabilities with minimal configuration required, allowing for high-quality prints with adjustable settings. Start streamlining your document processes today.

```cs
:title=Effortless PDF Printing with IronPDF
// Load and print a PDF file with a single line of code
IronPdf.PdfDocument.FromFile("example.pdf").Print();
```

## Print PDF File Example

To print PDFs, IronPDF utilizes the `PdfDocument` object's `Print` method. By default, this prints to the system’s default printer, but you can specify another by providing the printer’s name.

Note: Printing support is currently only available on Windows platforms.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Create a new PDF document from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");

// Command to send the document to the "Microsoft Print to PDF" printer
pdf.Print("Microsoft Print to PDF");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/print-pdf/print-queue.webp" alt="Print queue" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Printer Resolution

Modify the DPI settings of your printed documents by assigning a DPI value to the `Print` method, affecting both the horizontal and vertical dimensions equally. For differentiated DPI settings, input two distinct values.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Create a PDF from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");

// Example of setting custom DPI
pdf.Print(300);

// Example of setting specific horizontal and vertical DPI
pdf.Print(10, 10, "Microsoft Print to PDF");
```

Discover how to rasterize and save PDFs in the following example.

<hr>

## Print to File

The `PrintToFile` method converts PDFs to bitmap images and saves them as PDF files on the local disk. This is done using a built-in Windows printer like "Microsoft Print to PDF," bypassing physical printing.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF from HTML content
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");

// Print the document to a file
pdf.PrintToFile("");
```

<hr>

## Explore Print PDF Document Settings

Fine-tune your print settings with the `GetPrintDocument` method, which works with `PrinterSettings` and `PrintController`. This method allows you to customize various printing aspects such as page range and printer choice, while also providing extensive control over the print job including exception handling, progress reporting, and more. Below are several options you can configure:

```csharp
using IronPdf;
using System.Drawing.Printing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Testing</h1>");

PrinterSettings settings = new PrinterSettings() {
    PrinterName = "Microsoft Print to PDF",
    Copies = 2,
    FromPage = 2,
    ToPage = 4,
};

PrintDocument document = pdf.GetPrintDocument(settings);

// Execute the actual print command
document.Print();
```

Below is a comprehensive list of `PrinterSettings` options and their implications:

- **CanDuplex**: Determines if the printer supports duplex printing.
- **Collate**: Manages whether pages should be collated.
- **Copies**: Number of copies to print.
- **DefaultPageSettings**: Default settings like paper size and orientation.
- **Duplex**: Duplex (double-sided) printing mode.
- **InstalledPrinters**: List of printers installed.
- **IsDefaultPrinter**: Checks if this is the default printer.
- **IsPlotter**: Used for large-format printers.
- **IsValid**: If the printer settings are valid for printing.
- **LandscapeAngle**: Orientation angle for landscape printing.
- **MaximumCopies**: Maximum number of copies allowable.
- **MaximumPage**: Upper limit of page numbers that can be printed.
- **MinimumPage**: Lower limit of page numbers.
- **PaperSizes**: Supported paper sizes.
- **PaperSources**: Available paper sources or trays.
- **PrinterName**: Name of the printer being used.
- **PrinterResolutions**: Available print resolutions.
- **PrintFileName**: Filename when printing to a file.
- **PrintRange**: Specific pages to be printed.
- **PrintToFile**: Whether to print to a file instead of a printer.
- **SupportsColor**: If the printer can print in color.

For setting the default printer for PDFs, navigate to the "Printers & Scanners" section in your machine settings.