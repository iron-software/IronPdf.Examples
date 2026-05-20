using IronPdf;
namespace IronPdf.Examples.HowTo.CreateNewPdfs
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            pdf.SaveAs("export.pdf");
        }
    }
}