using IronPdf.Signing;
using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section7
    {
        public static void Run()
        {
            new IronPdf.Signing.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");
        }
    }
}