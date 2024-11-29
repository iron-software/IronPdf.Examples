using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section8
    {
        public void Run()
        {
            pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
        }
    }
}