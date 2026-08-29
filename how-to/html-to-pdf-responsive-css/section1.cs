using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlToPdfResponsiveCss
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print } }
                .RenderUrlAsPdf("https://example.com")
                .SaveAs("responsive.pdf");
        }
    }
}