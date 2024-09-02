using IronPdf.Viewer.Maui;

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
