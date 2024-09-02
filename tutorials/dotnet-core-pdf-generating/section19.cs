IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
pdf.Sign(new PdfSignature("cert123.pfx", "password"), IronPdf.Signing.SignaturePermissions.Default);
pdf.SaveAs("signed.pdf");