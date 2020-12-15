using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;
using System.IO;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class ResponsiveHTMLToPDF : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            //Choose screen or print CSS media
            Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;
            //Set the width of the responsive virtual browser window in pixels
            Renderer.PrintOptions.ViewPortWidth = 1280;
            // Render an HTML document or snippet as a string
            var PDF= Renderer.RenderHTMLFileAsPdf($@"{Directory.GetCurrentDirectory()}\Inputs\InvoiceTemplate.html");
            Console.WriteLine($@"Output {OutputPath}\ResponsiveHTMLToPDF.pdf");
            PDF.SaveAs($@"{OutputPath}\ResponsiveHTMLToPDF.pdf");
        }
    }
}
