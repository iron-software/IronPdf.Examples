using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section4
    {
        public void Run()
        {
            // Use only the left margin from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;
            
            // Use only the left and right margins from the document.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
        }
    }
}