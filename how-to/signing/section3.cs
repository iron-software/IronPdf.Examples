using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section3
    {
        public static void Run()
        {
            // Load an existing PDF document to be signed.
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            // Create a PdfSignature object directly from the certificate file and password.
            var signature = new PdfSignature("IronSoftware.pfx", "123456");
            
            // Add detailed metadata to the signature for a comprehensive audit trail.
            signature.SignatureDate = DateTime.Now;
            signature.SigningContact = "legal@ironsoftware.com";
            signature.SigningLocation = "Chicago, USA";
            signature.SigningReason = "Contractual Agreement";
            
            // Add a secure timestamp from a trusted Time Stamp Authority (TSA).
            // This provides cryptographic proof of the signing time.
            signature.TimeStampUrl = new Uri("[http://timestamp.digicert.com](http://timestamp.digicert.com)");
            signature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
            
            // Apply a visual appearance to the signature. (More on this in the next section)
            signature.SignatureImage = new PdfSignatureImage("assets/visual-signature.png", 0, new Rectangle(350, 750, 200, 100));
            
            // Sign the PDF document with the configured signature object.
            pdf.Sign(signature);
            
            // Save the final, signed PDF document.
            pdf.SaveAs("DetailedSignature.pdf");
        }
    }
}