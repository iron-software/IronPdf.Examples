using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfua
{
    public static class Section1
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