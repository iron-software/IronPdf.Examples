using IronPdf;
namespace IronPdf.Examples.HowTo.RevisionHistory
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.SaveAsRevision("revision1.pdf");
        }
    }
}