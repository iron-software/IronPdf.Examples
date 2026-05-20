using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section9
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