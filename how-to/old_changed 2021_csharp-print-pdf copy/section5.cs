using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_CsharpPrintPdf Copy
{
    public static class Section5
    {
        public static void Run()
        {
            /**
            Tracing Printing Processes
            anchor-tracing-printing-processes-using-c-num
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
            
            Kind = PrinterResolutionKind.Custom,
            
            X = 1200,
            
            Y = 1200
            
            };
            
            **var printedPages = 0;**
            
            **printDocument.PrintPage += (sender, args) => printedPages++;**
            
            **printDocument.Print();**
            
            }
            
            }
            
            }
        }
    }
}