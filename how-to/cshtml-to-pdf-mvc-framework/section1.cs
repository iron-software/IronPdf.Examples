using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfMvcFramework
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Generate PDFs Instantly with IronPDF
            // Install-Package IronPdf.Extensions.Razor
            var pdf = new IronPdf.ChromePdfRenderer.RenderRazorToPdf(this.ControllerContext);
        }
    }
}