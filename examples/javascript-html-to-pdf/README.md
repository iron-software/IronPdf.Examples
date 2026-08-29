> Full guide: [JavaScript HTML to PDF](https://ironpdf.com/examples/javascript-html-to-pdf/)

IronPDF provides the functionality to convert HTML into PDF documents, including HTML enriched with custom CSS and JavaScript. By embedding JavaScript directly within the HTML content, it's possible to incorporate elements like images directly into the HTML string, eliminating the need for external resources. This is accomplished using the `ChromePdfRenderer` class and its `RenderingOptions` property.

### 5 Steps to Converting HTML with JavaScript to PDF using C#

Follow these five simple steps to transform HTML that contains JavaScript into a PDF document in C#:

1. Define your HTML content with JavaScript: 
    ```csharp
    const string htmlWithJavaScript = "....";
    ```
2. Create an instance of the `ChromePdfRenderer`:
    ```csharp
    var renderer = new ChromePdfRenderer();
    ```
3. Enable JavaScript in your rendering options:
    ```csharp
    renderer.RenderingOptions.EnableJavaScript = true;
    ```
4. Set the renderer to wait for JavaScript execution before rendering:
    ```csharp
    renderer.RenderingOptions.WaitForJavaScript();
    ```
5. Render the HTML as a PDF document:
    ```csharp
    var pdfJavaScript = renderer.RenderHtmlAsPdf(htmlWithJavaScript);
    ```

In the HTML string, we include a JavaScript `<script>` tag to specify the script content, allowing for interactive elements to function correctly in the final PDF. Recognition and execution of JavaScript are enabled through the `RenderingOptions` property.

The `ChromePdfRenderer` instance facilitates the conversion of HTML into precise PDF output, maintaining any bespoke JavaScript or CSS exactly as designed.

Use the `RenderingOptions` of the `ChromePdfRenderer` to ensure that the JavaScript executes correctly before the PDF rendering begins. The `RenderingOptions.WaitForJavaScript()` function guarantees that the rendering process doesn’t proceed until JavaScript execution is complete, initiated by `window.ironpdf.notifyRender()` method within the JavaScript code. These options are set on the `ChromePdfRenderer` instance, applying them universally to any PDF produced by this renderer.

The `renderer.RenderHtmlAsPdf(...)` method performs the core conversion to PDF. By submitting the HTML with JavaScript string to this method, you generate a detailed PDF showcasing all the HTML and JavaScript elements. This converted PDF is captured in a new `PdfDocument` object named `pdfJavaScript`. The document can then be saved using its `SaveAs` method.

For a deeper exploration of rendering JavaScript-infused HTML to PDF, refer to the [IronPDF Guide on Converting JavaScript HTML to PDF](https://ironpdf.com/how-to/javascript-to-pdf/).