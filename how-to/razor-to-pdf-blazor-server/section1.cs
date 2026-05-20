using IronPdf;
namespace IronPdf.Examples.HowTo.RazorToPdfBlazorServer
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert a Blazor Razor component to PDF in one line!
            // Install-Package IronPdf.Extensions.Blazor
            var pdf = new IronPdf.ChromePdfRenderer()
                .RenderRazorComponentToPdf<MyComponent>(new Dictionary<string,object> { {"persons",personsList} })
                .SaveAs("component‑to‑pdf.pdf");
        }
    }
}