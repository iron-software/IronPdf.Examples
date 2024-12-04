using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section24
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<div>test text </div>");
            
            // Configure HTML stamper
            HtmlStamper backgroundStamp = new HtmlStamper()
            {
                Html = "<h2 style='color:red'>copyright 2018 ironpdf.com",
                MaxWidth = new Length(20),
                MaxHeight = new Length(20),
                Opacity = 50,
                Rotation = -45,
                IsStampBehindContent = true,
                VerticalAlignment = VerticalAlignment.Middle
            };
            
            pdf.ApplyStamp(backgroundStamp);
            pdf.SaveAs("stamped.pdf");
        }
    }
}