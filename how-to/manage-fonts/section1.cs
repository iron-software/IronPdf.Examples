using IronPdf;
namespace IronPdf.Examples.HowTo.ManageFonts
{
    public static class Section1
    {
        public static void Run()
        {
            // There is no PdfDocument.FromHtml; a renderer makes the document.
            var pdf = new ChromePdfRenderer()
                .RenderHtmlAsPdf("<p style='font-family:MyCustomFont;'>Hello world!</p>");

            // Fonts.Add takes the font data, and Embed returns void.
            var font = pdf.Fonts.Add(File.ReadAllBytes("MyCustomFont.ttf"));
            font.Embed();

            pdf.SaveAs("withCustomFont.pdf");
        }
    }
}