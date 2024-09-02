using IronPdf;
using System.Threading.Tasks;

// Create a new PDF and print it
ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Print PDF from default printer
await pdf.Print();

// For advanced silent real-world printing options, use PdfDocument.GetPrintDocument
// Remember to add an assembly reference to System.Drawing.dll
System.Drawing.Printing.PrintDocument PrintDocYouCanWorkWith = pdf.GetPrintDocument();