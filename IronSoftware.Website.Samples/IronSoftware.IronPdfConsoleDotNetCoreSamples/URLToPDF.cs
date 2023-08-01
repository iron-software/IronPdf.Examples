using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class URLToPDF : IExecuteApp
    {
        public string OutputPath { get; set; }
        public void Run()
        {
            //Render Url to Pdf
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
         
            Console.WriteLine($@"Output {OutputPath}\url.pdf");
            Renderer.RenderUrlAsPdf("https://ironpdf.com/").SaveAs($@"{OutputPath}\url.pdf");
        }
    }
}
