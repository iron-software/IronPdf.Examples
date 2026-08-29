using IronPdf;
namespace IronPdf.Examples.HowTo.CreateNewPdfs
{
    public static class Section1
    {
        public static void Run()
        {
            // PdfDocument has no parameterless constructor and no DefaultPageSize;
            // a blank page is sized when it is created.
            new IronPdf.PdfDocument(270, 270).SaveAs("blankPage.pdf");
        }
    }
}