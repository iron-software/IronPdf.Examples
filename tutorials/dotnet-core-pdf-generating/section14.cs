using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section14
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("1.pdf");
            PdfDocument pdf2 = PdfDocument.FromFile("2.pdf");
            pdf.AppendPdf(pdf2);
            pdf.SaveAs("appendedFile.pdf");
        }
    }
}