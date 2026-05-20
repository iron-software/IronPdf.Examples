using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section2
    {
        public static void Run()
        {
            // Sends 'stream' to the client as a file download with the specified name.
            return new FileStreamResult(stream, "application/pdf")
            {
                FileDownloadName = "file.pdf"
            };
        }
    }
}