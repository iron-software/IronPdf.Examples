***Based on <https://ironpdf.com/examples/cshtml-to-pdf-mvc-framework/>***

The following example demonstrates converting Views into PDF documents.

Utilizing the `IronPdf.Extensions.Mvc.Framework` alongside `IronPdf`, we can efficiently transform Views into PDF documents. The `IronPdf.Extensions.Mvc.Framework` library enhances the functionality of IronPdf by enabling the transformation of Views into PDFs.

For converting a view to a PDF, employ the `RenderView` method. This function demands several essential parameters, including `HttpContext`, the path to the ".cshtml" file, and the data required to populate the ".cshtml" template. By triggering the 'Persons' action, you can easily convert the current View to a PDF file.

Moreover, the `RenderingOptions` class delivers an extensive repertoire of features. These capabilities permit adding [page numbers with IronPDF](https://ironpdf.com/how-to/page-numbers/), integrating [text and HTML headers and footers using IronPDF](https://ironpdf.com/examples/html-headers-footers/), and tailoring the PDF paper size to meet specific needs. This allows for additional adjustments or the exportation of the resultant PDF document as desired.