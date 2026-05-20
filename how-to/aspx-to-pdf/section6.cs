using IronPdf;
namespace IronPdf.Examples.HowTo.AspxToPdf
{
    public static class Section6
    {
        public static void Run()
        {
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Invoice.pdf");
        }
    }
}