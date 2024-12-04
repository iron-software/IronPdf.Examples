using IronPdf;
namespace ironpdf.DocxToPdf
{
    public class Section1
    {
        public void Run()
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