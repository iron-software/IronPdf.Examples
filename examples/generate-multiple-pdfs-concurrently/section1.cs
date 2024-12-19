using IronPdf;
namespace IronPdf.Examples.GenerateMultiplePdfsConcurrently
{
    public static class Section1
    {
        public static void Run()
        {
            class Program
            {
                static void Main(string [] args)
                {
                    var renderer = new ChromePdfRenderer();
            
                    // 1. Convert HTML String to PDF
                    var htmlContent = "<h1>Hello, IronPDF!</h1><p>This is a PDF from an HTML string.</p>";
                    var pdfFromHtmlString = renderer.RenderHtmlAsPdf(htmlContent);
                    pdfFromHtmlString.SaveAs("HTMLStringToPDF.pdf");
            
                    // 2. Convert HTML File to PDF
                    var htmlFilePath = "path_to_your_html_file.html"; // Specify the path to your HTML file
                    var pdfFromHtmlFile = renderer.RenderHtmlFileAsPdf(htmlFilePath);
                    pdfFromHtmlFile.SaveAs("HTMLFileToPDF.pdf");
            
                    // 3. Convert URL to PDF
                    var url = "http://ironpdf.com"; // Specify the URL
                    var pdfFromUrl = renderer.RenderUrlAsPdf(url);
                    pdfFromUrl.SaveAs("URLToPDF.pdf");
                }
            }
        }
    }
}