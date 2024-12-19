using IronPdf;
namespace IronPdf.Examples.HowTo.MdToPdf
{
    public static class Section2
    {
        public static void Run()
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