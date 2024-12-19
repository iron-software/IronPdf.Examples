using IronPdf;
namespace IronPdf.Examples.Example.ImageToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.ImageToPdfConverter.ImageToPdf(@"C:\images\example.png").SaveAs("example.pdf");
        }
    }
}