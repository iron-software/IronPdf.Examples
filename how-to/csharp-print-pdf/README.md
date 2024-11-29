# C# Print PDF Documents

***Based on <https://ironpdf.com/how-to/csharp-print-pdf/>***


In this guide, we'll explore how to implement PDF printing functionality in .NET applications using Visual Basic or C#. We provide step-by-step instructions to enable you to print PDFs programmatically using C#.

<hr class="separator">

## Create and Print a PDF

You have the choice to either directly send a PDF to the printer silently or generate a `[System.Drawing.Printing.PrintDocument](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument)` for interactive GUI printing dialogs.

The following sample code demonstrates both approaches:
```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section1
    {
        public async Task Run()
        {
            // Instantiates PDF renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Generate PDF from URL
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            
            // Printing the PDF using the default printer
            await pdf.Print();
            
            // Retrieve a PrintDocument for customization and silent printing options
            System.Drawing.Printing.PrintDocument PrintDocYouCanWorkWith = pdf.GetPrintDocument();
        }
    }
}
```

<hr class="separator">

## Advanced Printing Techniques

IronPDF supports advanced printing functionalities, including selecting printers by name and adjusting printer resolution.

### Choosing a Printer

Setting a specific printer name can be done simply by accessing the current print document’s properties via `[GetPrintDocument method](https://www.ironpdf.com/object-reference/api/IronPdf.PdfDocument.html)` and assigning it the desired printer using `PrinterSettings.PrinterName`, as illustrated below:

```cs
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Fetch PrintDocument
            var printDocument = pdf.GetPrintDocument();
            
            // Setting printer name
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            // Commence printing process
            printDocument.Print();
        }
    }
}
```

### Adjusting Printer Resolution

Resolution change, which impacts the sharpness of the print output, is controlled through the [`DefaultPageSettings.PrinterResolution property](https://www.ironpdf.com/object-reference/api/IronPdf.PdfDocument/)`:

```cs
using System.Drawing.Printing;
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section3
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Access PrintDocument to modify settings
            var printDocument = pdf.GetPrintDocument();
            
            // Set custom resolution
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };
            
            // Trigger the print job
            printDocument.Print();
        }
    }
}
```

### Printing to a File

The `PdfDocument.PrintToFile` method facilitates printing a PDF directly to a file. This example illustrates how to print without displaying a preview:

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section4
    {
        public async Task Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Print to a specified file path
            await pdf.PrintToFile("PathToFile", false);
        }
    }
}
```

<hr class="separator">

## Monitoring Printing Operations with C#

Leverage the capabilities of C# with IronPDF for detailed tracking of printing tasks. Below is an example to demonstrate the modification of printer settings and tracking the print job:

```cs
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section5
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Access PrintDocument to modify settings
            var printDocument = pdf.GetPrintDocument();
            
            // Track printed pages
            var printedPages = 0;
            printDocument.PrintPage += (sender, args) => printedPages++;
            
            // Initiate the printing process
            printDocument.Print();
        }
    }
}
```
This tutorial successfully outlines steps to manage printing of PDF documents using C#, ranging from basic to advanced techniques, ideal for integrating into your .NET applications.