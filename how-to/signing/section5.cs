using IronPdf.Signing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section5
    {
        public static void Run()
        {
            // Load a PDF file with change tracking enabled.
            var pdf = PdfDocument.FromFile("annual_census.pdf", ChangeTrackingModes.EnableChangeTracking);
            
            // Placeholder for edits: You might add text, fill forms, or add annotations here.
            // For example: pdf.Annotations.Add(new TextAnnotation(...));
            
            // Sign the current state of the document using SignWithFile for convenience.
            // We set permissions to allow further signatures and form filling.
            pdf.SignWithFile(
                "assets/IronSignature.p12", 
                "password", 
                SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);
            
            // Save the current state as a distinct revision within the PDF's history.
            PdfDocument pdfWithRevision = pdf.SaveAsRevision();
            
            // Save the final PDF with its full revision history to a new file.
            pdfWithRevision.SaveAs("annual_census_signed.pdf");
        }
    }
}