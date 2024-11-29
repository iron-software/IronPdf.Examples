using IronPdf;
public class PDFGenerator
{
    // Method to create a PDF with default parameters
    public static void CreatePDF(string htmlContent = "<h1>Hello World</h1>", string fileName = "DefaultPDF.pdf")
    {
        // Initialize the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();
        // Render the HTML content to PDF
        var pdf = renderer.RenderHtmlAsPdf(htmlContent);
        // Save the PDF to a file with the given or default file name
        pdf.SaveAs(fileName);
    }
}
