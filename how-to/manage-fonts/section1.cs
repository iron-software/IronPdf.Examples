using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add and embed a custom font in one line!
            var pdf = PdfDocument.FromHtml("<p style='font‑family:MyCustomFont;'>Hello world!</p>");
            pdf.Fonts.Add("MyCustomFont", File.ReadAllBytes("MyCustomFont.ttf"))
              .Embed()
              .SaveAs("withCustomFont.pdf");
        }
    }
}