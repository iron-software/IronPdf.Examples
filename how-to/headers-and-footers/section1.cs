using IronPdf;

// Instantiate renderer and create PDF
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Create text header
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "This is the header!",
};

// Create text footer
TextHeaderFooter textFooter = new TextHeaderFooter
{
    CenterText = "This is the footer!",
};

// Add text header and footer to the PDF
pdf.AddTextHeaders(textHeader);
pdf.AddTextFooters(textFooter);

pdf.SaveAs("addTextHeaderFooter.pdf");