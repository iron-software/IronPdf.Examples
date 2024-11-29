using IronPdf;
using System;
public static class StringExtensions
{
    // Extension method to convert HTML string to PDF
    public static void ConvertHtmlToPdf(this string htmlContent, string filePath)
    {
        // Initialize the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();


        // Render the HTML string to a PDF
        var pdf = renderer.RenderHtmlAsPdf(htmlContent);
        // Save the PDF to the specified file path
        pdf.SaveAs(filePath);
    }
}
// Example usage of the extension method
public class Program
{
    public static void Main()
    {
        // Example HTML content
        string html = "<html><body><h1>Welcome to IronPDF</h1><p>Generate PDFs in .NET easily.</p></body></html>";
        // Convert HTML to PDF and save it
        html.ConvertHtmlToPdf("WelcomePDF.pdf");
    }
}
