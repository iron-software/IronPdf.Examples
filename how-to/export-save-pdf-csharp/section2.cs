using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section2
    {
        public static void Run()
        {
            byte [] Binary = MyPdfDocument.BinaryData;
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Context.Response.OutputStream.Write(Binary, 0, Binary.Length);
            Response.Flush();
        }
    }
}