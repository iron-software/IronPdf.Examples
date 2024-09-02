IronPdf.License.LicenseKey = "YourLicenseKey";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
{
    CenterText = "Pdf Header",
    LeftText = "{date} {time}",
    RightText = "{page} of {total-pages}",
    DrawDividerLine = true,
    FontSize = 10
};

renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<span style='text-align:right'> page {page} of {totalpages}</span>",
    DrawDividerLine = true,
    MaxHeight = 10
};

PdfDocument pdf = renderer.RenderHtmlFileAsPdf("test.html");
pdf.SaveAs("generatedFile.pdf");