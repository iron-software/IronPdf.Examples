# Chrome PDF Rendering Engine

***Based on <https://ironpdf.com/how-to/ironpdf-2021-chrome-rendering-engine-eap/>***


Leverage the exceptional PDF rendering capabilities of the Chrome engine!

[Chromium](https://www.chromium.org/chromium-projects/) is an open-source project from Google that forms the backbone of many widely used web browsers, such as Google Chrome, Microsoft Edge, and Opera.

## Enhancements and Reliable Testing

### Premium Rendering Quality

Utilize the latest "Blink!" HTML rendering technology. Opt between traditional Chrome-like rendering or the Enhanced Rendering option, which proves to be more precise and simpler for programming.

### Enhanced Rendering Speed

Achieve up to 20% faster rendering with seamless multithreading and asynchronous execution across multiple CPU cores. Ideal for SAAS and high-demand applications where speeds can be up to 5-20 times faster than conventional browser and driver methods.

### Comprehensive Support

Full-fledged support for technologies like **JavaScript**, **responsive design**, and **CSS3** is guaranteed.**Azure** integration is seamless and robust.
Ongoing updates and extensive support for .NET versions from 8 downwards to Framework 4.6.2+ are assured.

### Thorough Testing

Verified with **1156 successful unit and integration tests**, these early access builds are considered as stable as our mainline releases, backed by constant enhancements from our dedicated developers.

### Compliance with Section 508

Generate PDFs that adhere to the PDF(UA) tagged standard, ensuring accessibility.

### Continuous Enhancements

Your feedback is invaluable. Reach out to us at [sales@ironsoftware.com](mailto:support@ironsoftware.com) with any suggestions or if you need assistance setting things up.

---

### Implement in Your Project

## 1. Install IronPDF

Begin by adding IronPDF to your project using the NuGet Package Manager under the `IronPdf` package.

```shell
/Install-Package IronPdf
```

---

## 2. Explore the Enhanced API

The beloved C# and VB.NET API you rely on remains intact and is now complimented by an enhanced version for greater control, featuring specific RenderingOptions and HttpLoginCredentials for your renderer.

```cs
using IronPdf;

// Initialize the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure rendering preferences
renderer.RenderingOptions.PaperFit.UseFitToPageRendering();
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Execute rendering to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello world!</h1>");
// Additional rendering from URL and HTML file
// PdfDocument pdf = Renderer.RenderUrlAsPdf("https://www.google.com/");
// PdfDocument pdf = Renderer.RenderHtmlFileAsPdf("example.html");
pdf.SaveAs("rendered_pdf_from_chrome.pdf");
```

## 3. Achieve Pixel-Perfect Chrome Rendering

Produce PDFs that perfectly mirror the Chrome desktop browser's "print to PDF" output.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
renderer.RenderingOptions.PrintHtmlBackgrounds = false;
renderer.RenderingOptions.CreatePdfFormsFromHtml = false;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
```

### Recommended Practices

We suggest implementing Iron-specific enhancements for optimal results:
* Employ screen stylesheets for [printing PDFs](https://ironpdf.com/how-to/csharp-print-pdf/).
* Support for responsive layouts.
* Conversion of HTML forms into PDF forms.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderingOptions.ViewPortWidth = 1080;  // Set viewport width in pixels

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
```

## 4. Advanced Multithreading and Async Capabilities

Experience unparalleled multithreading and asynchronous functionality with our Chrome renderer:
* Implement robust multithreading in your existing framework.
* Utilize .NET's `Parallel.ForEach` for efficiently processing multiple HTML documents to PDF.
* Take full advantage of asynchronous methods like `ChromePdfRenderer.RenderHtmlAsPdfAsync`.

---

## 5. What’s Next?

### Future Features

* Lightweight deployment models perfect for *Azure Functions* and *AWS Lambda*.
* Rendering support tailored for mobile developers on iOS and Android.
* Alternative rendering solutions for browsers like IE and Firefox.
* Scalable multi-server architectures for major enterprise setups.
* Advanced internal PDF document model to support a broad spectrum of PDF benchmarks and repair damaged PDFs effectively.
* Add your feature requests or report issues; customer input is prioritized.

Please [Contact Us for Further Queries](#live-chat-support) if you have any suggestions or questions.