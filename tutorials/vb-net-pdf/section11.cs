using IronPdf;
namespace ironpdf.VbNetPdf
{
    public class Section11
    {
        public void Run()
        {
            pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
        }
    }
}