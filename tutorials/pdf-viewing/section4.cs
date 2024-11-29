using IronPdf.Viewer.Maui;
using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section4
    {
        public void Run()
        {
            public class MainPage : ContentPage
            {
                private readonly IronPdfView pdfView;
            
                public MainPage()
                {
                    InitializeComponent();
            
                    this.pdfView = new IronPdfView { Options = IronPdfViewOptions.All };
            
                    Content = this.pdfView;
                }
            }
        }
    }
}