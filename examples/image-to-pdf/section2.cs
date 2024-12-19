using IronPdf;
namespace IronPdf.Examples.Example.ImageToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            string sourceDirectory = "D:\web\assets";
            string destinationFile = "JpgToPDF.pdf";
            var imageFiles = Directory.EnumerateFiles(sourceDirectory, "*.jpg");
            ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs(destinationFile);
        }
    }
}