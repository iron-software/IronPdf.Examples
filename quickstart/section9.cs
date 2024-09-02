using IronPdf;
using System.Collections.Generic;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Join Multiple Existing PDFs into a single document
List<PdfDocument> pdfs = new List<PdfDocument>();
pdfs.Add(PdfDocument.FromFile("A.pdf"));
pdfs.Add(PdfDocument.FromFile("B.pdf"));
pdfs.Add(PdfDocument.FromFile("C.pdf"));
PdfDocument mergedPdfDocument = PdfDocument.Merge(pdfs);
mergedPdfDocument.SaveAs("merged.pdf");

// Add a cover page
mergedPdfDocument.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"));

// Remove the last page from the PDF and save again
mergedPdfDocument.RemovePage(mergedPdfDocument.PageCount - 1);
mergedPdfDocument.SaveAs("merged.pdf");

// Copy pages 1,2 and save them as a new document.
mergedPdfDocument.CopyPages(1, 2).SaveAs("exerpt.pdf");
foreach (PdfDocument pdfDocument in pdfs)
{
    pdfDocument.Dispose();
}