using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section16
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("basic.pdf");
            
            pdf.Pages[0].Transform(50, 50, 0.8, 0.8);
            
            pdf.SaveAs("transformPage.pdf");
        }
    }
}