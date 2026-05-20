using IronPdf;
namespace IronPdf.Examples.HowTo.CustomWatermark
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add Watermarks Instantly
            new IronPdf.PdfDocument.FromFile("input.pdf")
                .ApplyWatermark("<h1 style='opacity:0.5;'>Confidential</h1>", IronPdf.PagePosition.TopCenter)
                .SaveAs("output.pdf");
        }
    }
}