using IronPdf;
namespace IronPdf.Examples.HowTo.ImageToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.ImageToPdfConverter.ImageToPdf("path/to/image.png").SaveAs("imageToPdf.pdf");
        }
    }
}