using IronPdf;
namespace IronPdf.Examples.HowTo.PdfMemoryStream
{
    public static class Section3
    {
        public static void Run()
        {
            Response.Clear();
            
            Response.ContentType = "application/octet-stream";
            
            Context.Response.OutputStream.Write(pdfAsStream, 0, stream.Length);
            
            Response.Flush();
        }
    }
}