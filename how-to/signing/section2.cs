using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>foo</h1>");
            
            pdf.SaveAs("signed.pdf");
            
            // Create PdfSignature object
            var sig = new PdfSignature("IronSoftware.pfx", "123456");
            
            // Add granular information
            sig.SignatureDate = new DateTime(2000, 12, 02);
            sig.SigningContact = "IronSoftware";
            sig.SigningLocation = "Chicago";
            sig.SigningReason = "How to guide";
            sig.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
            sig.TimeStampUrl = "http://timestamp.digicert.com";
            sig.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));
            
            // Sign and save PDF document
            sig.SignPdfFile("signed.pdf");
        }
    }
}