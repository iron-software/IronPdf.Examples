using IronPdf.Signing;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section16
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Generate PDF from HTML page
            var pdf = renderer.RenderHtmlAsPdf("<h1>Contract Agreement</h1>");
            
            // Create digital signature with certificate for PDF files
            var signature = new PdfSignature("certificate.pfx", "password")
            {
                SigningContact = "legal@company.com",
                SigningLocation = "New York, NY",
                SigningReason = "Contract Approval",
                SignerName = "Authorized Signer"  // New property in v2025.8.8 for enhanced signature details
            };
            
            // Apply signature to PDF documents
            pdf.Sign(signature);
            pdf.SaveAs("signed-contract.pdf");
        }
    }
}