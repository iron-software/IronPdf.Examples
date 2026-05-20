using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfRazor
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert Razor to PDF Instantly
            // Install-Package IronPdf.Extensions.Razor
            var pdf = new IronPdf.ChromePdfRenderer().RenderRazorToPdf("Views/Home/Index.cshtml");
        }
    }
}