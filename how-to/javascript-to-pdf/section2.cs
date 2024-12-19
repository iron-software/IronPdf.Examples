using IronPdf;
namespace IronPdf.Examples.HowTo.JavascriptToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // JavaScript code
            renderer.RenderingOptions.Javascript = @"
            document.querySelectorAll('h1').forEach(function(el){
                el.style.color='red';
            })";
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Happy New Year!</h1>");
            
            pdf.SaveAs("executed_js.pdf");
        }
    }
}