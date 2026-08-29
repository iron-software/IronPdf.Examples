using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.HowTo.Cookies
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { RequestContext = IronPdf.Rendering.RequestContexts.Global, CustomCookies = new Dictionary<string, string> { { "sessionId", "your_cookie_value" } } } }
                .RenderUrlAsPdf("https://example.com/protected")
                .SaveAs("secureWithCookies.pdf");
        }
    }
}