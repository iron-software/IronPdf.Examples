using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_CsharpPrintPdf Copy
{
    public static class Section2
    {
        public static void Run()
        {
            /**
            Specify Printer Name
            anchor-specify-printer-name
            **/
            using (var ChromePdfRenderer = new ChromePdfRenderer())
            
            {
            
            using (var pdfDocument =
            
            ChromePdfRenderer.RenderHtmlAsPdf(TestSources.HtmlTemplateBasicText()))
            
            {
            
            using (var printDocument = pdfDocument.GetPrintDocument())
            
            {
            
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            printDocument.Print();
            
            }
            
            }
            
            }
        }
    }
}