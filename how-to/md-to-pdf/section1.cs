using IronPdf;
namespace IronPdf.Examples.HowTo.MdToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Markdown to PDF in one line of code: 
            new IronPdf.ChromePdfRender
                .RenderMarkdownStringAsPdf("*This* is some **markdown** _text_!")
                .SaveAs("mdToPdf.pdf");
        }
    }
}