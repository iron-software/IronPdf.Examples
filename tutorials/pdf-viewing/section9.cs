using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section9
    {
        public void Run()
        {
            pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
        }
    }
}