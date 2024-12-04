using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section19
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            pdf.Sign(new PdfSignature("cert123.pfx", "password"));
            pdf.SaveAs("signed.pdf");
        }
    }
}