using IronPdf;
namespace IronPdf.Examples.GettingStarted.Quickstart
{
    public static class Section4
    {
        public static void Run()
        {
            PdfDocument pdf = new PdfDocument(270, 270);
            pdf.SaveAs("blankPage.pdf");
        }
    }
}