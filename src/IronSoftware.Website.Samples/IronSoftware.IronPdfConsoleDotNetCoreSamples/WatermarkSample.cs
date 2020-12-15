using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class WatermarkSample : IExecuteApp
    {
        public string OutputPath { get ; set; }

        public void Run()
        {          
            // Stamps a watermark onto a new or existing PDF
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            var pdf = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            pdf.WatermarkAllPages("<h2 style='color:red'>SAMPLE</h2>", PdfDocument.WaterMarkLocation.MiddleCenter, 50, -45, "https://www.nuget.org/packages/IronPdf");
            pdf.SaveAs($@"{OutputPath}\Watermarked.pdf");           
        }
    }
}
