using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section3
    {
        public static void Run()
        {
            // Retrieves the PDF binary data
            byte[] Binary = MyPdfDocument.BinaryData;
            
            // Clears the existing response content
            Response.Clear();
            
            // Sets the response content type to 'application/octet-stream', suitable for PDF files
            Response.ContentType = "application/octet-stream";
            
            // Writes the binary data to the response output stream
            Context.Response.OutputStream.Write(Binary, 0, Binary.Length);
            
            // Flushes the response to send the data to the client
            Response.Flush();
        }
    }
}