using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfRazorHeadlessly
{
    public static class Section2
    {
        public static void Run()
        {
            app.MapGet("/PrintPdf", async () =>
            {
                // Set your IronPDF license key
                IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
                
                // Enable detailed logging for troubleshooting
                IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
            
                // Render the Razor view to an HTML string
                string html = await RazorTemplateEngine.RenderAsync("Views/Home/Data.cshtml");
            
                // Create a new instance of ChromePdfRenderer 
                ChromePdfRenderer renderer = new ChromePdfRenderer();
               
                // Render the HTML string as a PDF document
                PdfDocument pdf = renderer.RenderHtmlAsPdf(html, "./wwwroot");
            
                // Return the PDF file as a response
                return Results.File(pdf.BinaryData, "application/pdf", "razorViewToPdf.pdf");
            });
        }
    }
}