using System.Linq;
using IronPdf;
namespace ironpdf.AddRemoveAttachments
{
    public class Section2
    {
        public void Run()
        {
            // Open existing PDF
            PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");
            
            // Add attachment to the PDF
            PdfAttachmentCollection retrieveAttachments = pdf.Attachments;
            
            // Remove attachment from PDF
            pdf.Attachments.RemoveAttachment(retrieveAttachments.First());
            
            pdf.SaveAs("removeAttachment.pdf");
        }
    }
}