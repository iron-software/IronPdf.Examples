
// PM > Install-Package IronPdf.Extensions.Maui

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Apply HTML header
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    HtmlFragment = "<h1>Header</h1>",
};

// Render PDF from Maui Page
PdfDocument pdf = renderer.RenderContentPageToPdf<MainPage, App>().Result;

pdf.SaveAs(@"C:\contentPageToPdf.pdf");
