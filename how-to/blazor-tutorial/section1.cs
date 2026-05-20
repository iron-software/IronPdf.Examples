using IronPdf;
namespace IronPdf.Examples.HowTo.BlazorTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Generate PDFs Fast with IronPDF in Blazor
            IronPdf.HtmlToPdf.RenderHtmlAsPdf(htmlContent).SaveAs(outputPath);
        }
    }
}