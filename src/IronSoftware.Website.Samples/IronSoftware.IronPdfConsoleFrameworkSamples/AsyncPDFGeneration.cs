using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System;
using System.Threading.Tasks;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class AsyncPDFGeneration : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            Task.Run(async () => await AsyncMethodAsync());
        }
        async Task AsyncMethodAsync()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf

            var Renderer = new IronPdf.HtmlToPdf();
            // All IronPdf Rendering methods have Async equivalents
            var doc = await Renderer.RenderHtmlAsPdfAsync("<h1>Html with CSS and Images</h1>");
            doc.SaveAs($@"{OutputPath}\AsyncPDF.pdf");
        }
    }
}
