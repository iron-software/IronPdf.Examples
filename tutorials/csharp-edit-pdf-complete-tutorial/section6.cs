using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section6
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