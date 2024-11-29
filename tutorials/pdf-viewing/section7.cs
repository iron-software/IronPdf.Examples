using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section7
    {
        public void Run()
        {
            // We assume an IronPdfView instance is created previously called pdfView
            pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
        }
    }
}