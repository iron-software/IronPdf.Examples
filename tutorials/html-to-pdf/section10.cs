using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section10
    {
        public static void Run()
        {
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
            {
                HtmlFragment = "<div style='text-align:right'><em style='color:pink'>page {page} of {total-pages}</em></div>"
            };
        }
    }
}