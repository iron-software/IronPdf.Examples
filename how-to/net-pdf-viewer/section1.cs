using IronPdf;
namespace IronPdf.Examples.HowTo.NetPdfViewer
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Embed a complete PDF viewer in one line!
            new IronPdf.Viewer.Maui.IronPdfView { Source = IronPdf.Viewer.Maui.PdfViewSource.FromFile("document.pdf") };
        }
    }
}