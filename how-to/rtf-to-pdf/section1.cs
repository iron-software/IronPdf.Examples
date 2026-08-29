using IronPdf;
namespace IronPdf.Examples.HowTo.RtfToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
                 .RenderRtfFileAsPdf("input.rtf")
                 .SaveAs("output.pdf");
        }
    }
}