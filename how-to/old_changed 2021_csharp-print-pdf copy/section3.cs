using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_CsharpPrintPdf Copy
{
    public static class Section3
    {
        public static void Run()
        {
            /**
            Set Printer Resolution
            anchor-set-printer-resolution
            **/
            using (var ChromePdfRenderer = new ChromePdfRenderer())
            
            {
            
            using (var pdfDocument =
            
            ChromePdfRenderer.RenderHtmlAsPdf(TestSources.HtmlTemplateBasicText()))
            
            {
            
            using (var printDocument = pdfDocument.GetPrintDocument())
            
            {
            
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            
            {
            
            **Kind = PrinterResolutionKind.Custom,**
            
            **X = 1200,**
            
            **Y = 1200**
            
            **};**
            
            printDocument.Print();
            
            }
            
            }
            
            }
        }
    }
}