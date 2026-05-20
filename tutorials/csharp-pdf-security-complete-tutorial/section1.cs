using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpPdfSecurityCompleteTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Secure Your PDFs Easily with IronPDF
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.SignWithFile("certificate.pfx", "password");
            pdf.SaveAs("secured.pdf");
        }
    }
}