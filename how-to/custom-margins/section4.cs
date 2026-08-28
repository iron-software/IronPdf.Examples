using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section4
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var renderer = new IronPdf.ChromePdfRenderer();

            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
        }
    }
}