using IronPdf;
namespace IronPdf.Examples.HowTo.CustomWatermark
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("input.pdf")
                .ApplyWatermark("<h1 style='opacity:0.5;'>Confidential</h1>", 50,
                    IronPdf.Editing.VerticalAlignment.Top,
                    IronPdf.Editing.HorizontalAlignment.Center)
                .SaveAs("output.pdf");
        }
    }
}