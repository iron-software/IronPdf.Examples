using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class HeadersFooters : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            // add a header to every page easily
            Renderer.PrintOptions.FirstPageNumber = 1; // use 2 if a coverpage  will be appended
            Renderer.PrintOptions.Header.DrawDividerLine = true;
            Renderer.PrintOptions.Header.CenterText = "{url}";
            Renderer.PrintOptions.Header.FontFamily = "Helvetica,Arial";
            Renderer.PrintOptions.Header.FontSize = 12;
            // add a footer too
            Renderer.PrintOptions.Footer.DrawDividerLine = true;
            Renderer.PrintOptions.Footer.FontFamily = "Arial";
            Renderer.PrintOptions.Footer.FontSize = 10;
            Renderer.PrintOptions.Footer.LeftText = "{date} {time}";
            Renderer.PrintOptions.Footer.RightText = "{page} of {total-pages}";
            // mergable fields are:
            // {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
            var HTMLStr = "<P>Ironsoftware</P>";
            for (int count = 0; count < 100; count++)
            {
                HTMLStr+= "<P>Ironsoftware</P>";
            }
            var PDF = Renderer.RenderHtmlAsPdf(HTMLStr);

            Console.WriteLine($@"Output {OutputPath}\HeadersFooters.pdf");
            PDF.SaveAs($@"{OutputPath}\HeadersFooters.pdf");
        }
    }
}
