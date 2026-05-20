# C# Print PDF Documents

***Based on <https://ironpdf.com/how-to/__unlisted__csharp-print-pdf__/>***


Printing PDF documents using C# within .NET applications is straightforward with the aid of Visual Basic or C#. This guide shows you how to utilize C# to programmatically print PDFs.

<hr class="separator">

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

## Generate and Print a PDF

Directly printing a PDF document to a printer quietly or manipulating a [`System.Drawing.Printing.PrintDocument`](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument) object for GUI print dialogs is manageable using C#.

Utilize the below sample code for both scenarios:

```csharp
using IronPdf;
using System.Threading.Tasks;

// Instantiate a PDF renderer and print the document
ChromePdfRenderer PdfRenderer = new ChromePdfRenderer();
PdfDocument document = PdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Print the PDF using the default printer settings
await document.Print();

// To handle more complex silent printing scenarios, use the following method
// Ensure to link the System.Drawing.dll assembly
System.Drawing.Printing.PrintDocument CustomizedPrintDoc = document.GetPrintDocument();
```

<hr class="separator">

## Sophisticated Printing Techniques

IronPDF offers extensive capabilities for complex printing operations, such as selecting a specific printer or adjusting the printer resolution.

### Choosing a Printer

To select a specific printer, retrieve the print document object of the PDF using the [`GetPrintDocument` method](https://ironsoftware.com/ironpdf/object-reference/api/IronPdf.PdfDocument.html), then assign the printer using the `PrinterSettings.PrinterName` property like so:

```csharp
using IronPdf;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Access the PrintDocument
var printDoc = document.GetPrintDocument();

// Set the printer
printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

// Execute the print job
printDoc.Print();
```

### Printer Resolution Settings

The resolution setting adjusts the pixel density of the print output. Here’s how to set a custom resolution for your printer using the [`DefaultPageSettings.PrinterResolution` property](https://ironsoftware.com/ironpdf/object-reference/api/IronPdf.PdfDocument/):

```csharp
using IronPdf;
using System.Drawing.Printing;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Retrieve the PrintDocument
var printDoc = document.GetPrintDocument();

// Define custom resolution
printDoc.DefaultPageSettings.PrinterResolution = new PrinterResolution
{
    Kind = PrinterResolutionKind.Custom,
    X = 1200,
    Y = 1200
};

// Initiate printing
printDoc.Print();
```

The resolution has been set to 1200 DPI for both vertical and horizontal settings.

### Print to File Option

Using the `PdfDocument.PrintToFile` method, one can output the PDF to a file. Here’s how to print to a file without a preview:

```csharp
using IronPdf;
using System.Threading.Tasks;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

await document.PrintToFile("PathToFile", false);
```

<hr class="separator">

## Monitoring Printing Operations with C#

Leveraging C# along with IronPDF simplifies monitoring and tracking printing activities, such as adjusting printer settings or counting printed pages. Here's an example that demonstrates these functions:

```csharp
using IronPdf;

PdfDocument document = PdfDocument.FromFile("sample.pdf");

// Access the PrintDocument
var printDoc = document.GetPrintDocument();

// Add event to keep track of printed pages
var pageCount = 0;
printDoc.PrintPage += (sender, args) => pageCount++;

// Commence the print job
printDoc.Print();
```