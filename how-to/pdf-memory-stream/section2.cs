using IronPdf;
namespace IronPdf.Examples.HowTo.PdfMemoryStream
{
    public static class Section2
    {
        public static void Run()
        {
            return new FileStreamResult(pdfAsStream, "application/pdf")
            {
                FileDownloadName = "downloadedfile.pdf"
            };
        }
    }
}