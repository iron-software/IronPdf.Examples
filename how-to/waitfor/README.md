# Utilizing the WaitFor Class for Enhanced PDF Rendering in C#

In the process of generating PDF documents, developers often encounter a scenario where the rendering initiates too early, resulting in PDFs that do not fully capture all dynamic content like animations or JavaScript-driven elements. Previously, one might have used a fixed delay to partially solve this, but this approach was neither consistent nor optimal.

To address this more effectively, we've introduced the **WaitFor** class within the **RenderOptions** namespace to provide a range of conditions developers can wait for before rendering a PDF document. This class supports various synchronization strategies including:
- [PageLoad: Immediate rendering without any wait](#anchor-default-immediate-render-example).
- [RenderDelay: Introduces a custom delay before rendering](#anchor-custom-render-delay-example).
- [Fonts: Ensures all fonts are loaded before rendering](#anchor-all-fonts-loaded-example).
- [JavaScript: Utilizes a custom JavaScript function to decide the rendering start](#anchor-custom-javascript-execution-example).
- [HTML elements: Waits for specific HTML elements to be present](#anchor-html-elements-example).
- [NetworkIdle: Waits for periods of no network activity](#anchor-network-idle-example).

These versatile options are applicable across diverse scenarios including converting [HTML strings](https://ironpdf.com/how-to/html-string-to-pdf/), [files](https://ironpdf.com/how-to/html-file-to-pdf/), and [web URLs](https://ironpdf.com/how-to/url-to-pdf/) into PDFs. Let's delve into how each feature can be employed.

## Immediate Rendering on Page Load

By setting the rendering to occur immediately after page load, the `PageLoad` method ensures prompt action without explicit invocation.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Initialize rendering immediately after page load
renderer.RenderingOptions.WaitFor.PageLoad();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
```

## Implementing a Custom Rendering Delay

For precise control over rendering timing, setting a custom delay method offers the flexibility to manage when the rendering happens, which is useful in cases requiring synchronization.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set a specific rendering delay
renderer.RenderingOptions.WaitFor.RenderDelay(3000);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
```

## Ensuring All Fonts Are Loaded

The `AllFontsLoaded` method pauses the PDF creation process until all external and internal fonts are fully loaded, thus maintaining the integrity and style of the original content.

```cs
using IronPdf;

string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Test Registration of Extension</title>
  
  <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
  <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
  <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap"" >
  
  <style>
  /* for remote fonts */
  @font-face {
    font-family: 'CustomFont';
    src: url('https://stage.gradfinale.co.uk/tcpdf/fonts/avgr65wttf.ttf');
  }
  /* Local and remote font demonstration */
  p#p1, p#p3 { font-family: CustomFont, Roboto, sans-serif; }
  </style>
</head>
<body>
  <h1>This is Delayed Render Test!</h1>
  <p id=""p1"">Functional delay demonstrating font loading.</p>
  <p id=""p3"">Ensuring consistency in document appearance.</p>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.AllFontsLoaded(10000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
```

## Advanced Rendering with JavaScript Execution

For environments where the rendering depends on the execution of specific JavaScript code, this functionality allows for a dynamic initiation of the PDF rendering.

```cs
using IronPdf;

string html = @"<!DOCTYPE html>
<html>
<body>
<h1>Interactive Rendering Test</h1>
<script type='text/javascript'>
// Prepare and trigger rendering after custom actions
setTimeout(function() {
    window.ironpdf.notifyRender();
}, 1000);
</script>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.JavaScript(5000);

PdfDocument pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(html, renderer.RenderingOptions);
```

## HTML Element Specific Delay

To synchronize the rendering process with the availability of specific HTML elements:

### Waiting for an Element by ID

```cs
using IronPdf;

string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Element Specific Render Test</title>
  <script type=""text/javascript"">
    setTimeout(function() {
        var h1Tag = document.createElement(""h1"");
        h1Tag.innerHTML = ""Dynamic Content Ready"";
        h1Tag.setAttribute(""id"", ""uniqueContent"");
        
        document.body.appendChild(h1Tag);
    }, 1000);
  </script>
</head>
<body>
  <h1>Initial Content</h1>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.HtmlElementById("uniqueContent", 5000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
```

### Waiting for an Element by Name, Tag, or Custom Selector

Similarly, rendering can be configured to wait for elements identified by name, tag, or custom selectors, with the configuration tailored to specific requirements such as tag names or complex CSS queries.

## Managing Network Idle States for Rendering

Whether adapting to single-page applications or handling multiple network activities, the `NetworkIdle` family of methods provides structured options to manage network-related delays efficiently.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure rendering based on network activity
renderer.RenderingOptions.WaitFor.NetworkIdle(1000, 5);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Network Sync Test</h1>");
```

Lastly, these synchronization options also include mechanisms to set a maximum waiting time across methods, ensuring that wait conditions are realistically bound and do not cause indefinite delays.