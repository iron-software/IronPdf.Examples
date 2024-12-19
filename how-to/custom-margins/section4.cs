using IronPdf;
namespace IronPdf.Examples.HowTo.CustomMargins
{
    public static class Section4
    {
        public static void Run()
        {
            // Use only the left margin from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;
            
            // Use only the left and right margins from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
        }
    }
}