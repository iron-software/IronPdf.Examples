using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section9
    {
        public static void Run()
        {
            <?xml version="1.0" encoding="utf-8" ?>
            <ContentPage ...
                xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
                ...>
                <ipv:IronPdfView x:Name="pdfView" Options="All"/>
            </ContentPage>
        }
    }
}