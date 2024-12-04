# Rendering WebGL Sites

***Based on <https://ironpdf.com/how-to/render-webgl/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/logos/webgl-logo.svg">
        </div>
    </div>
</div>

WebGL offers a robust framework for building interactive 3D graphics directly in web browsers. However, transforming these dynamic, interactive graphics into static PDF files presents certain challenges. The process of converting a WebGL website to a PDF file involves capturing the visual data produced by the WebGL context and transforming it into a PDF-compatible format.

IronPDF equips developers with the necessary tools to capture and convert WebGL websites like [Mapbox](https://www.mapbox.com/) and [WebGL Samples collection](https://webglsamples.org/) into PDF format.

## Converting WebGL Websites to PDF

For successful WebGL rendering, certain IronPDF settings must be adjusted:

- **SingleProcess = true**. This setting ensures that Chrome operates all tasks within the main process instead of spawning subprocesses.
- **ChromeGpuMode = Hardware**, to utilize hardware acceleration.

Additionally, to accommodate any necessary loading time before capturing the webpage, you can implement the `WaitFor.RenderDelay` method. Here, we demonstrate capturing a [sample from Mapbox's GeoJSON Layer](https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/).

```cs
using IronPdf;
namespace ironpdf.RenderWebgl
{
    public class Section1
    {
        public void Run()
        {
            // Set IronPDF configuration
            IronPdf.Installation.SingleProcess = true;
            IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure delay for rendering to complete
            renderer.RenderingOptions.WaitFor.RenderDelay = 5000;
            
            // Commence rendering from the specified URL
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/");
            
            pdf.SaveAs("webGL.pdf");
        }
    }
}
```

### PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/render-webgl/webGL.pdf#page=3" width="100%" height="500px">
</iframe>

Rendering WebGL in environments like Docker poses certain challenges. Since Docker operates in a typically headless (GUI-less) setup, it restricts access to GPU resources necessary for WebGL. Our technical team is exploring solutions to enable WebGL rendering on Docker platforms. For updates on this development, please reach out to <support@ironsoftware.com>.