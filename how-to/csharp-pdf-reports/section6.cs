using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section6
    {
        public static void Run()
        {
            var AspxToPdfOptions = new IronPdf.ChromePdfRenderOptions()
            {
              EnableJavaScript = false,
              //.. many more options available
            };
            
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Report.pdf", AspxToPdfOptions);
        }
    }
}