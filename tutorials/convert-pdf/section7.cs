using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section7
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