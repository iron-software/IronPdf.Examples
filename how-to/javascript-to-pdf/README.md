# How to Integrate JavaScript into HTML to PDF Conversion

***Based on <https://ironpdf.com/how-to/javascript-to-pdf/>***


JavaScript, a high-level and flexible programming language, is pivotal for enhancing web functionality by adding interactive features. jQuery, while not a standalone programming language, serves as a JavaScript library that simplifies various tasks such as DOM manipulation, event handling, and AJAX operations.

IronPDF excels in handling JavaScript through its use of the [Chromium](https://www.chromium.org/chromium-projects/) rendering engine. This guide illustrates utilizing JavaScript and jQuery during HTML to PDF conversions in .NET C# applications. You can start experimenting with IronPDF by accessing its [free trial](https://ironpdf.com/tutorials/html-to-pdf/).

### Initial Setup for IronPDF

---

## Rendering JavaScript in PDF

IronPDF adeptly supports JavaScript within HTML for seamless PDF conversion. For effective rendering that incorporates JavaScript elements, it's often necessary to give the JavaScript sufficient time to run. You can manage this through the [WaitFor settings in IronPDF](https://ironpdf.com/how-to/waitfor/), specifically using `WaitFor.JavaScript` with a wait time of up to 500 milliseconds.

```cs
using IronPdf;

var htmlContent = @"<h1>This is HTML</h1>
<script>
    document.write('<h1>This is JavaScript</h1>');
    window.ironpdf.notifyRender();
</script>";

// Creating a new PDF Renderer
var pdfRenderer = new ChromePdfRenderer();

// Activate JavaScript execution
pdfRenderer.RenderingOptions.EnableJavaScript = true;
// Setup a 500ms wait period for JavaScript execution
pdfRenderer.RenderingOptions.WaitFor.JavaScript(500);

// Convert the HTML with JavaScript to PDF
var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent);

// Save the generated PDF
pdfDocument.SaveAs("outputWithJavaScript.pdf");
```

Be aware that some complex JavaScript frameworks may have limitations due to memory constraints within IronPDF and .NET.

---

## Implementing Custom JavaScript in HTML to PDF Conversion

IronPDF's rendering options can execute custom snippets of JavaScript before converting HTML to PDF—a useful feature for URL-based rendering where injecting code is otherwise challenging. Assign custom JavaScript directly to the `JavaScript` property.

```cs
using IronPdf;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Custom JavaScript to modify styles
pdfRenderer.RenderingOptions.Javascript = @"
document.querySelectorAll('h1').forEach(el => {
    el.style.color = 'red';
});";

// Processing the HTML to PDF conversion
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Greetings!</h1>");

document.SaveAs("customJavaScript.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/executeJavascript.pdf" width="100%" height="400px">
</iframe>

---

## Tracking JavaScript Console Messages in PDF

With IronPDF, it's straightforward to capture and log any JavaScript messages or errors output to the console during the PDF conversion process. This can be achieved by setting the `JavascriptMessageListener` option.

```cs
using IronPdf;
using System;

ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Setup a listener for JavaScript console messages
pdfRenderer.RenderingOptions.JavascriptMessageListener = message => Console.WriteLine($"JS Alert: {message}");
// Adding a console log entry
pdfRenderer.RenderingOptions.Javascript = "console.log('Test Log Entry');";

// Convert HTML to PDF while capturing logs
PdfDocument document1 = pdfRenderer.RenderHtmlAsPdf("<h1>Hello, there!</h1>");

// This will trigger an error in the console
pdfRenderer.RenderingOptions.Javascript = "document.querySelector('non-existent').style.backgroundColor = 'green';";

// Another HTML to PDF conversion while capturing error
PdfDocument document2 = pdfRenderer.RenderHtmlAsPdf("<h1>Second Example</h1>");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/console.webp" alt="JavaScript console example" class="img-responsive add-shadow">
    </div>
</div>

---

## Dynamic Chart Creation with D3.js & IronPDF

[D3.js](https://d3js.org/), often used in conjunction with [SVG](https://en.wikipedia.org/wiki/Scalable_Vector_Graphics#) and [HTML5](https://en.wikipedia.org/wiki/HTML5), is a powerful library for building interactive data visualizations, and it integrates smoothly with IronPDF.

Here's a sample implementation of creating a chart with D3.js and converting it to PDF using IronPDF:

```cs
using IronPdf;

string htmlCode = @"
<!DOCTYPE html>
<html>
<head>
<meta charset=""utf-8"" />
<title>D3 Chart</title>
</head>
<body>
<div id=""chart"" style=""width: 950px;""></div>
<script src=""https://d3js.org/d3.v4.js""></script>

<link href=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.css"" rel=""stylesheet"">

<script src=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.js""></script>

<script>
Function.prototype.bind = Function.prototype.bind || function (that) {
    var fn = this;
    return function () {
        return fn.apply(that, arguments);
    };
};
var chart = c3.generate({
    bindto: '#chart',
    data: {
        columns: [
            ['data1', 30, 200, 100, 400, 150, 250],
            ['data2', 50, 20, 10, 40, 15, 25]
        ]
    }
});
</script>
</body>
</html>
";

// Setting up Renderer
var chartRenderer = new ChromePdfRenderer();

// Enable JavaScript to allow chart setup
chartRenderer.RenderingOptions.EnableJavaScript = true;
// Establishing a wait time for chart rendering
chartRenderer.RenderingOptions.WaitFor.JavaScript(500);

// Generating PDF from HTML
var chartPdf = chartRenderer.RenderHtmlAsPdf(htmlCode);

// Saving the PDF file
chartPdf.SaveAs("d3ChartOutput.pdf");
```

### Final PDF Display

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/renderChart.pdf#zoom=85%" width="100%" height="400px">
</iframe>

For detailed information on `WaitFor` options like those for fonts and HTML elements, see '[How to Use the WaitFor Class for Delayed PDF Rendering in C#](https://ironpdf.com/how-to/waitfor/).'

---

## Angular JS for PDF Conversion in Web Applications

According to Wikipedia, *AngularJS is a robust, open-source web framework maintained by Google and a community of developers. It is designed to ease the development and testing of single-page applications by providing client-side MVC and MVVM architectures to enhance rich Internet applications*.

When using AngularJS, consider leveraging Server-side Rendering (SSR) with Angular Universal for better compatibility, as it ensures faster load times by generating static versions of the content that are later enhanced dynamically.