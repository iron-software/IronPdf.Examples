using IronPdf.Viewer.Maui;

namespace IronPdfViewerApp;

public partial class ViewerPage : ContentPage
{
	public ViewerPage()
	{
		InitializeComponent();
	}

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        var doc = renderer.RenderUrlAsPdf(htmlContent.Text);
        this.pdfView.Source = IronPdfViewSource.FromBytes(doc.BinaryData);
    }

    private async void ViewerPage_OnLoaded(object sender, EventArgs e)
    {
        htmlContent.Text = "https://ironpdf.com/";
    }

    private async void HtmlContent_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        this.webView.Source = htmlContent.Text;
    }

    private void WebView_OnNavigated(object sender, WebNavigatedEventArgs e)
    {
    }
}