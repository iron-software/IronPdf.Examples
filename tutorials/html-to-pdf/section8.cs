using IronPdf;
namespace ironpdf.HtmlToPdf
{
    public class Section8
    {
        public void Run()
        {
            // Create a PDF from an existing HTML using C#
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlFileAsPdf("Assets/TestInvoice1.html");
            pdf.SaveAs("Invoice.pdf");
        }
    }
}