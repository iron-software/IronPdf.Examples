using IronPdf;
namespace IronPdf.Examples.HowTo.CreateNewPdfs
{
    public static class Section2
    {
        public static void Run()
        {
            PdfDocument pdf = new PdfDocument(270, 270);
            
            pdf.SaveAs("blankPage.pdf");
        }
    }
}