using IronPdf;
namespace ironpdf.TransformPdfPages
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("basic.pdf");
            
            pdf.Pages[0].Transform(50, 50, 0.8, 0.8);
            
            pdf.SaveAs("transformPage.pdf");
        }
    }
}