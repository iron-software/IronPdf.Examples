# Utilizing the WaitFor Class to Optimize PDF Rendering in C#

***Based on <https://ironpdf.com/how-to/waitfor/>***


When converting HTML content to PDFs in C#, developers often encounter an issue where the rendering starts before all JavaScript assets and animations are fully loaded, leading to incomplete or incorrect renderings. Initially, the workaround involved setting an arbitrary delay, but this method proved unreliable and inefficient.

As a more reliable solution, Iron Software introduced the **WaitFor** class within **RenderOptions**. This class provides various strategies to manage rendering timing more effectively, including:
- [Immediate page-load rendering](#anchor-default-immediate-render-example) (the default behavior).
- [Custom delays](#anchor-custom-render-delay-example) for rendering after a specified number of milliseconds.
- [Font load completions](#anchor-all-fonts-loaded-example), ensuring all fonts are loaded before rendering.
- [Execution of custom JavaScript](#anchor-custom-javascript-execution-example) prior to rendering.
- [Presence of specific HTML elements](#anchor-html-elements-example) before starting the rendering.
- [Waiting for network idleness](#anchor-network-idle-example) to ensure all resources are fetched.

These features facilitate the conversion process in various contexts, such as converting [HTML strings](https://ironpdf.com/how-to/html-string-to-pdf/), [HTML files](https://ironpdf.com/how-to/html-file-to-pdf/), and [web pages](https://ironpdf.com/how-to/url-to-pdf/) into PDFs. Let's delve deeper into how these capabilities can be harnessed.

## Exploration into IronPDF Capabilities

### Immediate Render Option

By default, the PDF rendering starts as soon as the page finishes loading, without any extra method calls:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Initiates rendering immediately after page load
renderer.RenderingOptions.WaitFor.PageLoad();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
```

### Implementing a Render Delay

For scenarios requiring a specific rendering delay, this method allows setting a delay in milliseconds to meet precise timing needs:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Delays rendering by 3000 milliseconds
renderer.RenderingOptions.WaitFor.RenderDelay(3000);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
```

### Ensuring All Fonts Are Loaded

This option pauses the rendering until all external fonts have been loaded, ensuring the PDF reflects the intended typographic styling:

```cs
using IronPdf;

// HTML content with external fonts
string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Font Loading Test</title>

  <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
  <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
  <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap"" >

  <style>
  /* Custom and remote fonts */
  @font-face {
    font-family: 'CustomFont';
    src: url('https://example.com/fonts/customfont.ttf');
  }
  p#p1 { font-family: CustomFont, sans-serif; }
  </style>
</head>
<body>
	<h1>Font Test</h1>
	<p style=""font-family: Roboto, monospace;"">Custom font example.</p>
	<p id=""p1"">Another custom font example.</p>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.AllFontsLoaded(10000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
```

### Custom JavaScript Execution Before Rendering

This feature allows the execution of a specific JavaScript function before starting the PDF rendering, giving control over the rendering initiation:

```cs
using IronPdf;

string html = @"
<!DOCTYPE html>
<html>
<body>
<h1>JavaScript Control Example</h1>
<script type='text/javascript'>

// Trigger after a custom delay
setTimeout(function() {
    window.ironpdf.notifyRender();
}, 1000);

</script>
</body>
</html>";

ChromePdfRenderOptions renderingOptions = new ChromePdfRenderOptions();

// Waits for 'notifyRender' JavaScript function trigger
renderingOptions.WaitFor.JavaScript(5000);

PdfDocument pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(html, renderingOptions);
```

### Rendering After HTML Element is Available

This method ensures the rendering doesn't start until specific HTML elements are completely available on the DOM:

#### Wait for Element by ID

```cs
using IronPdf;

string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Element Availability Test</title>
  <script type=""text/javascript"">
  setTimeout(function() {
    var h1Tag = document.createElement(""h1"");
    h1Tag.innerHTML = ""Element Ready"";
    h1Tag.setAttribute(""id"", ""readyTag"");
    document.body.appendChild(h1Tag);
  }, 1000);
  </script>
</head>
<body>
	<h1>Initial Content</h1>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.HtmlElementById("readyTag", 5000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
```

### Network Conditions for Rendering

#### No Network Activity

This condition ensures the rendering starts only when there's no network activity for a specified duration, ideal for static content pages:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Wait for no network activity
renderer.RenderingOptions.WaitFor.NetworkIdle0();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Static Page Test</h1>");
```

#### Managed Network Activity

For environments with manageable network traffic, such as few long-polling requests:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Allows up to two network activities
renderer.RenderingOptions.WaitFor.NetworkIdle2();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Dynamic Page Test</h1>");
```

### Customizing Network Activity Waiting

For complex scenarios involving multiple network activities, you can define custom parameters for network idle conditions ensuring a versatile setup:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Custom network idle setup
renderer.RenderingOptions.WaitFor.NetworkIdle(1000, 5);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Complex Setup Test</h1>");
```

### Setting a Maximum Wait Time

The `JavaScript`, `NetworkIdle`, and related methods also support setting a maximum waiting time to prevent indefinite waiting, with all timings in milliseconds.