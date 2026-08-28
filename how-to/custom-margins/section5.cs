using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section5
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var renderer = new IronPdf.ChromePdfRenderer();

            // Use only the left margin from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;
            
            // Use only the left and right margins from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
        }
    }
}