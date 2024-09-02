# Utilizing JavaScript in HTML to PDF Conversion

JavaScript, recognized for its pivotal role in enhancing web interactivity, is a high-level, multi-purpose programming language. It is primarily utilized in web development to add dynamic and interactive elements to web pages. jQuery, while often mistaken for a separate language, is actually a library built on JavaScript. Designed to streamline tasks such as DOM manipulation, event handling, and AJAX, jQuery simplifies many of JavaScript's common yet complex tasks.

IronPDF leverages the robust [Chromium](https://www.chromium.org/chromium-projects/) rendering engine to effectively support JavaScript. In this guide, we explore how to integrate JavaScript and jQuery into your .NET C# projects for HTML to PDF conversions, and you can start doing this with IronPDF’s [free trial](https://ironpdf.com/?class='js-modal-open'&data-modal-id='trial-license').


## Rendering HTML with JavaScript

When converting HTML with JavaScript into PDFs, it's important to enable proper rendering of the JavaScript. IronPDF accommodates this seamlessly. However, to ensure that JavaScript executes correctly without timing out, it's advisable to employ the [Waitfor](https://ironpdf.com/how-to/waitfor/) class within the `RenderingOptions`. Here's an example setting a maximal wait time of 500 ms using the `WaitFor.Javascript` method:

```cs
using IronPdf;

string htmlContent = @"<h1>HTML Content</h1>
<script>
    document.write('<h2>Dynamic JavaScript Content</h2>');
    window.ironpdf.notifyRender();
</script>";

// Initialize the Chrome PDF renderer
var pdfRenderer = new ChromePdfRenderer();

// Enabling JavaScript
pdfRenderer.RenderingOptions.EnableJavaScript = true;

// Configuring the wait time for JavaScript execution
pdfRenderer.RenderingOptions.WaitFor.JavaScript(500);

// Converting HTML with JavaScript to PDF
var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent);

// Saving the PDF
pdfDocument.SaveAs("outputWithJavaScript.pdf");
```

It is worth noting that particularly complex JavaScript frameworks might not always fully cooperate with IronPDF due to the restricted memory allocation for JavaScript execution.

---

## Executing Custom JavaScript

Custom JavaScript execution is crucial, especially when converting HTML from URLs. IronPDF facilitates this through the `JavaScript` property in rendering options, allowing you to pre-execute custom scripts. Here is an example:

```cs
using IronPdf;

var customScriptRenderer = new ChromePdfRenderer();

// Assign custom JavaScript
customScriptRenderer.RenderingOptions.Javascript = @"
document.querySelectorAll('h1').forEach(element => element.style.color = 'blue');
";

// Convert HTML to PDF
PdfDocument customScriptPdf = customScriptRenderer.RenderHtmlAsPdf("<h1>Greetings!</h1>");

// Saving the PDF
customScriptPdf.SaveAs("customJavaScriptExecution.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/executeJavascript.pdf" width="100%" height="400px"></iframe>

---

## Tracking JavaScript Console Messages

IronPDF's capabilities extend to capturing JavaScript console logs, including error messages and custom logs. This functionality is managed using the `JavascriptMessageListener` property:

```cs
using IronPdf;
using System;

var logRenderer = new ChromePdfRenderer();

// Listen for console messages
logRenderer.RenderingOptions.JavascriptMessageListener = message => Console.WriteLine($"JS Log: {message}");
logRenderer.RenderingOptions.Javascript = "console.log('Sample log message');";

// Convert and log HTML to PDF
PdfDocument logPdf = logRenderer.RenderHtmlAsPdf("<h1>Demo Logging</h1>");

// Attempt to log a typical error
logRenderer.RenderingOptions.Javascript = "document.querySelector('missing-element').style.color = 'red';";

// PDF rendering
PdfDocument errorLogPdf = logRenderer.RenderHtmlAsPdf("<h1>Error Logging Demo</h1>");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/console.webp" alt="Console window" class="img-responsive add-shadow">
    </div>
</div>

---

## JavaScript Charting with D3.js and IronPDF

[D3.js](https://d3js.org/), renowned for its powerful data visualization capabilities, pairs excellently with IronPDF for creating dynamic charts or visual images. Here’s how you can employ D3.js for chart rendering, then convert it to PDF:

```cs
using IronPdf;

string htmlChart = @"
<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8' />
<title>D3 Chart Example</title>
</head>
<body>
<div id='chart' style='width: 950px;'></div>
<script src='https://d3js.org/d3.v4.js'></script>
<link href='https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.css' rel='stylesheet'>
<script src='https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.js'></script>

<script>
// Additional D3 setup for binding
Function.prototype.bind = Function.prototype.bind || function (context) {
    var func = this;
    return function () {
        return func.apply(context, arguments);
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

// Initialize Renderer for JavaScript
var chartRenderer = new ChromePdfRenderer();

// Enable and configure JavaScript
chartRenderer.RenderingOptions.EnableJavaScript = true;
chartRenderer.RenderingOptions.WaitFor.JavaScript(500);

// Convert the HTML with a D3 chart to a PDF
PdfDocument chartPdf = chartRenderer.RenderHtmlAsPdf(htmlChart);

// Save the PDF file
chartPdf.SaveAs("d3Chart.pdf");
```

### Displaying Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/renderChart.pdf#zoom=85%" width="100%" height="400px"></iframe>

Discover additional `WaitFor` configuration options, including those for fonts, JavaScript elements, and network conditions in the detailed guide at ['How to Use the WaitFor Class to Delay C# PDF Rendering'](https://ironpdf.com/how-to/waitfor/).

---

## Server-Side Rendering with Angular Universal

### Differentiating Angular and Angular Universal

Angular, as enunciated by [Wikipedia](https://en.wikipedia.org/wiki/AngularJS), is a JavaScript-based framework supported mainly by Google. It simplifies both development and testing of web applications by providing robust solutions for the MVC and MVVM architecture challenges.

Conversely, Angular Universal renders applications server-side, which shortens the time to a fully interactive state by initially showing a static version of the application. This approach is highly recommended for enhanced compatibility and performance.