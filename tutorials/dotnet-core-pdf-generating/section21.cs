using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section21
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            pdf.ExtractAllText(); // Extract all text in the pdf
            pdf.ExtractTextFromPage(0); // Read text from specific page
            
            // Extract all images in the pdf
            var AllImages = pdf.ExtractAllImages();
            
            // Extract images from specific page
            var ImagesOfAPage = pdf.ExtractImagesFromPage(0);
        }
    }
}