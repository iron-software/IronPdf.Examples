using IronPdf.Editing;
using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section5
    {
        public static void Run()
        {
            // AdvancedOptions.cs — .NET 8 compatible
            
            var renderer = new ChromePdfRenderer();
            
            // Configure everything in one place
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                // 1. Page layout
                PaperSize        = PdfPaperSize.A4,                     // ISO size
                PaperOrientation = PdfPaperOrientation.Portrait,
                MarginTop = 20, MarginBottom = 25, MarginLeft = 15, MarginRight = 15, // mm
            
                // 2. Timing & media
                CssMediaType     = PdfCssMediaType.Print,               // Respect @media print
                EnableJavaScript = true,
                RenderDelay      = 200,                                 // Wait 200 ms for animations
            
                // 3. Headers & footers (HTML gives full design freedom)
                HtmlHeader       = new HtmlHeaderFooter { HtmlFragment = "<header style='font:14px Segoe UI'>Invoice — {date}</header>" },
                HtmlFooter       = new HtmlHeaderFooter { HtmlFragment = "<footer style='text-align:right;font-size:10px'>Page {page} / {total-pages}</footer>" },
            };

            // Watermarks and security belong to the document, not to the
            // renderer options.
            
            // Render any HTML
            using PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Advanced Options Demo</h1>");
            
            // Digitally sign with a PFX certificate (optional). There is no
            // SignAndStamp; SignWithFile takes the certificate and its password.
            pdf.SignWithFile("./certs/company.pfx", "certificate-password");
            
            // Save
            pdf.SaveAs("advanced-options-demo.pdf");
        }
    }
}