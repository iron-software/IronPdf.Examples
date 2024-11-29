using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section10
    {
        public void Run()
        {
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
            {
                HtmlFragment = "<div style='text-align:right'><em style='color:pink'>page {page} of {total-pages}</em></div>"
            };
        }
    }
}