using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System.IO;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class BackgroundsForegrounds : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf

            // With IronPDF, we can easily merge 2 PDF files using one as a backgorund or foreground
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            var pdf = Renderer.RenderUrlAsPdf("https://ironpdf.com/");
            pdf.AddBackgroundPdf($@"{Directory.GetCurrentDirectory()}\Inputs\MyBackground.pdf");
            pdf.AddForegroundOverlayPdfToPage(0, $@"{Directory.GetCurrentDirectory()}\Inputs\MyForeground.pdf", 0);
            pdf.SaveAs($@"{OutputPath}\BackgroundsForegrounds.pdf");
        }
    }
}
