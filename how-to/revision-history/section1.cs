using IronPdf;
namespace IronPdf.Examples.HowTo.RevisionHistory
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Easily Save PDF Revisions
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.SaveAsRevision("revision1.pdf");
        }
    }
}