using IronPdf;

// Create a new PDF and print it
var renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Send the PDF to the default printer to print
// 300 DPI, no user dialog this time ... many overloads to this method
pdf.Print(300);

//For advanced printing we can also use PdfDocument.GetPrintDocument
//Remember to add an assembly reference to System.Drawing.dll or System.Drawing.Common via NuGet.

System.Drawing.Printing.PrintDocument printDocYouCanWorkWith = pdf.GetPrintDocument();
