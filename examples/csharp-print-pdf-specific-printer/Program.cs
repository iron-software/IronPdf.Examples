using IronPdf;

var renderer = new ChromePdfRenderer();
using (var pdfDocument = renderer.RenderHtmlAsPdf("<h1 style=\"color:Violet\">Hello World!</h1>"))
{
    using (var printDocument = pdfDocument.GetPrintDocument())
    {
        printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
        printDocument.Print();
    }
}
