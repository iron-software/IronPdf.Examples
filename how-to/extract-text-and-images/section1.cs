using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.ExtractTextAndImages
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Extract text
            string text = pdf.ExtractAllText();
            
            // Export the extracted text to a text file
            File.WriteAllText("extractedText.txt", text);
        }
    }
}