# C# Print PDF Documents

Leveraging .NET libraries such as Visual Basic or C#, you can seamlessly print PDF documents programmatically. This guide presents a step-by-step process on using C# to print PDF files.

---

## Create and Print a PDF

You have the option to directly send a PDF document to a printer or utilize a [`System.Drawing.Printing.PrintDocument`](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument) object for further manipulation and GUI print dialog integration.

Here's how you can implement both approaches:

```cs
using IronPdf;
using System.Threading.Tasks;

// Initialize a PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF from a URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Directly print the PDF using the default printer
await pdf.Print();

// For silent printing scenarios with more control:
// Convert the PDF into a PrintDocument object
// Make sure to include a reference to System.Drawing.dll
System.Drawing.Printing.PrintDocument printableDocument = pdf.GetPrintDocument();
```

---

## Advanced Printing Techniques

IronPDF supports a variety of advanced printing functionalities including printer customization and resolution settings.

### Specifying the Printer Name

To select a different printer, simply retrieve the print document and adjust the `PrinterSettings.PrinterName`:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve the PrintDocument
var printDocument = pdf.GetPrintDocument();

// Set the specific printer
printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";

// Execute the print job
printDocument.Print();
```

### Setting Printer Resolution

The resolution, indicating the print quality in terms of pixels, can be specified through the `DefaultPageSettings.PrinterResolution`:

```cs
using IronPdf;
using System.Drawing.Printing;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Access the PrintDocument
var printDocument = pdf.GetPrintDocument();

// Adjust the printer resolution
printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
{
    Kind = PrinterResolutionKind.Custom,
    X = 1200, // Horizontal resolution
    Y = 1200  // Vertical resolution
};

// Initiate the print process
printDocument.Print();
```

In this example, the resolution is finely set to 1200x1200.

### Print-to-File Capability

With `PdfDocument.PrintToFile`, you can print a PDF directly to a file. Here's how to do it without showing the print preview:

```cs
using IronPdf;
using System.Threading.Tasks;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

await pdf.PrintToFile("PathToFile", false);
```

---

## Monitoring Printing Actions with C#

C# combined with IronPDF simplifies monitoring various printing attributes like page counts. Here is a demonstration of changing printer settings and tracking pages printed:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Acquire the PrintDocument
var printDocument = pdf.GetPrintDocument();

// Setup to count printed pages
int printedPages = 0;
printDocument.PrintPage += (sender, args) => printedPages++;

// Proceed with printing
printDocument.Print();
```