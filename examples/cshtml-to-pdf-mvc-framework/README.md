***Based on <https://ironpdf.com/examples/cshtml-to-pdf-mvc-framework/>***

The following code example demonstrates how to transform Views into PDF documents.

We leverage two powerful packages: `IronPdf.Extensions.Mvc.Framework` and `IronPdf`. These packages enhance the process of converting Views to PDF files. The `IronPdf.Extensions.Mvc.Framework` specifically provides functionality that allows for the efficient rendering of Views into PDF documents.

To carry out this conversion, the `RenderView` method is employed. This method demands several critical parameters: an `HttpContext`, the path to the `.cshtml` file, and the required data to populate the `.cshtml` template. By executing the 'Persons' action, this method facilitates the conversion of the current View into a PDF format seamlessly.

Moreover, the **RenderingOptions** class presents a robust array of features. These functionalities allow you to implement [page numbers with IronPDF](https://ironpdf.com/how-to/page-numbers/), incorporate [text and HTML headers and footers with IronPDF](https://ironpdf.com/examples/html-headers-footers/), and tailor the PDF's paper size to meet specific needs. This suite of features provides the flexibility to adjust further or export the produced PDF document as desired.