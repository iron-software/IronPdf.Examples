using IronPdf;
namespace IronPdf.Examples.HowTo.DocxToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate Renderer
            DocxToPdfRenderer renderer = new DocxToPdfRenderer();
            
            // Render from DOCX file
            PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");
            
            // Save the PDF
            pdf.SaveAs("pdfFromDocx.pdf");
        }
    }
}