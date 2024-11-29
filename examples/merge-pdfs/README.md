***Based on <https://ironpdf.com/examples/merge-pdfs/>***

Combine PDFs effortlessly regardless of their complexity or size using IronPDF's `Merge` method.

The `PdfDocument.Merge` function consolidates multiple PDF files into a unified document.

Employ the `PdfDocument.Merge` function within your C# projects to:

1. Insert cover pages or cover letters into existing PDF files programmatically,
2. Combine PDFs that have been converted from HTML.

The `PdfDocument.Merge` is capable of merging an unlimited number of PDF files.

* * *

* * *

### Additional Information

To combine two PDF documents, provide each PDF as distinct arguments, as shown in line 17 of the sample code provided.

To amalgamate more than two PDFs, replace the two-argument approach with the `List` variant:

```cs
List<PdfDocument> pdfDocuments = new List<PdfDocument>()
{
    pdfdoc_a,
    pdfdoc_b,
    pdfdoc_c,
    // additional PDF documents can be added here
};
var combinedPDF = PdfDocument.Merge(pdfDocuments);
combinedPDF.SaveAs("Merged.pdf");  // Save the resulting merged PDF with the filename 'Merged.pdf'
```

This enhanced process allows for the merging of multiple PDF files seamlessly.