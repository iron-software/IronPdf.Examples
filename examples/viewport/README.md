***Based on <https://ironpdf.com/examples/viewport/>***

Turning a responsive HTML page into a PDF can be simple, but it requires more attention due to the dynamic nature of responsive designs. IronPDF efficiently handles the conversion of responsive HTML into PDF documents.

Below, we guide you through the process of converting a responsive HTML page into a PDF document.

You can define the dimensions of the virtual Chrome window that renders the responsive HTML by utilizing the `UseResponsiveCssRendering` method available in the `PaperFit` property of the `PdfRenderingOptions` class. This feature allows developers to programmatically select a desired responsive layout from webpages crafted with responsive CSS3, and it also supports various modern HTML5 responsive frameworks, including Bootstrap.

`IronPdf.ChromePdfRenderer` enables the conversion of any webpage or HTML snippet into a PDF file using an integrated Chrome browser that's always up-to-date.

As of the year 2021, Iron Software endorses `ChromePdfRenderer` as the optimal choice for PDF rendering and a direct replacement for earlier classes. This renderer also allows the application of specific cookie data through the given login credentials to certain URLs, the creation of a PDF from an HTML string, and outputting the result as a `PdfDocument`. This document can then be modified, saved to a local storage, or uploaded for online access. For additional information on utilizing `ChromePdfRenderer`, please explore the [IronPDF product page](https://ironpdf.com).

[Discover more about Responsive HTML to PDF Conversion](https://ironpdf.com/how-to/html-to-pdf-responsive-css/).