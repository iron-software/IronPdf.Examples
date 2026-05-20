using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section4
    {
        public static void Run()
        {
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
        }
    }
}