using IronPdf;
namespace IronPdf.Examples.HowTo.AspxToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.InBrowser);
        }
    }
}