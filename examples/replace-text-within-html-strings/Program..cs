using IronPdf;
public class PDFCreatorWithReplace
{
    public static void CreatePDFWithReplacements()
    {
        // Initialize the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();


        // Define the original HTML content
        string htmlContent = @"
            <html>
            <head>
                <title>Document Title</title>
            </head>
            <body>
                <h1>Original Title</h1>
                <p>This is the original content.</p>
            </body>
            </html>";


        // Replace strings in the HTML content
        htmlContent = htmlContent.Replace("Original Title", "Updated Title")
                                 .Replace("original content", "updated content");


        // Render the updated HTML to a PDF
        var pdf = renderer.RenderHtmlAsPdf(htmlContent);
        // Save the PDF to a file
        pdf.SaveAs("UpdatedPDF.pdf");
    }
}
