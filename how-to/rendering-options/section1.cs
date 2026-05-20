using IronPdf;
namespace IronPdf.Examples.HowTo.RenderingOptions
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Customize PDF output with rich RenderingOptions in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { PrintHtmlBackgrounds = true, MarginTop = 0, MarginBottom = 0, CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print, HtmlHeader = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<div>My Header</div>" }, Language = "en-US", Timeout = 120000 } }
                .RenderHtmlStringAsPdf("<h1>Hello Options</h1>")
                .SaveAs("renderingOptions.pdf");
        }
    }
}