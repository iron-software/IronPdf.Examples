using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section8
    {
        public static void Run()
        {
            pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
        }
    }
}