IronPdf.License.LicenseKey = "YourLicenseKey";
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

List<int> pageList = new List<int>() { 1, 2 };

pdf.RasterizeToImageFiles("*.png", pageList);