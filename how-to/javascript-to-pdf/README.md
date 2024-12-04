# Utilizing JavaScript in HTML to PDF Conversions

***Based on <https://ironpdf.com/how-to/javascript-to-pdf/>***


JavaScript, a versatile and high-level programming language, is indispensable in web development for enhancing website interactivity and dynamics. Similarly, jQuery, a library built on JavaScript, aids developers by simplifying frequent web tasks such as DOM manipulation, event handling, and AJAX calls.

IronPDF leverages the [Chromium](https://www.chromium.org/chromium-projects/) engine to support JavaScript effectively. This article provides an overview of implementing JavaScript and jQuery in the process of converting HTML to PDF within .NET C# projects. You can begin experimenting with IronPDF by accessing the [free trial of IronPDF](https://ironpdf.com/tutorials/html-to-pdf/).

## JavaScript Rendering Example

When transforming HTML with JavaScript into PDF, it is essential to accommodate JavaScript execution within the rendering process. To ensure smooth JavaScript execution, utilize the [WaitFor class in rendering options](https://ironpdf.com/how-to/waitfor/) and set an appropriate waiting period. Below is an illustrative code snippet that employs `WaitFor.JavaScript` with a maximum delay of 500 milliseconds.

```cs
using IronPdf;
namespace ironpdf.JavascriptToPdf
{
    public class Section1
    {
        public void Run()
        {
            string htmlWithJavaScript = @"<h1>This is HTML</h1>
            <script>
                document.write('<h1>This is JavaScript</h1>');
                window.ironpdf.notifyRender();
            </script>";
            
            // Create a new PDF renderer
            var renderer = new ChromePdfRenderer();
            
            // Enable JavaScript in the renderer options
            renderer.RenderingOptions.EnableJavaScript = true;
            // Configure JavaScript execution wait time
            renderer.RenderingOptions.WaitFor.JavaScript(500);
            
            // Convert HTML with JavaScript to PDF
            var pdfDocument = renderer.RenderHtmlAsPdf(htmlWithJavaScript);
            
            // Save the PDF to a file
            pdfDocument.SaveAs("javascriptHtml.pdf");
        }
    }
}
```

Integrating complex JavaScript frameworks may present challenges, mostly due to memory allocation constraints during JavaScript execution.

## Implementing Custom JavaScript Execution

To execute custom JavaScript prior to rendering the HTML to PDF, use the `JavaScript` property available in rendering options. This feature is particularly useful for URL-based HTML where direct JavaScript injections are impractical. Below is an example demonstrating how to manipulate HTML elements using custom JavaScript before conversion.

```cs
using IronPdf;
namespace ironpdf.JavascriptToPdf
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Setting custom JavaScript
            renderer.RenderingOptions.Javascript = @"
            document.querySelectorAll('h1').forEach(function(el){
                el.style.color='red';
            })";
            
            // Convert HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Happy New Year!</h1>");
            
            pdf.SaveAs("executed_js.pdf");
        }
    }
}
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/executeJavascript.pdf" width="100%" height="400px">
</iframe>

## JavaScript Message Listener in Action

IronPDF facilitates listening to JavaScript messages, whether they are errors or custom log messages. This functionality is demonstrated in the code snippet below, which captures and logs JavaScript console messages.

```cs
using System;
using IronPdf;
namespace ironpdf.JavascriptToPdf
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Setup listener for JavaScript messages
            renderer.RenderingOptions.JavascriptMessageListener = message => Console.WriteLine($"JS: {message}");
            // Output custom text to console
            renderer.RenderingOptions.Javascript = "console.log('foo');";
            
            // Generate PDF from HTML
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1> Hello World </h1>");
            
            //--------------------------------------------------//
            // Attempt to modify non-existent element
            renderer.RenderingOptions.Javascript = "document.querySelector('non-existent').style.color='foo';";
            
            // Attempt to generate another PDF
            PdfDocument anotherPdf = renderer.RenderHtmlAsPdf("<h1> Hello World </h1>");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/console.webp" alt="Console window" class="img-responsive add-shadow">
    </div>
</div>

## Chart Creation with JavaScript and IronPDF

[D3.js](https://d3js.org/), a JavaScript library known for its powerful data visualization capabilities, integrates seamlessly with IronPDF for generating dynamic charts. The following code snippet illustrates how to create a bar chart using D3.js and convert it into a PDF document.

```cs
using IronPdf;
namespace ironpdf.JavascriptToPdf
{
    public class Section4
    {
        public void Run()
        {
            string html = @"
            <!DOCTYPE html>
            <html>
            <head>
            <meta charset=""utf-8"" />
            <title>C3 Bar Chart</title>
            </head>
            <body>
            <div id=""chart"" style=""width: 950px;""></div>
            <script src=""https://d3js.org/d3.v4.js""></script>
            
            <link href=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.css"" rel=""stylesheet"">
            
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/c3/0.5.4/c3.js""></script>
            
            <script>
            Function.prototype.bind = Function.prototype.bind || function (thisp) {
                var fn = this;
                return function () {
                    return fn.apply(thisp, arguments);
                };
            };
            var chart = c3.generate({
                bindto: '#chart',
                data: {
                    columns: [['data1', 30, 200, 100, 400, 150, 250],
                              ['data2', 50, 20, 10, 40, 15, 25]]
                }
            });
            </script>
            </body>
            </html>
            ";
            
            // Configure the renderer
            var renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.EnableJavaScript = true;
            renderer.RenderingOptions.WaitFor.JavaScript(500);
            
            var pdf = renderer.RenderHtmlAsPdf(html);
            
            pdf.SaveAs("renderChart.pdf");
        }
    }
}
```

### Chart Output in PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/javascript-to-pdf/renderChart.pdf#zoom=85%" width="100%" height="400px">
</iframe>

For further options and details on managing rendering delays in C# PDF generation, explore '[How to Use the WaitFor Class to Delay C# PDF Rendering](https://ironpdf.com/how-to/waitfor/)'.

*****

## AngularJS: Client-Side to Server-Side Rendering

AngularJS, as defined by Wikipedia, is a JavaScript-based open-source framework designed to simplify the creation and testing of single-page applications, supported primarily by Google and a community of developers. Despite its capabilities, Angular should be employed meticulously, preferably with server-side rendering (SSR) using Angular Universal for the best compatibility.

*****

## Implementing SSR with Angular Universal

**Difference between Angular and Angular Universal:**

Regul...