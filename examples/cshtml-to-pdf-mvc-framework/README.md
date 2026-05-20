***Based on <https://ironpdf.com/examples/cshtml-to-pdf-mvc-framework/>***

This example demonstrates how to transform Views into PDF files using specific software packages.

By utilizing the `IronPdf.Extensions.Mvc.Framework` and `IronPdf`, this conversion process is streamlined, with the former package enhancing the latter by enabling PDF rendering from Views directly.

To execute this transformation, employ the `RenderView` method. Essential parameters for this method include an `HttpContext`, the location of the ".cshtml" file, and the data needed for the ".cshtml" template. Through the use of the 'Persons' action, converting the current View to a PDF is effortlessly achieved.

Moreover, the **RenderingOptions** class provides a variety of features. These capabilities allow the addition of [page numbers using IronPDF](https://ironpdf.com/how-to/page-numbers/), the insertion of [text and HTML headers and footers with IronPDF](https://ironpdf.com/how-to/headers-and-footers/), and the customization of the PDF's paper size to meet your specific needs. This flexibility ensures that you can modify the PDF further or export it as required.

[Discover more about the CSHTML to PDF Conversion Guide](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-framework/)