using IronPdf;
namespace IronPdf.Examples.HowTo.PdfViewing
{
    public static class Section6
    {
        public static void Run()
        {
            // We assume an IronPdfView instance is created previously called pdfView
            pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
        }
    }
}