# Chrome PDF Rendering Engine

Leverage the power of Chrome's PDF-rendering capabilities to produce top-quality PDFs!

[Chromium](https://www.chromium.org/chromium-projects/) is an open-source browser initiative led by Google, which is the core from which popular browsers like Google Chrome, Microsoft Edge, and Opera are derived.






## Enhanced High-Quality Features, Thoroughly Tested ##

### Premium Rendering Quality ###

Experience the latest in “Blink” HTML rendering technology. Opt between classic Chrome rendering and our enhanced mode, which is often more precise and simpler to work with than Chrome's standard rendering.

### Accelerated PDF Generation ###

Enable effective multithreading and asynchronous processing, utilizing as many CPU cores as necessary. Especially useful for SAAS and high-demand environments, it can be **5-20 times quicker**, surpassing traditional browser and web-driver approaches.

### Comprehensive Support ###

Comprehensive support for **JavaScript**, **responsive** design, and **CSS3**.<br>
**Azure** integration is seamless and fully supported.<br>
Ongoing upgrades and continuous support for .NET 8, 7, 6, 5, Core, and Framework versions starting from 4.6.2+.

### Rigorous Testing ###

Our release has completed **1156 green unit and integration tests** with zero failures. We regard this EAP version as stable as our main release, continuously enhanced by our top engineers.

### Compliance with Section 508 Accessibility ###

Generates accessible PDFs adhering to the PDF(UA) tagged PDF standards.

### Continuous Enhancements ###

We value your input. Please contact <a href="mailto:support@ironsoftware.com">sales@ironsoftware.com</a> with your suggestions or assistance requests.

<hr class="separator">

<h4 class="tutorial-segment-title">Incorporate in Your Project</h4>

## 1. Install IronPDF

Begin by integrating IronPDF into your project via the NuGet Package Manager under the name `IronPdf`.

```shell
Install-Package IronPdf
```

<hr class="separator">

## 2. Explore the Enhanced API  

While the existing IronPDF C# and VB.NET APIs remain unchanged, we are introducing a superior method that offers increased flexibility.

For instance, you can now utilize specialized RenderingOptions and HttpLoginCredentials tailored for your rendering process.

```cs
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set rendering options
renderer.RenderingOptions.PaperFit.UseFitToPageRendering();
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Generate the PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello world!</h1>");
pdf.SaveAs("google_chrome.pdf");
```

## 3. Achieve Pixel-Perfect Chrome Rendering

This guide illustrates how to achieve pixel-perfect replication of Chrome's desktop "print to PDF" functionality.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
renderer.RenderingOptions.PrintHtmlBackgrounds = false;
renderer.RenderingOptions.CreatePdfFormsFromHtml = false;

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
```

### Enhanced Techniques ###

Explore these Iron-specific enhancements for optimal results:
* Employ screen stylesheets to [print PDFs](https://ironpdf.com/how-to/csharp-print-pdf/).
* Support for responsive designs.
* Ability to create PDF forms directly from your HTML.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderingOptions.ViewPortWidth = 1080;  // Set viewport width

PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
```

## 4. Advanced Multithreading and Async Support

Our Chrome rendering engine offers superior multithreading and async capabilities.

* Integrate *ChromePdfRenderer* seamlessly into your existing threads for server-grade performance. Web applications require almost no additional setup.
* For bulk HTML to PDF conversions, the .NET *Parallel.ForEach* pattern is highly recommended.
* All our rendering functions include async versions, like `ChromePdfRenderer.RenderHtmlAsPdfAsync`.

<hr class="separator">

## 5. What's Coming Next?

### Upcoming Features

* Streamlined deployments optimal for *Azure functions* and *AWS Lambda* to minimize disk usage.
* Support for mobile app development on iOS and Android.
* Additional browser rendering options including IE and Firefox.
* Distributed rendering solutions for large enterprises.
* A revamped internal PDF document model that supports a wide array of PDF standards and handles malformed PDFs more gracefully.
* Feature suggestions and bug reports from our customers get priority attention.

Please <a href="#live-chat-support">contact us</a> with your ideas or inquiries.