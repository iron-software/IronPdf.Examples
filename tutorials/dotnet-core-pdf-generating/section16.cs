IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
TextHeaderFooter header = new TextHeaderFooter()
{
    CenterText = "Pdf Header",
    LeftText = "{date} {time}",
    RightText = "{page} of {total-pages}",
    DrawDividerLine = true,
    FontSize = 10
};
pdf.AddTextHeaders(header);
pdf.SaveAs("withHeader.pdf");

HtmlHeaderFooter Footer = new HtmlHeaderFooter()
{
    HtmlFragment = "<span style='text-align:right'> page {page} of {totalpages}</span>",
    DrawDividerLine = true,
    MaxHeight = 10 //mm
};
pdf.AddHtmlFooters(Footer);
pdf.SaveAs("withHeaderAndFooters.pdf");