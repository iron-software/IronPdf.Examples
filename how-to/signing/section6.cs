using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section6
    {
        public static void Run()
        {
            // Load a PDF with a complex signature history.
            var pdf = PdfDocument.FromFile("multi_signed_report.pdf");
            
            // Verify all signatures across all revisions.
            bool allSignaturesValid = pdf.VerifySignatures();
            Console.WriteLine($"All signatures are valid: {allSignaturesValid}");
            
            // Roll back to the first revision (index 0).
            if (pdf.RevisionCount &gt; 1)
            {
                PdfDocument firstRevision = pdf.GetRevision(0);
                firstRevision.SaveAs("report_first_revision.pdf");
            }
            
            // Create a completely unsigned version of the document.
            pdf.RemoveSignatures();
            pdf.SaveAs("report_unsigned.pdf");
        }
    }
}