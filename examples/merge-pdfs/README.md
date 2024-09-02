Effortlessly combine PDFs of varying complexities and sizes utilizing the `Merge` feature of IronPDF.

The `PdfDocument.Merge` function facilitates the unification of multiple PDF files into a singular document.

Incorporate the `PdfDocument.Merge` method within your C# projects to achieve tasks such as:

1. Programmatic insertion of cover pages or letters into existing PDFs,
2. Consolidation of PDFs that are converted from HTML.

The `PdfDocument.Merge` function is capable of merging an unlimited quantity of PDFs.

* * *

#### Additional Information

To combine two PDF files, identify each document as an individual argument, as exemplified on line 17 in the code example provided.

For merging more than two PDF documents, replace the dual-argument method with its `List` counterpart:

```cs
List<PdfDocument> pdfs = new List<PdfDocument>()
{
    pdfdoc_a,
    pdfdoc_b,
    pdfdoc_c,
    // further documents can be added here
};
var merged = PdfDocument.Merge(pdfs);
merged = SaveAs("Merged.pdf"); // Save the resulting merged document
```