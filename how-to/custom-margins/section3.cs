using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section3
    {
        public void Run()
        {
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
        }
    }
}