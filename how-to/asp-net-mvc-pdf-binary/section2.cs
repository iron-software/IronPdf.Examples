using IronPdf;
namespace IronPdf.Examples.HowTo.AspNetMvcPdfBinary
{
    public static class Section2
    {
        public static void Run()
        {
            // This snippet writes to the ASP.NET Response of the page it runs in.
            // Kept verbatim; see README.md for the full context.
            // /**
            // * Serve Existing HTML File or String
            // * anchor-serve-existing-html-file-or-string
            // */
            // var Renderer = new IronPdf.ChromePdfRenderer();
            //
            // // Render a PDF from an HTML file
            // using var PDF = Renderer.RenderHtmlFileAsPdf("Project/MyHtmlDocument.html");
            //
            // // Or to convert directly from an HTML string
            // // using var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            //
            // Response.Clear();
            // Response.ContentType = "application/pdf";
            // Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");
            //
            // // Write the PDF's binary data to the response
            // Response.BinaryWrite(PDF.BinaryData);
            //
            // // Flush the response buffer and end the response
            // Response.Flush();
            // Response.End();
        }
    }
}