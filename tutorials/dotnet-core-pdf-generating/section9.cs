using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section9
    {
        public static void Run()
        {
            renderer.RenderingOptions.RenderDelay = 200;        // ms
            // OR: renderer.RenderingOptions.JavaScript = "WaitFor('window.doneLoading')";
        }
    }
}