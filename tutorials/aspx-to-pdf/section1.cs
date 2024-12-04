using IronPdf;
namespace ironpdf.AspxToPdf
{
    public class Section1
    {
        public void Run()
        {
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.InBrowser);
        }
    }
}