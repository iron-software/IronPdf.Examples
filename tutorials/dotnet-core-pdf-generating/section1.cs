IronPdf.License.LicenseKey = "YourLicenseKey";
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
pdf.SaveAs("wiki.pdf");