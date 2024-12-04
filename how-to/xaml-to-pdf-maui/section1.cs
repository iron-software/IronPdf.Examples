using IronPdf.Extensions.Maui;

namespace mauiSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void PrintToPdf(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Apply HTML header
        renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
        {
            HtmlFragment = "<h1>Header</h1>",
        };

        // Render PDF from Maui Page
        PdfDocument pdf = renderer.RenderContentPageToPdf<MainPage, App>().Result;

        pdf.SaveAs(@"C:\Users\lyty1\Downloads\contentPageToPdf.pdf");
    }
}