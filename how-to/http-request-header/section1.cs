using IronPdf;
namespace IronPdf.Examples.HowTo.HttpRequestHeader
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { HttpRequestHeaders = new Dictionary<string,string> { { "Authorization", "Bearer your_token_here" }, { "User-Agent", "MyApp/1.0" } } } }
                .RenderUrlAsPdf("https://httpbin.org/bearer")
                .SaveAs("withHeaders.pdf");
        }
    }
}