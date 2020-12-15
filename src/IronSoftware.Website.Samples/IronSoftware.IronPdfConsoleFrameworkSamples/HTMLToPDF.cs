using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class HTMLToPDF : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Create a PDF from an existing HTML using C#
            var Renderer = new IronPdf.HtmlToPdf();
            var HTMLStr = "<h1>Ironsoftware</h1>";
            var PDF = Renderer.RenderHtmlAsPdf(HTMLStr);
    
            Console.WriteLine($@"Output {OutputPath}\HTML.pdf");
            PDF.SaveAs($@"{OutputPath}\HTML.pdf");
        }
    }
}
