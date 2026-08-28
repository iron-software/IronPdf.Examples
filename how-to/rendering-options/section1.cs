using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.RenderingOptions
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { PrintHtmlBackgrounds = true, MarginTop = 0, MarginBottom = 0, CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print, HtmlHeader = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<div>My Header</div>" }, Timeout = 120000 } }
                .RenderHtmlAsPdf("<h1>Hello Options</h1>")
                .SaveAs("renderingOptions.pdf");
        }
    }
}