using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section11
    {
        public static void Run()
        {
            pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
        }
    }
}