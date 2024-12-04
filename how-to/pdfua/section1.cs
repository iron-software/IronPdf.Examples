using IronPdf;
namespace ironpdf.Pdfua
{
    public class Section1
    {
        public void Run()
        {
            // Open PDF File
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Export as PDF/UA compliance PDF
            pdf.SaveAsPdfUA("pdf-ua-wikipedia.pdf");
        }
    }
}