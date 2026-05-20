# Utilizing the WaitFor Class to Enhance C# PDF Rendering

***Based on <https://ironpdf.com/how-to/waitfor/>***


In the process of generating PDFs, it's quite common to encounter challenges where the PDF is rendered before JavaScript assets or animations have fully loaded. This premature rendering can lead to inaccuracies in the final document. Initially, we recommended inserting a manual delay to mitigate this issue, but this method proved to be unreliable and inefficient.

## Quickstart: Leveraging WaitFor to Improve PDF Rendering

The WaitFor functionality in IronPDF provides developers with the tools to finely control the timing of PDF rendering. This ensures that all necessary resources are fully loaded before the document is rendered, which helps in avoiding incomplete renderings. This guide demonstrates how to integrate the WaitFor feature into your projects to achieve precise and optimized PDF rendering.

```cs
// Setting a delay in rendering until all content is fully prepared
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderingOptions.WaitFor = IronPdf.Rendering.WaitOptions.RenderDelay(3000);
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://example.com");
pdfDocument.SaveAs("output.pdf");
```

## Overview of the WaitFor Class

The introduction of the `WaitFor` class in IronPDF offers a robust solution to enhance PDF rendering, adjusting to various scenarios:

- `PageLoad`: Renders immediately upon page load, without any delay.
- `RenderDelay`: Allows setting a custom delay in milliseconds before rendering.
- `Fonts`: Ensures all fonts are loaded prior to rendering.
- `JavaScript`: Delays rendering until a specific JavaScript function is called.
- `HTML elements`: Pauses rendering until specified HTML elements are present.
- `NetworkIdle`: Waits for a period of network inactivity before rendering.

These capabilities are instrumental when working on projects that convert HTML to PDF, whether from strings, files, or URLs. Detailed coverage of these features is found in our documentation for [HTML strings to PDF](https://ironpdf.com/how-to/html-string-to-pdf/), [HTML files to PDF](https://ironpdf.com/how-to/html-file-to-pdf/), and [web URLs to PDF](https://ironpdf.com/how-to/url-to-pdf/).

## Default Immediate Rendering Example

By standard, PDF rendering is initiated immediately after the webpage has loaded, as shown in this straightforward example:

```cs
using IronPdf;

var pdfRenderer = new ChromePdfRenderer();

// Immediately render HTML content as PDF upon page load
pdfRenderer.RenderingOptions.WaitFor.PageLoad();
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Live rendering</h1>");
```

## Custom Render Delay Example

If your rendering requires a specific delay, it can be customized with the `RenderDelay` method, which improves on the previously deprecated property for setting delays:

```cs
using IronPdf;

var pdfRenderer = new ChromePdfRenderer();

// Introduce a 3000ms delay before rendering
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(3000);
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Delayed rendering</h1>");
```

## Waiting for All Fonts to Load Example

The `AllFontsLoaded` feature provides a delay until external fonts, such as those hosted on Google Fonts, are completely loaded, ensuring textual accuracy and visual fidelity in your PDF:

```cs
using IronPdf;

var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.WaitFor.AllFontsLoaded(10000);
var pdfContent = @"
<!DOCTYPE html>
<html lang=""en"">
...
```

## Executing Custom JavaScript Example

This method allows executing a custom JavaScript before the PDF rendering starts, offering precise control over the rendering timing via JavaScript:

```cs
using IronPdf;

var html = @"
<!DOCTYPE html>
<html>
<body>
...
```

## HTML Element Specific Waiting Examples

These examples demonstrate how the rendering can be delayed until specific HTML elements are detected, either by ID, name, tag, or custom query selectors:

### Wait for Element ID Example

```cs
using IronPdf;

var htmlContent = @"
<!DOCTYPE html>
...
```

### Wait for Element Name Example

```cs
using IronPdf;

var namedHtmlContent = @"
<!DOCTYPE html>
...
```

### Wait for Element Tag Name Example

```cs
using IronPdf;

var tagNamedHtmlContent = @"
<!DOCTYPE html>
...
```

### Query Selector Usage Example

```cs
using IronPdf;

var queriedHtmlContent = @"
<!DOCTYPE html>
...
```

## Network Idle Management Examples

These examples showcase different scenarios of waiting based on network activity, ranging from no ongoing network activity to allowing up to two network pulses:

### No Network Activity

```cs
using IronPdf;

var pdfRenderer = new ChromePdfRenderer();

// Waits until there are no network activities for at least 500ms before rendering
pdfRenderer.RenderingOptions.WaitFor.NetworkIdle0();
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>test content</h1>");
```

### Limited Network Activities

```cs
using IronPdf;

// Allows up to two network activities before rendering
pdfRenderer.RenderingOptions.WaitFor.NetworkIdle2();
var testPdf = pdfRenderer.RenderHtmlAsPdf("<h1>test scenario</h1>");
```

### Custom Network Activity Configuration

```cs
using IronPdf;

// Custom configuration for network idle conditions before rendering
pdfRenderer.RenderingOptions.WaitFor.NetworkIdle(1000, 5);
var configuredPdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>configured test</h1>");
```

## Setting Maximum Wait Duration

The methods like `JavaScript`, `NetworkIdle`, among others, also support setting a maximum waiting time, ensuring that the rendering process does not wait indefinitely.

For further exploration, check out our comprehensive guide here: [Additional Features](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/).