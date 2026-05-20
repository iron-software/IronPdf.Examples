using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Create PDFs Fast with IronPDF
            Dim PDF As New IronPdf.PdfDocument() 
            PDF.SaveAs("output.pdf")
        }
    }
}