using IronPdf;

// Instantiate renderer
var renderer = new ChromePdfRenderer();

/* Cover Page */
// Create a sample cover using the RenderHtmlAsPdf method
var cover = renderer.RenderHtmlAsPdf("<h1>This is a Cover Page</h1>");


/* Main Document */
// As we have a cover page, we're going to start the page numbers at 2.
renderer.RenderingOptions.FirstPageNumber = 2;

// Download from a URL & convert to PDF in just one line!
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");

// Only ONE line to combine two PDFs.
pdf.InsertPdf(cover, 0).SaveAs("combined.pdf");
