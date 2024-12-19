***Based on <https://ironpdf.com/examples/merge-pdfs/>***

Efficiently combine PDFs of varying sizes and complexities using the `Merge` method from IronPDF.

The `PdfDocument.Merge` function allows you to amalgamate multiple PDF documents into a singular PDF file.

Incorporate the `PdfDocument.Merge` function within your C# applications to:

1. Programmatically incorporate cover pages or cover letters into existing PDFs,
2. Combine PDFs that have been transformed from HTML documents.

The `PdfDocument.Merge` can concatenate an unlimited number of PDF files.

* * *

* * *

### Further Insights

To concatenate two PDF documents, input each PDF as an individual argument, as demonstrated in line 17 of the showcased example.

For merging more than two PDF files, replace the method that takes two arguments with its `List` counterpart:

```cs
// Create a list of PdfDocument objects
List<PdfDocument> pdfs = new List<PdfDocument>()
{
    pdfdoc_a,  // First PDF document
    pdfdoc_b,  // Second PDF document
    pdfdoc_c,  // Third PDF document
    // Add more PDF documents as needed
};
// Merge all PDF documents into one
var merged = PdfDocument.Merge(pdfs);
// Save the merged document to a file
merged.SaveAs("Merged.pdf");
```