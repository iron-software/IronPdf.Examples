using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Create barcode stamper
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPdf!!", BarcodeEncoding.Code39)
{
    VerticalAlignment = VerticalAlignment.Top,
};

// Stamp the barcode stamper
pdf.ApplyStamp(barcodeStamper);

pdf.SaveAs("stampBarcode.pdf");