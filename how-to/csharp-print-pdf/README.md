# Print PDFs using C# Code

***Based on <https://ironpdf.com/how-to/csharp-print-pdf/>***


In this comprehensive guide, we'll explore how to print PDF files using C# within .NET applications, encompassing both Visual Basic and C#. These techniques allow for silent and UI-based printing directly from your codebase.

---

## Generating and Printing PDFs

Silently sending a PDF to a printer or engaging with user interfaces through the `[System.Drawing.Printing.PrintDocument](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument)` object is seamlessly achievable. Here, we present code implementations for both pathways:

```cs
using IronPdf;
using System.Threading.Tasks;

// Instantiate a PDF renderer and print a document
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render a PDF from a URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Direct printing using the default printer
await pdf.Print();

// To handle more complex printing scenarios, retrieve the PrintDocument
// Note: Include a reference to System.Drawing.dll
System.Drawing.Printing.PrintDocument configurablePrintDoc = pdf.GetPrintDocument();
```

---

## Advanced Printing Capabilities

IronPDF supports intricate printing options such as specifying printer details and adjusting resolution parameters, enhancing your control over how documents are printed.

### Customizing Printer Selection

By accessing the printer settings of a PDF document, you can specify which printer to use. Here's how you can achieve this:

```cs
using IronPdf;

// Load a PDF from the filesystem
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Retrieve its associated PrintDocument
var printDocument = pdf.GetPrintDocument();

// Set the desired printer
printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";

// Execute the print job
printDocument.Print();
```

### Configuring Printer Resolution

Adjusting the print resolution of your document is straightforward. Set the resolution with the `DefaultPageSettings.PrinterResolution` property as demonstrated below:

```cs
using IronPdf;
using System.Drawing.Printing;

// Load a local PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Access PrintDocument for further customization
var printDocument = pdf.GetPrintDocument();

// Adjust resolution settings
printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
{
    Kind = PrinterResolutionKind.Custom,
    X = 1200,  // Horizontal resolution
    Y = 1200   // Vertical resolution
};

// Start the print job
printDocument.Print();
```

### Outputting to a File

IronPDF also allows printing directly to a file without displaying a preview using the `PdfDocument.PrintToFile` method:

```cs
using IronPdf;
using System.Threading.Tasks;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

await pdf.PrintToFile("PathToFile", false);
```

---

## Monitoring Printing Operations in C#

C# combined with IronPDF simplifies the monitoring of your printing processes. Let’s go through modifying printer settings, tracking printed pages, and more:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Grab its PrintDocument
var printDocument = pdf.GetPrintDocument();

// Track printed page count
int printedPagesCount = 0;
printDocument.PrintPage += (sender, args) => printedPagesCount++;

// Commence printing
printDocument.Print();
```

In this tutorial, we have covered a variety of techniques to manage and execute print operations via C#, providing robust solutions tailored for developers seeking precision in their document management tasks.