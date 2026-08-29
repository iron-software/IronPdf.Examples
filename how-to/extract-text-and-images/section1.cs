using IronPdf;
namespace IronPdf.Examples.HowTo.ExtractTextAndImages
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.PdfDocument("sample.pdf");
            string text = pdf.ExtractAllText();
            var images = pdf.ExtractAllImages();
        }
    }
}