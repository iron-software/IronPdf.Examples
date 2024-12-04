using IronPdf;
namespace ironpdf.MdToPdf
{
    public class Section2
    {
        public void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render from markdown file
            PdfDocument pdf = renderer.RenderMarkdownFileAsPdf("sample.md");
            
            // Save the PDF
            pdf.SaveAs("pdfFromMarkdownFile.pdf");
        }
    }
}