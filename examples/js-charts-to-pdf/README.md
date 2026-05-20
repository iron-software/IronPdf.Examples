***Based on <https://ironpdf.com/examples/js-charts-to-pdf/>***

IronPDF offers robust HTML-to-PDF conversion features and supports comprehensive JavaScript rendering. This includes the ability to handle various graphic components such as canvas, and charts. Utilizing this functionality allows developers to produce high-quality PDF documents featuring intricate charts, like 3D visual representations and complex polygons.

Supported chart libraries include:

- C3.js
- D3.js
- Highcharts

The process begins by crafting the HTML content intended for PDF production. This includes embedding JavaScript to generate a bar chart with the C3 library. Utilizing `setTimeout`, the script calls `window.ironpdf.notifyRender()` after a delay of 1 second. This function call informs IronPDF that JavaScript execution is complete and the page is ready for rendering.

Let's delve into the steps involved in converting this content into a reader-friendly PDF. Initially, a `ChromePdfRenderer` object is created, tapping into IronPDF's advanced rendering engine. This renderer is essential for processing the JavaScript embedded in the HTML seamlessly.

Several rendering options are configured through the `RenderingOptions` class to optimize PDF production. Setting `EnableJavaScript = true` guarantees the execution of JavaScript in our HTML. `WaitFor.JavaScript()` stalls the rendering until all scripts are fully executed, ensuring accurate chart visualization. Additionally, `CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print` adjusts the CSS media type to print mode, which is ideal for PDF output.

Following setups, the HTML content is transformed into a PDF using the `RenderHtmlAsPdf` method, which takes the `htmlWithJs` content and produces a fresh PDF file.

The final step involves saving the newly created PDF document with the `SaveAs` method, enabling you to secure a PDF file that incorporates a dynamically rendered chart using HTML and JavaScript.

Discover more about converting JavaScript to PDF seamlessly with IronPDF through this detailed guide: [Discover How to Convert JavaScript to PDF with IronPDF](https://ironpdf.com/how-to/javascript-to-pdf/).