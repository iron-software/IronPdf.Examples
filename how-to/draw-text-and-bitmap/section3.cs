using IronPdf;
namespace IronPdf.Examples.HowTo.DrawTextAndBitmap
{
    public static class Section3
    {
        public static void Run()
        {
            string textWithNewlines = "Some text\nSecond line";
            pdfDoc.DrawText(textWithNewlines, font, position);
        }
    }
}