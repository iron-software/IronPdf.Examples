using IronPdf;
namespace IronPdf.Examples.HowTo.RenderWebgl
{
    public static class Section1
    {
        public static void Run()
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