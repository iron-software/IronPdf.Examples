using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section2
    {
        public static void Run()
        {
            // Program.cs — .NET 8 LTS
            using IronPdf;
            
            var renderer = new ChromePdfRenderer();
            
            // Render a live website to PDF
            using PdfDocument pdf = renderer.RenderUrlAsPdf("https://example.com");
            
            // Persist to disk
            pdf.SaveAs("website-snapshot.pdf");
        }
    }
}