using IronPdf;
namespace IronPdf.Examples.HowTo.MdToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
                .RenderMarkdownStringAsPdf("*This* is some **markdown** _text_!")
                .SaveAs("mdToPdf.pdf");
        }
    }
}