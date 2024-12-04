using IronPdf;
namespace ironpdf.ExtractTextAndImages
{
    public class Section3
    {
        public void Run()
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