using IronPdf;
namespace ironpdf.RenderWebgl
{
    public class Section1
    {
        public void Run()
        {
            // Configure IronPdf settings
            IronPdf.Installation.SingleProcess = true;
            IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set delay before rendering
            renderer.RenderingOptions.WaitFor.RenderDelay(5000);
            
            // Render from URL
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://docs.mapbox.com/mapbox-gl-js/example/geojson-layer-in-slot/");
            
            pdf.SaveAs("webGL.pdf");
        }
    }
}