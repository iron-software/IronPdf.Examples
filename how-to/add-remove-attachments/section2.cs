using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.AddRemoveAttachments
{
    public static class Section2
    {
        public static void Run()
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