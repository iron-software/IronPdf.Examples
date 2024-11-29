using IronPdf;
using System.Collections.Generic;

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Join Multiple Existing PDFs into a single document
var pdfs = new List<PdfDocument>();
pdfs.Add(PdfDocument.FromFile("A.pdf"));
pdfs.Add(PdfDocument.FromFile("B.pdf"));
pdfs.Add(PdfDocument.FromFile("C.pdf"));
var pdf = PdfDocument.Merge(pdfs);
pdf.SaveAs("merged.pdf");

// Add a cover page
pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"));

// Remove the last page from the PDF and save again
pdf.RemovePage(pdf.PageCount - 1);
pdf.SaveAs("merged.pdf");

// Copy pages 5-7 and save them as a new document.
pdf.CopyPages(4, 6).SaveAs("excerpt.pdf");

foreach (var eachPdf in pdfs)
{
    eachPdf.Dispose();
}
