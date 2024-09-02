using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Create text stamper
TextStamper textStamper = new TextStamper()
{
    Text = "Text Stamper!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top,
};

// Stamp the text stamper
pdf.ApplyStamp(textStamper);

pdf.SaveAs("stampText.pdf");