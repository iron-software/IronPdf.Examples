using IronPdf;
using IronPdf.Rendering;

// Import PDF and enable TrackChanges
PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// ... various edits ...
pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.FormFillingAllowed);

PdfDocument pdfWithRevision = pdf.SaveAsRevision();

pdfWithRevision.SaveAs("annual_census_2.pdf");