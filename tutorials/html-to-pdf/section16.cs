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
            // PdfSignature carries the certificate; the contact, location,
            // reason and signer name it once documented are not on the type.
            var signature = new PdfSignature("certificate.pfx", "password");
            
            // Apply signature to PDF documents
            pdf.Sign(signature);
            pdf.SaveAs("signed-contract.pdf");
        }
    }
}