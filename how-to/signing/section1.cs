using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Digitally sign your PDF in one line!
            new IronPdf.Signing.PdfSignature("certificate.pfx", "password").SignPdfFile("input.pdf");
        }
    }
}