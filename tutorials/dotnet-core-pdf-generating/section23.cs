using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section23
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            
            // Apply watermark
            pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);
            pdf.SaveAs("Watermarked.pdf");
        }
    }
}