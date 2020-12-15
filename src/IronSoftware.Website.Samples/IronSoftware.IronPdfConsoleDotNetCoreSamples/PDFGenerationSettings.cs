using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;
using System.IO;
using System.Text;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class PDFGenerationSettings : IExecuteApp
    {
        public string OutputPath { get ; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.SetCustomPaperSizeInInches(12.5, 20);
            Renderer.PrintOptions.PrintHtmlBackgrounds = true;
            Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Portrait;
            Renderer.PrintOptions.Title = "My PDF Document Name";
            Renderer.PrintOptions.EnableJavaScript = true;
            Renderer.PrintOptions.RenderDelay = 50; //ms
            Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Screen;
            Renderer.PrintOptions.DPI = 300;
            Renderer.PrintOptions.FitToPaperWidth = true;
            Renderer.PrintOptions.JpegQuality = 80;
            Renderer.PrintOptions.GrayScale = false;
            Renderer.PrintOptions.FitToPaperWidth = true;
            Renderer.PrintOptions.InputEncoding = Encoding.UTF8;
            Renderer.PrintOptions.Zoom = 100;
            Renderer.PrintOptions.CreatePdfFormsFromHtml = true;
            Renderer.PrintOptions.MarginTop = 40;  //millimeters
            Renderer.PrintOptions.MarginLeft = 20;  //millimeters
            Renderer.PrintOptions.MarginRight = 20;  //millimeters
            Renderer.PrintOptions.MarginBottom = 40;  //millimeters
            Renderer.PrintOptions.FirstPageNumber = 1; //use 2 if a coverpage  will be appended
            var PDF = Renderer.RenderHTMLFileAsPdf($@"{Directory.GetCurrentDirectory()}\Inputs\InvoiceTemplate.html");
            Console.WriteLine($@"Output {OutputPath}\PDFGenerationSettings.pdf");
            PDF.SaveAs($@"{OutputPath}\PDFGenerationSettings.pdf");
        }
    }
}
