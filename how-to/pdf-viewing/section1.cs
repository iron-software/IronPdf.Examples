using IronPdf;
namespace IronPdf.Examples.HowTo.PdfViewing
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Embed a full featured PDF viewer in one line!
            new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };
        }
    }
}