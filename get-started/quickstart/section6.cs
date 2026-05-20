using IronPdf;
namespace IronPdf.Examples.GettingStarted.Quickstart
{
    public static class Section6
    {
        public static void Run()
        {
            DocxToPdfRenderer renderer = new DocxToPdfRenderer();
            PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");
            pdf.SaveAs("pdfFromDocx.pdf");
        }
    }
}