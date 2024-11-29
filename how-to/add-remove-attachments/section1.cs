using System.IO;
using IronPdf;
namespace ironpdf.AddRemoveAttachments
{
    public class Section1
    {
        public void Run()
        {
            // Import attachment file
            byte[] fileData = File.ReadAllBytes(@"path/to/file");
            
            // Open existing PDF
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Add attachment to the PDF
            pdf.Attachments.AddAttachment("Example", fileData);
            
            pdf.SaveAs("addAttachment.pdf");
        }
    }
}