Turning an HTML page into a PDF can be a simple process, but special attention is needed when dealing with responsive HTML. This is because the layout can vary over time or as the user navigates through the site. IronPDF offers a robust solution for converting responsive HTML into PDF documents.

In this guide, we will demonstrate how to convert a responsive HTML page into a PDF document.

Utilizing the `UseResponsiveCssRendering` method, found in the `PaperFit` attribute of the `PdfRenderingOptions` class, you can set the dimensions for the virtual Chrome window responsible for rendering your responsive HTML.

This feature enables developers to programmatically select the responsive layout of a webpage crafted with responsive CSS3 technologies, and it supports leading responsive HTML5 frameworks such as Bootstrap.

The `IronPdf.ChromePdfRenderer` class enables the conversion of any web page or HTML snippet into a PDF using a current embedded Chrome browser.

As of 2021, Iron Software advises using `ChromePdfRenderer` as the optimal PDF renderer and an immediate replacement for this component. This renderer not only allows you to add cookies using specified login credentials but also to generate a PDF from an HTML string and output it as a `PdfDocument` object. This object can then be further modified, saved locally, or hosted online.