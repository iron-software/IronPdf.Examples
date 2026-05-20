using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfua
{
    public static class Section3
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // html is a large stright above of a full html page with <html><head><style><body> etc...
            var pdf = renderer.RenderHtmlAsPdfUA(@"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Document</title>
                </head>
                <body>
                    <h1>Heading 1</h1>
                    <h2>Heading 2</h2>
                    <p>Paragraph text</p>
                </body>
                </html>");
            
            pdf.MetaData.Title = "v2025.1";
            
            pdf.SaveAs("html-string-ua-ironpdf.pdf");
        }
    }
}