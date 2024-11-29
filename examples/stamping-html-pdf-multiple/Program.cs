using IronPdf;
using IronPdf.Editing;
using System;

// Use HtmlStamper to stamp Html onto pdf
HtmlStamper htmlStamper = new HtmlStamper("<h1>Html stamp</h1>")
{
    VerticalOffset = new Length(-200, MeasurementUnit.Pixel),
    HorizontalOffset = new Length(-200, MeasurementUnit.Pixel),
};

// Use TextStamper to stamp text with custom font onto pdf
TextStamper textStamper = new TextStamper("Hello World! Stamp One Here!")
{
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
};

// Use ImageStamper to stamp images onto pdf
Uri filepath = new Uri(@"C:\assets\logo.png"); // absolute path or URL
ImageStamper imageStamper = new ImageStamper(filepath)
{
    VerticalAlignment = VerticalAlignment.Top,
    MinWidth = new Length(20),
    MinHeight = new Length(20),
};

// Use BarcodeStamper to stamp QR code/Barcode onto pdf
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39)
{
    MaxHeight = new Length(5),
    VerticalAlignment = VerticalAlignment.Bottom,
    HorizontalAlignment = HorizontalAlignment.Left,
};

Stamper[] stamps = { htmlStamper, textStamper, imageStamper, barcodeStamper };

var pdf = PdfDocument.FromFile("Unstamped.pdf");
pdf.ApplyMultipleStamps(stamps);
pdf.SaveAs("Stamped.pdf");
