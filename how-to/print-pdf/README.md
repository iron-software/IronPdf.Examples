# Printing PDF Files in .NET with IronPrint

***Based on <https://ironpdf.com/how-to/print-pdf/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Discover the capabilities of the [IronPrint .NET Printing Library](https://ironsoftware.com/csharp/print/), the latest solution from Iron Software, ensuring compatibility across diverse platforms such as Windows, macOS, Android, and iOS. Start your journey with IronPrint by accessing the [Getting Started Guide](https://ironsoftware.com/csharp/print/docs/).
</div>

Automating the printing of PDF documents via .NET C# is efficient, allowing for the integration of print functionality into your apps. This process facilitates streamlined PDF output and ensures uniformity in your printed documents.

IronPDF enables swift printing to physical printers with a single method call, supporting the printing of multiple PDF documents simultaneously. You can define the printer resolution, opting for specific DPI values both horizontally and vertically. Advanced control over the print function is provided through integration with both Microsoft `PrinterSettings` and `PrintController`.

## Example: Printing a PDF File

Using the `Print` method from the `PdfDocument` class, you can print your PDFs. This method allows for printing from both newly generated and existing PDFs directly to your default printer or to a specified printer using its name as a parameter.

It's important to note that all printing capabilities are currently only supported on the 'Windows' platform.

```cs
using IronPdf;
namespace ironpdf.PrintPdf
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Demonstrating Print</h1>");
            
            // Directs the PDF to the intended printer "Microsoft Print to PDF"
            pdf.Print("Microsoft Print to PDF");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/print-pdf/print-queue.webp" alt="Print queue" class="img-responsive add-shadow">
    </div>
</div>

<hr>

## Setting Printer Resolution

You can set the resolution for printing your PDF by supplying a DPI value to the `Print` method. For separate DPI settings for horizontal and vertical dimensions, two parameters can be used.

```cs
using IronPdf;
namespace ironpdf.PrintPdf
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Testing Resolution</h1>");
            
            // Establish a custom DPI
            pdf.Print(300);
            
            // Adjustable printing resolutions
            pdf.Print(10, 10, "Microsoft Print to PDF");
        }
    }
}
```

Now, let's explore an example of rasterizing and saving a PDF file.

<hr>

## Printing to File

Utilize the `PrintToFile` method for converting PDF documents into a bitmap format, thereby saving them as a file. This operation is facilitated by an internal printer, in my case, "Microsoft Print to PDF". This operation saves the file on disk without actually printing it.

```cs
using IronPdf;
namespace ironpdf.PrintPdf
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = a ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Print to File</h1>");
            
            // Performs print to file operation
            pdf.PrintToFile("");
        }
    }
}
```

<hr>

## Advanced Print PDF Document Configuration

For more refined control, the `GetPrintDocument` method allows integration with both `PrinterSettings` and `PrintController`, offering detailed management of the printing process. Below is an example accompanied by a description of various settings.

```cs
using System.Drawing.Printing;
using IronPdf;
namespace ironpdf.PrintPdf
{
    public class Section4
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Advanced Printing</h1>");

            PrinterSettings settings = new PrinterSettings()
            {
                PrinterName = "Microsoft Print to PDF",
                Copies = 2,
                FromPage = 2,
                ToPage = 4,
            };

            PrintDocument document = pdf.GetPrintDocument(settings);

            // Initiates the printing process
            document.Print();
        }
    }
}
```
- **CanDuplex**: Indicates the printer's capability for duplex printing.
- **Collate**: Organizes multiple files or copies during printing.
- **Copies**: Specifies the number of copies to print.
- **DefaultPageSettings**: Contains default settings like paper size and orientation.
- **Duplex**: The mode of duplex printing.
- **InstalledPrinters**: Lists the printers installed on the system.
- **IsDefaultPrinter**: Checks if a specified printer is the default.
- **IsPlotter**: Identifies if the printer is a plotter.
- **IsValid**: Validates the viability of the printer settings.
- **LandscapeAngle**: The rotation angle for landscape orientation.
- **MaximumCopies**: The maximum number of copies allowed.
- **MaximumPage**: The highest page number available for printing.
- **MinimumPage**: The lowest page number available for printing.
- **PaperSizes**: Lists available paper sizes.
- **PaperSources**: Available paper sources or trays.
- **PrinterName**: The name of the printer.
- **PrinterResolutions**: Available printer resolutions.
- **PrintFileName**: The filename for printing to a file.
- **PrintRange**: Defines the range of pages to print.
- **FromPage**: The start page number for printing.
- **ToPage**: The end page number for printing.
- **PrintToFile**: Specifies printing to a file.
- **SupportsColor**: Checks if the printer supports color printing.

To set up a default printer for PDFs, access the "Printers & Scanners" section in your system settings.