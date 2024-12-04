# Chrome PDF Rendering Engine

***Based on <https://ironpdf.com/how-to/ironpdf-2021-chrome-rendering-engine-eap/>***


Leverage the power of Chrome's PDF-rendering engine to produce professional-quality PDF documents!

[Chromium](https://www.chromium.org/chromium-projects/) is the open-source browser project actively developed by Google, and it serves as the backbone for several leading web browsers including Google Chrome, Microsoft Edge, Opera, and more.

## Enhancements and Reliability

### High-Fidelity Rendering

Experience rendering with the latest “Blink!” HTML engine. Select between <b>Chrome Identical rendering</b> or Enhanced Rendering, with the latter often being more precise and simpler to develop with than Chrome’s own rendering.

### Accelerated Rendering Performance

Achieve efficient multithreading and asynchronous operations using as many CPU cores as needed. For SAAS platforms and high-demand applications, speeds can be <b>5-20 times faster</b>, surpassing traditional browser-based and webdriver methods.

### Comprehensive Support

Unmatched support for <b>JavaScript</b>, <b>responsive</b> designs, and <b>CSS3</b>.
<b>Azure</b> integration is seamless and hassle-free.
We ensure ongoing compatibility and enhancement for .NET 8, 7, 6, 5, Core, and Framework 4.6.2 and later.

### Thoroughly Tested

Our release has successfully passed <b>1156 green unit & integration tests</b> without any failures. This EAP version is considered stable and continuously improved by our dedicated team.

### Compliance with Section 508 Accessibility

Generate accessible PDFs conforming to the PDF(UA) tagged PDF standards.

### We Value Your Input

We're eager to receive your feedback. Please contact <a href="mailto:sales@ironsoftware.com">sales@ironsoftware.com</a> with your suggestions or for assistance.

<hr class="separator">

<h4 class="tutorial-segment-title">Implementation Steps</h4>

## 1. Install IronPDF

Begin by incorporating IronPDF into your project via the NuGet Package Manager with the package name `IronPdf`.

```shell
/Install-Package IronPdf
```

<hr class="separator">

## 2. Explore the New API  

The existing C# and VB.NET API you use will continue to be supported. However, we have introduced an improved API for better control and flexibility.

Engage new properties and methods tailored for your renderer.

```cs
using IronPdf;
namespace ironpdf.Ironpdf2021ChromeRenderingEngineEap
{
    public class Section1
    {
        public void Run()
        {
            // Initialize the Chrome renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure rendering preferences
            renderer.RenderingOptions.PaperFit.UseFitToPageRendering();
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            // Execute rendering of HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to the PDF World!</h1>");
            // Save the PDF file
            pdf.SaveAs("welcome_pdf.pdf");
        }
    }
}
```

## 3. Achieve Chrome-like Pixel-Perfect PDFs

Create PDFs that mimic the appearance of printouts from the latest Chrome desktop browser.

```cs
using IronPdf;
namespace ironpdf.Ironpdf2021ChromeRenderingEngineEap
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
            renderer.RenderingOptions.PrintHtmlBackgrounds = false;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = false;
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        }
    }
}
```

### Optimal Improvements

For optimal functionality:
* Utilize screen-specific stylesheets via <a href="https://ironpdf.com/how-to/csharp-print-pdf/">C# print PDF guide</a>.
* Support responsive layouts.
* Convert HTML forms into interactive PDF forms.

```cs
using IronPdf;
namespace ironpdf.Ironpdf2021ChromeRenderingEngineEap
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            renderer.RenderingOptions.ViewPortWidth = 1080;  //pixels
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.google.com/");
        }
    }
}
```

## 4. Multithreading and Asynchronous Processing

Our Chrome rendering engine offers superior multithreading and asynchronous capabilities compared to previous versions.

* Implement *ChromePdfRenderer* within your existing threads for robust enterprise multithreading.
* Employ .NET's *Parallel.ForEach* pattern for efficient HTML to PDF batch processing.
* Take advantage of asynchronous methods like `ChromePdfRenderer.RenderHtmlAsPdfAsync`.

<hr class="separator">

## 5. Looking Forward

### Anticipated Features

* Minimized footprints for *Azure functions* and *AWS Lambda* deployments.
* Rendering options tailored for mobile developers on iOS and Android.
* Support for IE and Firefox browsers.
* Scalable multi-server rendering solutions for large enterprises.
* Advanced handling and repairing of corrupted or poorly encoded PDFs.
* We prioritize your feature requests and bug resolutions.

For further discussion and inquiries, <a href="#live-chat-support">Contact Us</a> with any suggestions or questions.