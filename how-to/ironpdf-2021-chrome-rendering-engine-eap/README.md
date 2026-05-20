# Chrome PDF Rendering Engine

***Based on <https://ironpdf.com/how-to/ironpdf-2021-chrome-rendering-engine-eap/>***


Utilize the Chrome PDF-rendering engine to produce high-quality PDFs!

[Chromium](https://www.chromium.org/chromium-projects/) is an open-source web browser project led by Google. It underpins many well-known browsers including Google Chrome, Microsoft Edge, Opera, among others.

## Quickstart: Render HTML to PDF with IronPDF in Seconds

Start using IronPDF's Chrome rendering engine today to transform HTML into premium PDFs effortlessly. This guide walks through the simple process of converting HTML to PDF using IronPDF, emphasizing user-friendliness and quick integration for developers at any level. IronPDF provides a robust toolset that integrates flawlessly with your .NET projects, ensuring a strong and efficient solution for contemporary web and application development.

```cs
// Convert HTML to a high-quality PDF document
var pdf = IronPdf.ChromePdfRenderer.RenderHtmlAsPdf("<h1>Hello, World!</h1>");
```



## High-Quality Improvements, Well Tested

### High-Quality Rendering

Benefit from the latest advancements in the “Blink!” HTML rendering engine. Choose between <b>Chrome Identical rendering</b> and Enhanced Rendering—for more precise and easier coding.

### 20% Faster Renders

Enjoy improved multi-threading capabilities and asynchronous operations, utilizing multiple CPU cores. This offers a performance acceleration of <b>5-20 times</b> compared to conventional browsers and web-drivers for SAAS and high-load scenarios.

### Full Support

Comprehensive support for <b>JavaScript</b>, <b>responsive</b> designs, and <b>CSS3</b>.<br>
<b>Azure</b> integration is seamless and reliable.<br>
Continually upgraded for compatibility with .NET 8, 7, 6, 5, Core, and Framework 4.6.2+.

### Rigorously Tested

With <b>1156 green unit & integration tests</b> all passing, this early access program version is robust and is being enhanced daily.

### Section 508 Accessibility Compliance

Constructed to produce accessible PDFs following the PDF(UA) tagged PDF standard.

### Ongoing Improvements

Your opinions matter to us. Please contact <a href="mailto:support@ironsoftware.com">support@ironsoftware.com</a> to share feedback or for assistance in setting up.

<hr class="separator">

<h4 class="tutorial-segment-title">Implement in Your Project</h4>

## 1. Install IronPDF

Begin by installing IronPDF in your project using the NuGet Package Manager under the name `IronPdf`.

```shell
# Install IronPDF using the NuGet CLI or through your IDE’s Package Manager

***Based on <https://ironpdf.com/how-to/ironpdf-2021-chrome-rendering-engine-eap/>***

nuget install IronPdf
```

<hr class="separator">

## 2. Try the new API  

The existing IronPDF C# and VB.NET API remains untouched and operational. However, we are introducing a new, more advanced API for better control.

```csharp
// New API setup example with RenderingOptions and HttpLoginCredentials
var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.CssMediaType.Screen;
// Configure HTTP authentication credentials as needed
renderer.RenderingOptions.HttpLoginCredentials.Username = "yourUsername";
renderer.RenderingOptions.HttpLoginCredentials.Password = "yourPassword";
```

## 3. Apply Pixel-Perfect Chrome Rendering

Produce PDFs that are an exact match to the Chrome desktop browser’s “print to PDF” function.

```csharp
// Render a perfect PDF from HTML content
var renderer = new IronPdf.ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
pdf.SaveAs("HelloWorld.pdf");
```

### Recommended Improvements

Suggestions from Iron to enhance your PDFs:
* Utilize screen stylesheets when [printing PDFs](https://ironpdf.com/how-to/print-pdf/). This leads to less development hassle and retains fidelity to your web assets.
* Engage responsive layouts.
* Convert HTML form elements into PDF forms.

```csharp
// Example showcasing responsive layouts and other recommendations
...
```

## 4. Multi-threading and Async Support

Our Chrome rendering engine offers superior multi-threading and asynchronous performance.

* Effortlessly integrate `ChromePdfRenderer` into your existing threads for exceptional enterprise-level multithreading.
* For batch HTML-to-PDF conversion, employ .NET’s `Parallel.ForEach` methodology.
* Enjoy the benefits of `async` with all our rendering methods, like `ChromePdfRenderer.RenderHtmlAsPdfAsync`.

```csharp
// Asynchronous PDF rendering example
var renderer = new IronPdf.ChromePdfRenderer();
var task = await renderer.RenderHtmlAsPdfAsync("<h1>Async PDF</h1>");
task.SaveAs("AsyncHelloWorld.pdf");
```

<hr class="separator">

## 5. What is next?

### Features Coming Soon

* Ultra-Slim deployments for *Azure functions* and *AWS Lambda*.
* Mobile rendering support for iOS and Android.
* Additional browser rendering options: IE and Firefox.
* Multi-server distributed rendering for large enterprises.
* Enhanced internal PDF document object model to handle the broadest range of PDF standards more effectively.
* We prioritize customer-suggested feature requests and bug reports.

Please [Contact Us for Further Queries](#live-chat-support) with any ideas or queries you may have.