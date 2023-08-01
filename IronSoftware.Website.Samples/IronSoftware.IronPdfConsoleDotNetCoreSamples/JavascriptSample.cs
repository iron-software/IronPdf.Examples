using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System.IO;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class JavascriptSample : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            var Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.EnableJavaScript = true;
            Renderer.PrintOptions.RenderDelay = 500;
            Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print;
            var PDF = Renderer.RenderHTMLFileAsPdf($@"{Directory.GetCurrentDirectory()}\Inputs\D3jsSample.html");
            PDF.SaveAs($@"{OutputPath}\HTMLD3Chart.pdf");
        }
    }
}
