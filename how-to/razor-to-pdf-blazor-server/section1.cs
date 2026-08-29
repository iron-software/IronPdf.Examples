using IronPdf;
namespace IronPdf.Examples.HowTo.RazorToPdfBlazorServer
{
    public static class Section1
    {
        public static void Run()
        {
            // RenderRazorComponentToPdf ships in IronPdf.Extensions.Blazor, and MyComponent is the page's own component.
            // Kept verbatim; see README.md for the full context.
            // // Install-Package IronPdf.Extensions.Blazor
            // var pdf = new IronPdf.ChromePdfRenderer()
            // .RenderRazorComponentToPdf<MyComponent>(new Dictionary<string,object> { {"persons",personsList} })
            // .SaveAs("component‑to‑pdf.pdf");
        }
    }
}