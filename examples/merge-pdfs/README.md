> Full guide: [Merge PDFs](https://ironpdf.com/examples/merge-pdfs/)

IronPDF consolidates several PDF documents into a single file, whether they were rendered from HTML or loaded from disk. The structure and content of each source document are preserved.

## The 5 Steps to Merging PDF Documents in C#

To start merging PDF documents, the initial step is to construct the HTML strings that will be rendered into PDFs. For this example, we'll refer to these HTML strings as `html_a` and `html_b`. After formulating these strings, the next phase involves rendering them into PDF files.

You will begin by initiating a new `ChromePdfRenderer` object. This renderer is crucial for transforming the HTML we crafted earlier into high-quality PDF documents through the `RenderHtmlAsPdf` method.

Following the rendering process, the next step is to merge these PDFs into a unified document named `Merged.pdf`. The `Merge` method combines the documents in a single line of code.

The final step is to save the newly merged PDF file. Once saved, the rest of the IronPDF API is available for further edits.

Moreover, IronPDF's functionality is not limited to merging just two PDFs. In our simplified example, we showcased the process for two documents. To merge a more extensive set of PDF files, you would apply a List overload in place of the two-argument method, accommodating multiple documents. This advanced technique allows for greater flexibility in PDF management.

Discover advanced merging techniques and straightforward code examples by visiting [here](https://ironpdf.com/how-to/merge-or-split-pdfs/#simple-pdf-merge-code-example).