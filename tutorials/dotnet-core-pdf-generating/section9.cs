using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section9
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var renderer = new IronPdf.ChromePdfRenderer();

            renderer.RenderingOptions.RenderDelay = 200;        // ms
            // OR: renderer.RenderingOptions.JavaScript = "WaitFor('window.doneLoading')";
        }
    }
}