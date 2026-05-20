using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section4
    {
        public static void Run()
        {
            // Program.cs — compatible with .NET 8 and newer
            using IronPdf;
            
            // Sample HTML fragment (could also be read from a file, Razor view, or CMS)
            const string html = """
            <!DOCTYPE html>
            <html lang="en">
            <head>
              <meta charset="utf-8">
              <title>Quarterly Report</title>
              <style>
                 body { font-family:'Segoe UI', sans-serif; margin:1.2rem; }
                 header { margin-bottom:2rem; }
                 h1 { color:#3056d3; }
                 table { width:100%; border-collapse:collapse; margin-top:1rem; }
                 th,td { border:1px solid #ddd; padding:0.5rem; text-align:right; }
                 tr:nth-child(even){ background-color:#f8f9fa; }
              </style>
            </head>
            <body>
              <header><h1>Q2 Revenue Summary</h1></header>
              <table>
                <thead><tr><th>Product</th><th>Revenue ($)</th></tr></thead>
                <tbody>
                  <tr><td>IronPDF for .NET</td><td>1,200,000</td></tr>
                  <tr><td>IronOCR for .NET</td><td>890,000</td></tr>
                  <tr><td>IronXL for .NET</td><td>610,000</td></tr>
                </tbody>
              </table>
            </body>
            </html>
            """;
            
            // 1. Create a renderer once and reuse it across conversions
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    PaperSize    = PdfPaperSize.A4,                  // ISO-standard paper size
                    PaperOrientation = PdfPaperOrientation.Portrait,
                    CssMediaType = PdfCssMediaType.Screen,           // Respect on-screen CSS
                    RenderDelay  = 100,                              // Wait 100 ms for JS/animations
                    FallbackEncoding = "utf-8"                       // Handle non-ASCII correctly
                }
            };
            
            // 2. Render the HTML fragment
            using PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // 3. Persist to disk or return via ASP.NET Core FileStreamResult
            pdf.SaveAs("q2-report.pdf");
        }
    }
}