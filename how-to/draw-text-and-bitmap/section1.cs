using IronPdf;
namespace IronPdf.Examples.HowTo.DrawTextAndBitmap
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Draw text + image onto PDF in one line!
            new ChromePdfRenderer()
                .RenderHtmlAsPdf("<h1>Doc</h1>")
                .DrawText("Hello World", FontTypes.TimesNewRoman.Name, 12, 0, 100, 100, Color.Black, 0)
                .DrawBitmap(AnyBitmap.FromFile("logo.png"), 0, 50, 250, 500, 300)
                .SaveAs("annotated.pdf");
        }
    }
}