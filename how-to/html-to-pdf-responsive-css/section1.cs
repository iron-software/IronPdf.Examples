using IronPdf;
namespace IronPdf.Examples.HowTo.HtmlToPdfResponsiveCss
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert responsive web HTML to PDF in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print } }
                .RenderUrlAsPdf("https://example.com")
                .SaveAs("responsive.pdf");
        }
    }
}