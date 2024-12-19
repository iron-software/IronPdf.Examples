using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section5
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("report.pdf");
            
            int versions = pdf.RevisionCount; // total revisions
            
            PdfDocument rolledBackPdf = pdf.GetRevision(2);
            rolledBackPdf.SaveAs("report-draft.pdf");
        }
    }
}