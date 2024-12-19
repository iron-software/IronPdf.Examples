using IronPdf;
namespace IronPdf.Examples.HowTo.AspNetMvcPdfBinary
{
    public static class Section2
    {
        public static void Run()
        {
            /**
            Serve Existing HTML File or String
            anchor-serve-existing-html-file-or-string
            **/
            var Renderer = new IronPdf.ChromePdfRenderer();
            
            using var PDF = Renderer.RenderHTMLFileAsPdf("Project/MyHtmlDocument.html");
            
            // or to convert an HTML string
            
            //var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            
            Response.Clear();
            
            Response.ContentType = "application/pdf";
            
            Response.AddHeader("Content-Disposition","attachment;filename=\"FileName.pdf\"");
            
            // edit this line to display in browser and change the file name
            
            Response.BinaryWrite( PDF.BinaryData );
            
            Response.Flush();
            
            Response.End();
        }
    }
}