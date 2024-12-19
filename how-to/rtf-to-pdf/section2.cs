using IronPdf;
namespace IronPdf.Examples.HowTo.RtfToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render from RTF file
            PdfDocument pdf = renderer.RenderRtfFileAsPdf("sample.rtf");
            
            // Save the PDF
            pdf.SaveAs("pdfFromRtfFile.pdf");
        }
    }
}