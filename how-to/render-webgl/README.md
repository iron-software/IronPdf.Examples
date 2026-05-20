# Rendering WebGL Sites

***Based on <https://ironpdf.com/how-to/render-webgl/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/logos/webgl-logo.svg">
        </div>
    </div>
</div>

WebGL is instrumental in crafting interactive 3D graphics directly on web browsers. However, translating these dynamic, rich graphics into a static PDF format can pose some challenges. The process entails capturing the visual output from the WebGL context to be converted suitably into a PDF file.

IronPDF offers the necessary tools to capture and convert websites featuring WebGL content like [Mapbox](https://www.mapbox.com/) or the [WebGL Samples collection](https://webglsamples.org).

## Quickstart: Convert WebGL Content to PDF with .NET

Leverage IronPDF to transform interactive WebGL graphics into static PDF documents with ease in .NET C#. This guide aids you in setting up IronPDF for capturing and rendering WebGL site content efficiently. Ensure the GPU mode is set to Hardware and Single Process is enabled for best results. Below are the steps to initiate converting 3D web visuals into distributable PDF files.

```cs
:title=PDF Generation from WebGL Pages
IronPdf.Installation.SingleProcess = true;
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;

var pdfRenderer = new IronPdf.ChromePdfRenderer {
    RenderingOptions = {
        WaitFor = IronPdf.Rendering.WaitFor.RenderDelay(5000)
    }
};
pdfRenderer.RenderUrlAsPdf("https://example.com/webgl-demo").SaveAs("webgl-output.pdf");
```

## How to Render WebGL Websites with IronPDF

For effective WebGL rendering, configuring specific settings in IronPDF is essential:

- **SingleProcess = true**: This setting forces Chrome to manage all tasks within a single process instead of using multiple subprocesses.
- **ChromeGpuMode = Hardware**: Operate the GPU in Hardware mode for enhanced performance.

Should the website necessitate a rendering delay for optimum display, use the `WaitFor.RenderDelay` option. Below is an example where we render a [Mapbox GeoJSON Layer](https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/).

```csharp
using IronPdf;

// Configuration for IronPdf
IronPdf.Installation.SingleProcess = true;
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;

var pdfRenderer = new ChromePdfRenderer {
    RenderingOptions = {
        WaitFor = IronPdf.Rendering.WaitFor.RenderDelay(5000)
    }
};

// Capturing the URL to PDF
PdfDocument pdfDocument = pdfRenderer.RenderUrlAsPdf("https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/");
pdfDocument.SaveAs("webGL.pdf");
```

### PDF Display

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/render-webgl/webGL.pdf#page=3" width="100%" height="500px">
</iframe>

Currently, WebGL cannot be rendered in Docker due to the limitations of headless environments where access to the GPU is restricted. Our development team is exploring solutions. If updates on this topic are desired, please contact <support@ironsoftware.com>.

Explore more capabilities on our [Tutorial Page](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/).