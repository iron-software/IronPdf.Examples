using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfRazorHeadlessly
{
    public static class Section1
    {
        public static void Run()
        {
            app.MapGet("/PrintPdf", async () =>
            {
                IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
                IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
            
                string html = await RazorTemplateEngine.RenderAsync("Views/Home/Data.cshtml");
            
                ChromePdfRenderer renderer = new ChromePdfRenderer();
                PdfDocument pdf = renderer.RenderHtmlAsPdf(html, "./wwwroot");
            
                return Results.File(pdf.BinaryData, "application/pdf", "razorViewToPdf.pdf");
            });
        }
    }
}