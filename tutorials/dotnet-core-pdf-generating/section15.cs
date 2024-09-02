IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdf = PdfDocument.FromFile("1.pdf");
PdfDocument pdf2 = PdfDocument.FromFile("2.pdf");
pdf.InsertPdf(pdf2, 0);
pdf.SaveAs("InsertIntoSpecificIndex.pdf");