using IronPdf;
namespace ironpdf.Signing
{
    public class Section5
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("report.pdf");
            
            int versions = pdf.RevisionCount; // total revisions
            
            PdfDocument rolledBackPdf = pdf.GetRevision(2);
            rolledBackPdf.SaveAs("report-draft.pdf");
        }
    }
}