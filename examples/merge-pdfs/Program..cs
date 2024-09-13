using IronPdf;

var html_a = @"<p> [PDF_A] </p>
        <p> [PDF_A] 1st Page </p>
        <div style = 'page-break-after: always;' ></div>
        <p> [PDF_A] 2nd Page</p>";

var html_b = @"<p> [PDF_B] </p>
        <p> [PDF_B] 1st Page </p>
        <div style = 'page-break-after: always;' ></div>
        <p> [PDF_B] 2nd Page</p>";

var renderer = new ChromePdfRenderer();

var pdfdoc_a = renderer.RenderHtmlAsPdf(html_a);
var pdfdoc_b = renderer.RenderHtmlAsPdf(html_b);
var merged = PdfDocument.Merge(pdfdoc_a, pdfdoc_b);

merged.SaveAs("Merged.pdf");