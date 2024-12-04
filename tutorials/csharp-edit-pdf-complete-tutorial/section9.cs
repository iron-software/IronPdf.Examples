using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section9
    {
        public void Run()
        {
            var Renderer = new ChromePdfRenderer();
            var myPdf = Renderer.RenderHtmlFileAsPdf("my-content.html");
            
            // Here we can add an attachment with a name and byte[]
            var attachment1 = myPdf.Attachments.AddAttachment("attachment_1", example_attachment);
            
            // And here is an example of removing an attachment
            myPdf.Attachments.RemoveAttachment(attachment1);
            
            myPdf.SaveAs("my-content.pdf");
        }
    }
}