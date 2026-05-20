using IronPdf;
namespace IronPdf.Examples.HowTo.RtfToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert an RTF document to PDF in one line!
            new IronPdf.ChromePdfRenderer()
                 .RenderRtfFileAsPdf("input.rtf")
                 .SaveAs("output.pdf");
        }
    }
}