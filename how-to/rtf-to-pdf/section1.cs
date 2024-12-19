using IronPdf;
namespace IronPdf.Examples.HowTo.RtfToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // RTF string
            string rtf = @"{\rtf1\ansi\deff0{\fonttbl{\f0 Arial;}}{\colortbl;\red0\green0\blue0;}\cf0This is some \b bold \b0 and \i italic \i0 text.}";
            
            // Render from RTF string
            PdfDocument pdf = renderer.RenderRtfStringAsPdf(rtf);
            
            // Save the PDF
            pdf.SaveAs("pdfFromRtfString.pdf");
        }
    }
}