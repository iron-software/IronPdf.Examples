using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section5
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