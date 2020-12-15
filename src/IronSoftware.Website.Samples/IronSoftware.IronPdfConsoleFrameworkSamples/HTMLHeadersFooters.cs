using IronPdf;
using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class HTMLHeadersFooters : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            // Build a footer using html to style the text
            // mergable fields are:
            // {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
            Renderer.PrintOptions.Footer = new HtmlHeaderFooter()
            {
                Height = 15,
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true
            };
            // Build a header using an image asset
            // Note the use of BaseUrl to set a relative path to the assets
            Renderer.PrintOptions.Header = new HtmlHeaderFooter()
            {
                Height = 20,
                HtmlFragment = "<img src='logo.png'>",
                BaseUrl = new Uri(@"c:\Inputs\images\").AbsoluteUri
            };

            var HTMLStr = "<h1>Ironsoftware</h1>";
            var PDF = Renderer.RenderHtmlAsPdf(HTMLStr);
            PDF.SaveAs($@"{OutputPath}\HTMLHeadersFooters.pdf");
        }
    }
}
