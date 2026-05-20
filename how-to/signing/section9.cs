using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section9
    {
        public static void Run()
        {
            // Import the Signed PDF report
            var pdf = PdfDocument.FromFile("multi_signed_report.pdf");
            
            // Using GetVerifiedSignatures() obtain a list of `VerifiedSignature` objects from the PDF
            pdf.GetVerifiedSignatures().ForEach(signature =>
            {
                // Print out the SignerName of each `VerifiedSignature` object
                Console.WriteLine($"SignatureName: {signature.SignerName}");
            });
        }
    }
}