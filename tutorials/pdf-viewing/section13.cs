using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section13
    {
        public void Run()
        {
            pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
        }
    }
}