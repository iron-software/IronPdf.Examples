using IronPdf;
public class PDFGenerator
{
    public static void CreatePDF()
    {
        // Create an instance of the HtmlToPdf class
        var renderer = new ChromePdfRenderer();
        // Define the HTML content using a multiline string
        string htmlContent = @"
            <html>
            <head>
                <title>PDF Title</title>
            </head>
            <body>
                <h1>Welcome to IronPDF</h1>
                <p>This is a simple PDF document generated from HTML.</p>
                <p style='color: red;'>This text is red.</p>
            </body>
            </html>";
        // Render the HTML to PDF
        var pdf = renderer.RenderHtmlAsPdf(htmlContent);
        // Save the PDF to a file
        pdf.SaveAs("ExamplePDF.pdf");
    }
}
