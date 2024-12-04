using IronPdf;
namespace ironpdf.AspxToPdf
{
    public class Section3
    {
        public void Run()
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