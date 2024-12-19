using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section12
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            pdf.Sign(new PdfSignature("cert123.pfx", "password"));
            pdf.SaveAs("signed.pdf");
        }
    }
}