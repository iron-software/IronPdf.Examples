using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpCreatePdfCompleteTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.PdfDocument(500, 500).SaveAs("output.pdf");
        }
    }
}