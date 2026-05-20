using IronPdf;
namespace IronPdf.Examples.HowTo.AddImagesToPdfs
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Embed an image in a PDF with one line!
            new IronPdf.ChromePdfRenderer()
                 .RenderHtmlAsPdf("<img src='data:image/png;base64," + Convert.ToBase64String(File.ReadAllBytes("logo.png")) + "'>")
                 .SaveAs("image‑embedded.pdf");
        }
    }
}