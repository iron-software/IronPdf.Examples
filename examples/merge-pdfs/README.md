***Based on <https://ironpdf.com/examples/merge-pdfs/>***

IronPDF's merge functionality enables you to seamlessly consolidate multiple PDF documents into a single file. This is achievable with both HTML-rendered PDFs or existing PDF documents, thanks to IronPDF's straightforward API for merging. Utilize the robust merging capabilities of IronPDF to merge your PDFs efficiently while preserving the structural and content integrity of each document.

## The 5 Steps to Merging PDF Documents in C#

To start merging PDF documents, the initial step is to construct the HTML strings that will be rendered into PDFs. For this example, we'll refer to these HTML strings as `html_a` and `html_b`. After formulating these strings, the next phase involves rendering them into PDF files.

You will begin by initiating a new `ChromePdfRenderer` object. This renderer is crucial for transforming the HTML we crafted earlier into high-quality PDF documents through the `RenderHtmlAsPdf` method.

Following the rendering process, the next step is to merge these PDFs into a unified document named `Merged.pdf`. This merging is executed using the `Merge` method, which efficiently combines the provided PDF documents into one with a single line of code, streamlining the document merging process using IronPDF.

The final step is to save the newly merged PDF file. Once saved, you can leverage the diverse suite of tools provided by IronPDF to further refine and alter the PDF document.

Moreover, IronPDF's functionality is not limited to merging just two PDFs. In our simplified example, we showcased the process for two documents. To merge a more extensive set of PDF files, you would apply a List overload in place of the two-argument method, accommodating multiple documents. This advanced technique allows for greater flexibility in PDF management.

Discover advanced merging techniques and straightforward code examples by visiting [here](https://ironpdf.com/how-to/merge-or-split-pdfs/#simple-pdf-merge-code-example).