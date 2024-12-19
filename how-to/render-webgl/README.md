# Rendering WebGL Sites with IronPDF

***Based on <https://ironpdf.com/how-to/render-webgl/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/logos/webgl-logo.svg">
        </div>
    </div>
</div>

WebGL is an influential technology for crafting interactive 3D graphics inside web browsers. However, translating these dynamic and interactive graphics into a static PDF document presents unique challenges. This transformation entails capturing the graphical output of the WebGL and translating it into a PDF-friendly format.

IronPDF offers effective solutions for converting websites utilizing WebGL, including prominent platforms like [Mapbox](https://www.mapbox.com/) and the [WebGL Samples collection](https://webglsamples.org/).

## Start Using IronPDF for Your WebGL Rendering Needs

### Rendering Configuration for WebGL

When setting up IronPDF for WebGL content, you must adjust several settings:

- **SingleProcess = true**: This configuration ensures that all operations are managed within a single process instead of multiple subprocesses.
- **ChromeGpuMode = Hardware**: This setting enables hardware acceleration essential for rendering WebGL content.

In scenarios where the site requires a delay to fully load its contents, you can utilize the `WaitFor.RenderDelay` method. For demonstration, we'll render a [WebGL example from Mapbox](https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/).

```cs
using IronPdf;

// Set up IronPdf configurations
IronPdf.Installation.SingleProcess = true;
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure rendering delay
renderer.RenderingOptions.WaitFor.RenderDelay(5000);

// Convert URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf("https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/");

pdf.SaveAs("webGL.pdf");
```

### View the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/render-webgl/webGL.pdf#page=3" width="100%" height="500px">
</iframe>

Currently, rendering WebGL content within Docker setups encounters significant limitations. Docker environments are typically devoid of a graphical user interface, which WebGL relies on for rendering via GPU access. This constraint poses challenges in rendering WebGL graphics. Our team is actively exploring solutions to overcome these limitations. For updates on our progress or to request notification once a solution is implemented, please reach out to <support@ironsoftware.com>.