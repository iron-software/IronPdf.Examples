using IronPdf;
using IronPdf.Editing;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.RenderDelay(500);

// Load barcode via HTML
var barcodeHtml = @"<link href=""https://fonts.googleapis.com/css?family=Libre%20Barcode%20128""rel = ""stylesheet"" ><p style = ""font-family: 'Libre Barcode 128', serif; font-size:30px;""> Hello Google Fonts</p>";
var doc = renderer.RenderHtmlAsPdf(barcodeHtml);

// or use the BarcodeStamper
var barcodeStamp = new BarcodeStamper("Hello World", BarcodeEncoding.Code39);
doc.ApplyStamp(barcodeStamp);

// Export to a file or Stream
doc.SaveAs("bc-test.pdf");
