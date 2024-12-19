using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section2
    {
        public static void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            // Copy pages 5 to 7 and save them as a new document.
            pdf.CopyPages(4, 6).SaveAs("report_highlight.pdf");
        }
    }
}