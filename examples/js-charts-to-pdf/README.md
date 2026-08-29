> Full guide: [JS charts to PDF](https://ironpdf.com/examples/js-charts-to-pdf/)

IronPDF converts HTML to PDF with full JavaScript rendering, which covers graphic components such as canvas and charts, including 3D visualizations and complex polygons.

Supported chart libraries include:

- C3.js
- D3.js
- Highcharts

The process begins by crafting the HTML content intended for PDF production. This includes embedding JavaScript to generate a bar chart with the C3 library. Utilizing `setTimeout`, the script calls `window.ironpdf.notifyRender()` after a delay of 1 second. This function call informs IronPDF that JavaScript execution is complete and the page is ready for rendering.

The steps below convert that content into a PDF. First, create a `ChromePdfRenderer` object, which runs the JavaScript embedded in the HTML.

Several rendering options are configured through the `RenderingOptions` class to optimize PDF production. Setting `EnableJavaScript = true` guarantees the execution of JavaScript in our HTML. `WaitFor.JavaScript()` stalls the rendering until all scripts are fully executed, ensuring accurate chart visualization. Additionally, `CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print` adjusts the CSS media type to print mode, which is ideal for PDF output.

Following setups, the HTML content is transformed into a PDF using the `RenderHtmlAsPdf` method, which takes the `htmlWithJs` content and produces a fresh PDF file.

The final step involves saving the newly created PDF document with the `SaveAs` method, enabling you to secure a PDF file that incorporates a dynamically rendered chart using HTML and JavaScript.

For more on JavaScript-to-PDF conversion, see [How to Convert JavaScript to PDF with IronPDF](https://ironpdf.com/how-to/javascript-to-pdf/).