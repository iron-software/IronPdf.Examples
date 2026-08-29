using IronPdf;
namespace IronPdf.Examples.HowTo.StampTextImage
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.PdfDocument("input.pdf");
            var stamper = new IronPdf.Editing.TextStamper("Confidential");
            pdf.ApplyStamp(stamper);
            pdf.SaveAs("stamped.pdf");
        }
    }
}