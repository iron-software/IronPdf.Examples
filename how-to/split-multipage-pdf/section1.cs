using IronPdf;
namespace IronPdf.Examples.HowTo.SplitMultipagePdf
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.PdfDocument("multipage.pdf");
            for (int i = 0; i < pdf.PageCount; i++) {
              var singlePagePdf = pdf.CopyPage(i);
              singlePagePdf.SaveAs($"page_{i + 1}.pdf");
            }
        }
    }
}