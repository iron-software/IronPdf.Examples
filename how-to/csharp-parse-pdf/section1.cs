using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpParsePdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Select the desired PDF File
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Extract all text from an pdf
            string allText = pdf.ExtractAllText();
            
            // Extract all text from page 1
            string page1Text = pdf.ExtractTextFromPage(0);
        }
    }
}