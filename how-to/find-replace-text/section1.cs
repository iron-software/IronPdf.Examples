using IronPdf;
namespace IronPdf.Examples.HowTo.FindReplaceText
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Effortless PDF Text Replacement
            IronPdf.PdfDocument.FromFile("example.pdf")
                .ReplaceTextOnAllPages("old text", "new text")
                .SaveAs("updated.pdf");
        }
    }
}