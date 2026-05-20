using IronPdf;
namespace IronPdf.Examples.HowTo.PdfMemoryStream
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert MemoryStream to PDF Instantly!
            var bytes = File.ReadAllBytes("sample.pdf");
            var pdfDoc = new IronPdf.PdfDocument(myMemoryStream);
        }
    }
}