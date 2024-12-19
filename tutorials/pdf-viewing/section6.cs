using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section6
    {
        public static void Run()
        {
            pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
        }
    }
}