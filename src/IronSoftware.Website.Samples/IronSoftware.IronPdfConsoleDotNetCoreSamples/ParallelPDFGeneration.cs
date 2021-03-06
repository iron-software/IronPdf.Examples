using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class ParallelPDFGeneration : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            var ids = Enumerable.Range(1, 2);
            var htmlCode = $"<h1>Ironsoftware</h1><p>{DateTime.Now.ToLongTimeString()}<p>";
            Parallel.ForEach(
                ids,
                async i =>
                {
                    var pdf = await RenderPdfAsync(htmlCode, OutputPath);
                });
        }
        public static async Task<IronPdf.PdfDocument> RenderPdfAsync(string html, string OutputPath)
        {
            var renderer = new IronPdf.HtmlToPdf();

            var pdf = await renderer.RenderHtmlAsPdfAsync(html);
            pdf.SaveAs($@"{OutputPath}\{Guid.NewGuid()}AsyncPDF.pdf");
            Console.WriteLine("PDF converted");
            return pdf;
        }
    }
}
