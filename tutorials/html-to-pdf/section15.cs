using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section15
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Convert HTML to PDF with security
            var pdf = renderer.RenderHtmlAsPdf("<h1>Confidential Report</h1>");
            
            // Configure security settings for PDF files
            pdf.SecuritySettings.UserPassword = "user123";     // Password to open PDF documents
            pdf.SecuritySettings.OwnerPassword = "owner456";   // Password to modify PDF files
            
            // Set granular permissions for PDF format
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserPrinting = PrintPermissions.LowQualityPrint;
            
            // Apply strong encryption to PDF documents
            pdf.SecuritySettings.EncryptionAlgorithm = PdfEncryptionAlgorithm.AES256;
            pdf.SaveAs("secure-document.pdf");
        }
    }
}