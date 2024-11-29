***Based on <https://ironpdf.com/examples/viewport/>***

Converting an HTML page into a PDF document is typically a straightforward process. When dealing with responsive HTML pages, however, careful considerations must be made due to possible changes over time and through page interactions. IronPDF excels at converting responsive HTML into PDFs seamlessly.

Let's explore how to convert a responsive HTML page into a PDF document in this example.

With the `UseResponsiveCssRendering` method within the `PaperFit` attribute of the `PdfRenderingOptions` class, you have the option to set the dimensions of the virtual Chrome window that will render your responsive HTML. 

This functionality enables developers to programmatically select a particular responsive layout from webpages crafted with responsive CSS3 and is compatible with modern HTML5 responsive frameworks like Bootstrap.

Using `IronPdf.ChromePdfRenderer`, any webpage or HTML snippet can be effortlessly transformed into a PDF document employing a contemporary embedded Chrome browser.

As of 2021, Iron Software endorses the `ChromePdfRenderer` as our superior PDF rendering solution, serving as an ideal replacement for this class. This tool also permits the application of cookies associated with certain login credentials to a designated URL, the creation of a PDF from an HTML string, and the output as a `PdfDocument` object. This object can be further modified, saved to disk, or hosted on a website. For more information on how to leverage the ChromePdfRenderer, please visit the [IronPDF product page](https://ironpdf.com/).