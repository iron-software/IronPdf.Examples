using IronPdf;
namespace IronPdf.Examples.HowTo.AspxToPdf
{
    public static class Section5
    {
        public static void Run()
        {
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment);
        }
    }
}