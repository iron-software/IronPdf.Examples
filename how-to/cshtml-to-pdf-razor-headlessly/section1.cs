using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfRazorHeadlessly
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Render a Razor view to PDF headlessly!
            var html = await RazorTemplateEngine.RenderAsync("Views/Template.cshtml", model); 
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf(html).SaveAs("output.pdf");
        }
    }
}