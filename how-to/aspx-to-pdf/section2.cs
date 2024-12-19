using IronPdf;
namespace IronPdf.Examples.HowTo.AspxToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            var AspxToPdfOptions = new IronPdf.ChromePdfRenderOptions()
            {
                EnableJavaScript = false,
                //.. many more options available
            };
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Invoice.pdf", AspxToPdfOptions);
        }
    }
}