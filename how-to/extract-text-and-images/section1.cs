using IronPdf;
namespace IronPdf.Examples.HowTo.ExtractTextAndImages
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Extract PDF Content in Seconds
            var pdf = new IronPdf.PdfDocument("sample.pdf");
            string text = pdf.ExtractAllText();
            var images = pdf.ExtractAllImages();
        }
    }
}