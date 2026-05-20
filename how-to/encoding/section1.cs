using IronPdf;
namespace IronPdf.Examples.HowTo.Encoding
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Ensure proper encoding (UTF‑8) in one line!
            new IronPdf.ChromePdfRenderer { RenderingOptions = { InputEncoding = System.Text.Encoding.UTF8 } }
                .RenderHtmlAsPdf("<html><head><meta charset=\"utf‑8\"/></head><body>こんにちは世界</body></html>")
                .SaveAs("unicode.pdf");
        }
    }
}