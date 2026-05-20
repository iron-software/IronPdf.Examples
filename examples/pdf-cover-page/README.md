***Based on <https://ironpdf.com/examples/pdf-cover-page/>***

Improving the aesthetic appeal of PDF documents can often be achieved by including a visually engaging cover page. This not only enhances the look of your PDF but also provides an excellent opportunity to feature your branding or capture the attention of your readers. IronPDF simplifies the process of adding cover pages to PDF documents, allowing developers to perform this task with minimal code via its merging capabilities.

## Steps to Implement Cover Pages in PDF Documents

In this guide, we'll demonstrate how to add a cover page to a PDF by first converting an HTML string into a PDF format. It's also feasible to utilize an existing PDF that already includes a desired cover page. To begin, we instantiate a new `ChromePdfRenderer` object, which is tailored for converting HTML into PDFs with high fidelity, incorporating CSS, and JavaScript elements.

Next, we craft our cover page by using the `RenderHtmlAsPdf` method on our HTML string. For those using an already existing cover page in a PDF format, you would instead use `PdfDocument.FromFile` to load your PDF. We then configure our PDF renderer by setting the initial page number to 2. This adjustment is crucial as it ensures the page numbering begins at 2 rather than the default starting point of 1 when we proceed to render our main PDF document.

We then proceed to generate our primary PDF document. In this example, it is created from web content fetched from a URL. At this stage, we hold two separate PDF objects; one with our cover and another with the main content from the URL.

The final phase involves merging the cover page with the main PDF document. This can be done seamlessly with the command `InsertPdf(cover, 0)`, which places the cover at the very start of the PDF document. At this point, the variable `pdf` refers to a unified PDF file that includes both the initial cover and the main contents. Lastly, the `SaveAs` method is employed to save the final integrated PDF to a predetermined location.

[Learn to Create a Table of Contents in Your PDFs](https://ironpdf.com/how-to/table-of-contents/)