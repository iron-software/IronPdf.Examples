using IronPdf;
namespace IronPdf.Examples.HowTo.ImageToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert image(s) to PDF in one line!
            IronPdf.ImageToPdfConverter.ImageToPdf("path/to/image.png").SaveAs("imageToPdf.pdf");
        }
    }
}