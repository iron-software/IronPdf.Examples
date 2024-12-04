using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.CsharpPdfReports
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Add a header to very page easily
            renderer.RenderingOptions.FirstPageNumber = 1;
            renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
            renderer.RenderingOptions.TextHeader.CenterText = "{url}";
            renderer.RenderingOptions.TextHeader.Font = FontTypes.Arial;
            renderer.RenderingOptions.TextHeader.FontSize = 12;
            
            // Add a footer too
            renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
            renderer.RenderingOptions.TextFooter.Font = FontTypes.Arial;
            renderer.RenderingOptions.TextFooter.FontSize = 10;
            renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
            renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
            
            renderer.RenderHtmlFileAsPdf(@"c:\my\exported\report.html").SaveAs("report.pdf");
        }
    }
}