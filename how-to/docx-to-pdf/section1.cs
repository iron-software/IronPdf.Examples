using IronPdf;
namespace IronPdf.Examples.HowTo.DocxToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.DocxToPdfRenderer()
                .RenderDocxAsPdf("document.docx")
                .SaveAs("output.pdf");
        }
    }
}