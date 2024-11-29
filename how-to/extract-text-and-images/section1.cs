using System.IO;
using IronPdf;
namespace ironpdf.ExtractTextAndImages
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Extract text
            string text = pdf.ExtractAllText();
            
            // Export the extracted text to a text file
            File.WriteAllText("extractedText.txt", text);
        }
    }
}