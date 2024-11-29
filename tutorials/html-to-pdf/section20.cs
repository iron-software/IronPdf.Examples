using IronPdf.Editing;
using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section20
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            // Watermarks all pages with red "SAMPLE" text at a custom location.
            // Also adding a link to the watermark on-click
            pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 0, VerticalAlignment.Middle, HorizontalAlignment.Center);
            pdf.SaveAs(@"C:\Path\To\Watermarked.pdf");
        }
    }
}