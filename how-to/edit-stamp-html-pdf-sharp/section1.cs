using IronPdf;
using IronPdf.Editing;

// Load PDF to be Stamped or Watermarked
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Configure and add stamp HTML behind the main content
var backgroundStamp = new HtmlStamper()
{
    Html = "<img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'/>",
    Opacity = 50,
    VerticalAlignment = IronPdf.Editing.VerticalAlignment.Top,
    HorizontalAlignment = IronPdf.Editing.HorizontalAlignment.Right,
    IsStampBehindContent = true,
};
pdf.ApplyStamp(backgroundStamp);

// Configure and add stamp HTML in front of the main content
var foregroundStamp = new HtmlStamper()
{
    Html = "<h2 style='color:red'>Copyright 2022 IronPDF.com</h2>",
    MaxWidth = new Length(50),
    MaxHeight = new Length(50),
    Opacity = 50,
    Rotation = -45,
    IsStampBehindContent = false,
};
pdf.ApplyStamp(foregroundStamp);

// Save the PDF with stamps to desire location
pdf.SaveAs("stamped.pdf");