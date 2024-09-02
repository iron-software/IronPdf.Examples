# How to Render WebGL Sites

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/logos/webgl-logo.svg">
        </div>
    </div>
</div>

WebGL is an impressive technology for creating interactive 3D graphics directly in web browsers; however, the task of converting these dynamic graphics into static PDF documents can be complex. The process of rendering a WebGL-enabled website into PDF involves capturing the visual output produced by the WebGL context and transforming it into a PDF-friendly format.

IronPDF offers the capabilities required to capture and convert WebGL-enhanced websites like [Mapbox](https://www.mapbox.com/) and [WebGL Samples collection](https://webglsamples.org/) into PDFs.

## How to Render Websites with WebGL Content

To facilitate WebGL content rendering, you need to adjust several settings in IronPDF:

- **SingleProcess = true**. This setting ensures that Chrome handles all operations within the current process instead of creating multiple subprocesses.
- **ChromeGpuMode = Hardware** mode.

Additionally, if the website in question requires a delay for proper visual rendering, you can implement `WaitFor.RenderDelay`. For illustration, let’s perform a rendering of a [Mapbox sample](https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/).

```cs
using IronPdf;

// Adjust IronPdf settings
IronPdf.Installation.SingleProcess = true;
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure rendering delay
renderer.RenderingOptions.WaitFor.RenderDelay = 5000;  // Delay set to 5000ms

// Generate PDF from URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/");

pdf.SaveAs("webGL.pdf");  // Save the document as 'webGL.pdf'
```

### Viewing the Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/render-webgl/webGL.pdf#page=3" width="100%" height="500px">
</iframe>

Currently, it is not feasible to perform WebGL rendering in Docker environments. The challenges stem from Docker being typically a headless system without a graphical user interface, which is essential for WebGL as it needs GPU access. Our development team is exploring solutions for this issue. If you would like updates on progress, please reach out to <support@ironsoftware.com>.