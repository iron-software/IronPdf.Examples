using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.AddRemoveAttachments
{
    public static class Section3
    {
        public static void Run()
        {
            // Open existing PDF
            PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");
            
            // Iterate through all attachments
            foreach (var attachment in pdf.Attachments)
            {
                if (attachment.Name.Contains("Example"))
                {
                    // Save byte to file
                    File.WriteAllBytes($"{attachment.Name}.doc", attachment.Data);
                }
            }
        }
    }
}