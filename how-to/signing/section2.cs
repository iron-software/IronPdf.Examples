using IronPdf.Signing;
using System.Security.Cryptography.X509Certificates;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section2
    {
        public static void Run()
        {
            // Create a new PDF from an HTML string for demonstration.
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1>Signed Document</h1><p>This document has been digitally signed.</p>");
            
            // Load the certificate from a .pfx file with its password.
            // The X509KeyStorageFlags.Exportable flag is crucial for allowing the private key to be used in the signing process.
            var cert = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);
            
            // Create a PdfSignature object using the loaded certificate.
            var signature = new PdfSignature(cert);
            
            // Apply the signature to the PDF document.
            pdf.Sign(signature);
            
            // Save the securely signed PDF document.
            pdf.SaveAs("Signed.pdf");
        }
    }
}