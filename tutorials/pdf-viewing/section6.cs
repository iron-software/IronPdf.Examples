using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section6
    {
        public void Run()
        {
            <?xml version="1.0" encoding="utf-8" ?>
            <ContentPage ...
                xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
                ...>
                <ipv:IronPdfView Source="C:/path/to/my/example.pdf" />
            </ContentPage>
        }
    }
}