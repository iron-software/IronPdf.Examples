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

// Create our main document
var pdfdoc_a = renderer.RenderHtmlAsPdf(html_a);

// Create and select a page to copy
var pdfdoc_b = renderer.RenderHtmlAsPdf(html_b);
var page_to_insert = pdfdoc_b.CopyPage(1);

// 3 ways to insert:

pdfdoc_a.AppendPdf(page_to_insert); // at the end
                                    // or
pdfdoc_a.PrependPdf(page_to_insert); // at the start
                                     // or
pdfdoc_a.InsertPdf(page_to_insert, 1); // in the middle

pdfdoc_a.SaveAs("CopiedPages.pdf");
```
To learn more about working with PDF documents using IronPDF, visit the [IronPDF Documentation](https://ironpdf.com/docs/). For an overview of Iron Software's full suite of products, refer to the [Iron Software Product Page](https://ironsoftware.com/). Explore how IronPDF can facilitate your PDF editing tasks and how IronOCR can enhance your OCR capabilities.