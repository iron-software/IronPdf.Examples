using IronPdf;
namespace IronPdf.Examples.HowTo.XamlToPdfMaui
{
    public static class Section1
    {
        public static void Run()
        {
            // RenderContentPageToPdf ships in the MAUI extension, and MainPage and App are the app's own types.
            // Kept verbatim; see README.md for the full context.
            // var pdf = new IronPdf.ChromePdfRenderer().RenderContentPageToPdf<MainPage,App>().SaveAs("page.pdf");
        }
    }
}