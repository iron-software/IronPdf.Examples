namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
    using System;
    using System.IO;
    public class HTMLFileToPDF : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Create a PDF from an existing HTML using C#
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHTMLFileAsPdf($@"{Directory.GetCurrentDirectory()}\Inputs\InvoiceTemplate.html");
           
            Console.WriteLine($@"Output {OutputPath}\Invoice.pdf");
            PDF.SaveAs($@"{OutputPath}\Invoice.pdf");
        }
    }
}
