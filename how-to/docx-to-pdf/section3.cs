using System.Linq;
using IronPdf;
namespace ironpdf.DocxToPdf
{
    public class Section3
    {
        public void Run()
        {
            var recipients = new List<RecipientsDataModel>()
                {
                    new RecipientsDataModel()
                    {
                        Date ="Saturday, October 15th, 2023",
                        Location="Iron Software Cafe, Chiang Mai",
                        Recipients_Name="Olivia Smith",
                        Contact_Us = "support@ironsoftware.com"
                    },
                    new RecipientsDataModel()
                    {
                        Date ="Saturday, October 15th, 2023",
                        Location="Iron Software Cafe, Chiang Mai",
                        Recipients_Name="Ethan Davis",
                        Contact_Us = "support@ironsoftware.com"
                    },
                };
            
            DocxToPdfRenderer docxToPdfRenderer = new DocxToPdfRenderer();
            
            // Apply render options
            DocxPdfRenderOptions options = new DocxPdfRenderOptions();
            
            // Configure the output PDF to be combined into a single PDF document
            options.MailMergePrintAllInOnePdfDocument = true;
            
            // Convert DOTX to PDF
            var pdfs = docxToPdfRenderer.RenderDocxMailMergeAsPdf<RecipientsDataModel>(
                 recipients,
                 "Party-invitation.dotx",
                 options);
            
            pdfs.First().SaveAs("mailMerge.pdf");
        }
    }
}