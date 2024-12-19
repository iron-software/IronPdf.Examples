using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            // Send MyPdfDocument.Stream to this method
            return new FileStreamResult(stream, "application/pdf")
            {
                FileDownloadName = "file.pdf"
            };
        }
    }
}