using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section5
    {
        public static void Run()
        {
            // AdvancedOptions.cs — .NET 8 compatible
            using IronPdf;
            
            var renderer = new ChromePdfRenderer();
            
            // Configure everything in one place
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                // 1. Page layout
                PaperSize        = PdfPaperSize.A4,                     // ISO size
                PaperOrientation = PdfPaperOrientation.Portrait,
                Margins          = new PdfMargins { Top = 20, Bottom = 25, Left = 15, Right = 15 }, // mm
            
                // 2. Timing & media
                CssMediaType     = PdfCssMediaType.Print,               // Respect @media print
                EnableJavaScript = true,
                RenderDelay      = 200,                                 // Wait 200 ms for animations
            
                // 3. Headers & footers (HTML gives full design freedom)
                HtmlHeader       = "<header style='font:14px Segoe UI'>Invoice — {{date}}</header>",
                HtmlFooter       = "<footer style='text-align:right;font-size:10px'>Page {{page}} / {{total-pages}}</footer>",
            
                // 4. Watermark
                Watermark        = new HtmlStamp
                {
                    HtmlTemplate = "<div style='font-size:50px;color:#cccccc;opacity:0.3;'>CONFIDENTIAL</div>",
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center
                },
            
                // 5. Security
                SecurityOptions = new PdfSecurityOptions
                {
                    OwnerPassword = "StrongOwnerPwd!",
                    UserPassword  = "ReadOnly",
                    AllowUserPrinting = false,
                    AllowUserCopyPasteContent = false
                }
            };
            
            // Render any HTML
            using PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Advanced Options Demo</h1>");
            
            // Digitally sign with a PFX certificate (optional)
            pdf.SignAndStamp("./certs/company.pfx", "Iron Software", "Bangkok", "Approval");
            
            // Save
            pdf.SaveAs("advanced-options-demo.pdf");
        }
    }
}