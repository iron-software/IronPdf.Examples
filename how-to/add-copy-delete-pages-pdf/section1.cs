using IronPdf;
namespace IronPdf.Examples.HowTo.AddCopyDeletePagesPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Effortlessly Manage PDF Pages
            IronPdf.PdfDocument.FromFile("/input/path.pdf")
                .AppendPdf(IronPdf.PdfDocument.FromFile("/additional/path.pdf"))
                .SaveAs("/output/path.pdf");
        }
    }
}