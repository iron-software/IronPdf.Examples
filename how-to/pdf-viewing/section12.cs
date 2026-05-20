using IronPdf;
namespace IronPdf.Examples.HowTo.PdfViewing
{
    public static class Section12
    {
        public static void Run()
        {
            pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
        }
    }
}