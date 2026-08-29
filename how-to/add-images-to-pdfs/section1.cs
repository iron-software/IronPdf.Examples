using IronPdf;
namespace IronPdf.Examples.HowTo.AddImagesToPdfs
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
                 .RenderHtmlAsPdf("<img src='data:image/png;base64," + Convert.ToBase64String(File.ReadAllBytes("logo.png")) + "'>")
                 .SaveAs("image‑embedded.pdf");
        }
    }
}