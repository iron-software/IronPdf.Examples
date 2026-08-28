using IronPdf;
namespace IronPdf.Examples.HowTo.DrawTextAndBitmap
{
    public static class Section3
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            var pdf = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>Report</h1><p>Body</p>");
            var font = new IronPdf.Fonts.PdfFont(IronSoftware.Drawing.FontTypes.Arial);

            string textWithNewlines = "Some text\nSecond line";
            // DrawText places the text itself; there is no position object.
            pdf.DrawText(textWithNewlines, font, 12, 0, 100, 700,
                IronSoftware.Drawing.Color.Black, 0);
        }
    }
}