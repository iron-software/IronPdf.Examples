using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfMvcCore
{
    public static class Section1
    {
        public static void Run()
        {
            // This snippet is RenderRazorViewToPdf ships in IronPdf.Extensions.Mvc.Core, and HttpContext and model belong to the controller the page describes.
            // Kept verbatim; see README.md for the full context.
            // // using IronPdf.Extensions.Mvc.Core
            // new IronPdf.ChromePdfRenderer().RenderRazorViewToPdf(HttpContext, "Views/Home/Report.cshtml", model).SaveAs("report.pdf");
        }
    }
}