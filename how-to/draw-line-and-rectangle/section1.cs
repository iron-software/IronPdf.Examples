using IronPdf;
namespace IronPdf.Examples.HowTo.DrawLineAndRectangle
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Configure the required parameters
            int pageIndex = 0;
            var start = new IronSoftware.Drawing.PointF(200,150);
            var end = new IronSoftware.Drawing.PointF(1000,150);
            int width = 10;
            var color = new IronSoftware.Drawing.Color("#000000");
            
            // Draw line on PDF
            pdf.DrawLine(pageIndex, start, end, width, color);
            
            pdf.SaveAs("drawLine.pdf");
        }
    }
}