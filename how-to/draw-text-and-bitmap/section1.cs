using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.DrawTextAndBitmap
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new ChromePdfRenderer().RenderHtmlAsPdf("<h1>Doc</h1>");

            // DrawText and DrawBitmap both return void.
            pdf.DrawText("Hello World", FontTypes.TimesNewRoman.Name, 12, 0, 100, 100, Color.Black, 0);
            pdf.DrawBitmap(AnyBitmap.FromFile("logo.png"), 0, 50, 250, 500, 300);
            pdf.SaveAs("annotated.pdf");
        }
    }
}