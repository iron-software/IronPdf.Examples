using IronPdf.Signing;
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section7
    {
        public void Run()
        {
            new IronPdf.Signing.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");
        }
    }
}