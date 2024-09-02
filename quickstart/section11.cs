using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.RenderDelay(500);
renderer.RenderingOptions = new ChromePdfRenderOptions()
{
    EnableJavaScript = true,
};