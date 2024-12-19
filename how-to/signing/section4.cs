using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section4
    {
        public static void Run()
        {
            // Import PDF and enable TrackChanges
            PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
            // ... various edits ...
            pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);
            
            PdfDocument pdfWithRevision = pdf.SaveAsRevision();
            
            pdfWithRevision.SaveAs("annual_census_2.pdf");
        }
    }
}