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
        var doc = renderer.RenderHtmlAsPdf(htmlContent.Text);
        this.pdfView.Source = IronPdfViewSource.FromBytes(doc.BinaryData);
    }
}