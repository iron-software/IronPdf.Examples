using IronPdf;
namespace IronPdf.Examples.HowTo.BackgroundForeground
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.PdfDocument("input.pdf");
            pdf.AddBackgroundPdf("background.pdf");
            pdf.SaveAs("output.pdf");
        }
    }
}