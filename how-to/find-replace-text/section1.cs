using IronPdf;
namespace IronPdf.Examples.HowTo.FindReplaceText
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");

            // ReplaceTextOnAllPages returns void, so it cannot be chained.
            pdf.ReplaceTextOnAllPages("old text", "new text");
            pdf.SaveAs("updated.pdf");
        }
    }
}