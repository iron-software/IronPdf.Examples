using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.ApplyStamp(new IronPdf.Editing.TextStamper("Confidential"));
            pdf.SaveAs("edited_example.pdf");
        }
    }
}