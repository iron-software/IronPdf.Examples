using IronPdf;
namespace IronPdf.Examples.HowTo.DocxToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert DOCX to PDF in One line of Code!
            new IronPdf.DocxToPdfRenderer()
                .RenderDocxAsPdf("document.docx")
                .SaveAs("output.pdf");
        }
    }
}