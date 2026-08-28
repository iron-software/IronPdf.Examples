using IronPdf;
namespace IronPdf.Examples.HowTo.BlazorTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            string htmlContent = "<h1>Hello from Blazor</h1>";
            string outputPath = "blazor.pdf";

            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf(htmlContent).SaveAs(outputPath);
        }
    }
}