using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Embed the PDF viewer and load a file instantly!
            var viewer = new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };
        }
    }
}