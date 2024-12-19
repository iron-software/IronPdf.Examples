using IronPdf;
namespace IronPdf.Examples.HowTo.ExtractTextAndImages
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Extract images
            var images = pdf.ExtractAllImages();
            
            for(int i = 0; i < images.Count; i++)
            {
                // Export the extracted images
                images[i].SaveAs($"images/image{i}.png");
            }
        }
    }
}