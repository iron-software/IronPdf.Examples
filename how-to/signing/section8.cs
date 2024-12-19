using IronPdf.Editing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section8
    {
        public static void Run()
        {
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);
            
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}