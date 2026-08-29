using IronPdf;
namespace IronPdf.Examples.HowTo.Utf8
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;
            var pdf = renderer.RenderHtmlAsPdf("<html><head><meta charset='utf-8'></head><body>こんにちは世界</body></html>");
            pdf.SaveAs("utf8-example.pdf");
        }
    }
}