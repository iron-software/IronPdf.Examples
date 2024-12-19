# Printing PDF Files in C# with IronPrint

***Based on <https://ironpdf.com/how-to/print-pdf/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Discover the new [IronPrint .NET Printing Library](https://ironsoftware.com/csharp/print/), a comprehensive .NET library ensuring compatibility across numerous platforms like Windows, macOS, Android, and iOS. Start with IronPrint and [Learn How to Get Started](https://ironsoftware.com/csharp/print/docs/) today!
</div>

Automate the process of sending PDF documents to a printer directly from .NET C# code. This functionality simplifies integrating robust printing capabilities into your applications, minimizing manual operations while enhancing the consistency of your PDF outputs. Gain precise control over every aspect of the printing process.

IronPDF provides a straightforward means to print documents directly to a physical printer through a single method call, supporting the printing of multiple PDF documents. Additionally, you can define the print resolution through adjustable DPI settings for both horizontal and vertical axes. Advanced control can be achieved by utilizing the `Microsoft PrinterSettings` and `PrintController` for comprehensive management of your printing needs.

### Getting Started with IronPDF

----------------------------

## Printing a PDF File Example

The `Print` method within the `PdfDocument` class allows for printing of both newly created and pre-existing PDF files. Use this method to send a document to the default system printer, or specify a different printer using the printer's name.

Please note, printing features are primarily supported on Windows platforms.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Print</h1>");

// Printing the document using a specific printer
pdf.Print("Microsoft Print to PDF");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/print-pdf/print-queue.webp" alt="Print queue" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Setting Printer Resolution

Adjust the printed PDF's resolution by inputting your desired DPI. Specify uniform DPI for both axes or different values for horizontal (x) and vertical (y) resolutions respectively.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example DPI Setting</h1>");

// Setting a custom uniform DPI
pdf.Print(300);

// Defining specific DPI for horizontal and vertical resolutions
pdf.Print(10, 10, "Microsoft Print to PDF");
```

Next, we'll explore the concept of printing to a file format.

<hr>

## Printing to a File

Utilize the `PrintToFile` method to convert a PDF into a bitmap format, which is then saved as a PDF. This rasterization uses the native Windows printer—in this case, "Microsoft Print to PDF." It's important to note that this function saves the file to the disk rather than sending it to a physical printer.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>File Print Example</h1>");

// Save the document as a file
pdf.PrintToFile("");
```

<hr>

## Fine-Tuning Print PDF Document Settings

To adjust print settings further, the `GetPrintDocument` method can be implemented, which supports `Microsoft PrinterSettings` and `PrintController`. This method retrieves the current print document configuration. Below is an example showing how to configure the settings, and descriptions on each setting are provided after the code.

```cs
using IronPdf;
using System.Drawing.Printing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Advanced Setting Example</h1>");

PrinterSettings settings = new PrinterSettings() {
    PrinterName = "Microsoft Print to PDF",
    Copies = 2,
    FromPage = 2,
    ToPage = 4
};

PrintDocument document = pdf.GetPrintDocument(settings);

// Execute the print job
document.Print();
```

- **CanDuplex:** Determines whether double-sided printing is possible.
- **Collate:** Organizes multiple files or copies when printed, based on setting.
- **Copies:** Defines how many copies of a document to print.
- **DefaultPageSettings:** Sets default paper size, margins, and orientation.
- **Duplex:** Chooses the mode of double-sided printing.
- **InstalledPrinters:** Lists available printers.
- **IsDefaultPrinter:** Checks if a specified printer is the default.
- **IsPlotter:** Identifies if the device is a plotter, useful for large prints.
- **IsValid:** Validates if the printer settings are suitable for PDF printing.
- **LandscapeAngle:** Angle adjustment for landscape printing.
- **MaximumCopies, MaximumPage, MinimumPage:** Configures limits on copies and page numbers.
- **PaperSizes, PaperSources:** Lists supported paper sizes and input trays.
- **PrinterName:** Specifies which printer to use.
- **PrinterResolutions:** Lists possible print resolutions.
- **PrintFileName:** Sets the filename for printing to file.
- **PrintRange, FromPage, ToPage:** Determines range of pages to print.
- **PrintToFile:** Decides if output is to file rather than printer.
- **SupportsColor:** Indicates color printing capability.

To set the default printer, access the "Printers & Scanners" section in your machine settings.