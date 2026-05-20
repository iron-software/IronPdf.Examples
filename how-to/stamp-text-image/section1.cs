using IronPdf;
namespace IronPdf.Examples.HowTo.StampTextImage
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Stamp PDFs Effortlessly
            var pdf = new IronPdf.PdfDocument("input.pdf");
            var stamper = new IronPdf.TextStamper("Confidential", 50, 50);
            pdf.ApplyStamp(stamper);
            pdf.SaveAs("stamped.pdf");
        }
    }
}