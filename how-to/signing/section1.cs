using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section1
    {
        public static void Run()
        {
            // A signature is applied by the document, not by the signature.
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.Sign(new IronPdf.Signing.PdfSignature("certificate.pfx", "password"));
            pdf.SaveAs("signed.pdf");
        }
    }
}