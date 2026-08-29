using IronPdf;
namespace IronPdf.Examples.HowTo.AddCopyDeletePagesPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("/input/path.pdf")
                .AppendPdf(IronPdf.PdfDocument.FromFile("/additional/path.pdf"))
                .SaveAs("/output/path.pdf");
        }
    }
}