using IronPdf.Editing;
using IronPdf;
namespace ironpdf.Signing
{
    public class Section8
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);
            
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}