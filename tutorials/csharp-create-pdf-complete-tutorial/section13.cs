using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpCreatePdfCompleteTutorial
{
    public static class Section13
    {
        public static void Run()
        {
            // Open PDF File
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Export as PDF/UA compliance PDF
            pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
        }
    }
}