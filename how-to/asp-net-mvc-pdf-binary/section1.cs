using IronPdf;
namespace IronPdf.Examples.HowTo.AspNetMvcPdfBinary
{
    public static class Section1
    {
        public static void Run()
        {
            /**
            Serve Existing PDF
            anchor-serve-existing-pdf-file
            **/
            Response.Clear();
            
            Response.ContentType = "application/pdf";
            
            Response.AddHeader("Content-Disposition","attachment;filename=\"FileName.pdf\"");
            
            // edit this line to display in browser and change the file name
            
            Response.BinaryWrite(System.IO.File.ReadAllBytes("MyPdf.pdf"));
            
            // gets our pdf as a byte array and then sends it to the buffer
            
            Response.Flush();
            
            Response.End();
        }
    }
}