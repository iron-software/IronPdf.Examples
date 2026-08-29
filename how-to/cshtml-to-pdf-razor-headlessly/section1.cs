using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfRazorHeadlessly
{
    public static class Section1
    {
        public static void Run()
        {
            // RazorTemplateEngine comes from RazorTemplates, a package outside IronPDF.
            // Kept verbatim; see README.md for the full context.
            // var html = await RazorTemplateEngine.RenderAsync("Views/Template.cshtml", model);
            // new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf(html).SaveAs("output.pdf");
        }
    }
}