using IronPdf;
namespace IronPdf.Examples.HowTo.CustomPaperSize
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Render a PDF with a custom paper size!
            var renderer = new IronPdf.ChromePdfRenderer { RenderingOptions = { PaperSize = IronPdf.Rendering.PdfPaperSize.Custom } };
            renderer.RenderingOptions.SetCustomPaperSizeInInches(5, 7);
            renderer.RenderHtmlAsPdf("<h1>Custom size</h1>").SaveAs("custom‑size.pdf")
        }
    }
}