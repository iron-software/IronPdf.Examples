using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Create two text stampers
TextStamper stamper1 = new TextStamper()
{
    Text = "Text stamp 1",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Left,
};

TextStamper stamper2 = new TextStamper()
{
    Text = "Text stamp 2",
    VerticalAlignment = VerticalAlignment.Top,
    HorizontalAlignment = HorizontalAlignment.Right,
};

Stamper[] stampersToApply = { stamper1, stamper2 };

// Apply multiple stamps
pdf.ApplyMultipleStamps(stampersToApply);

pdf.SaveAs("multipleStamps.pdf");