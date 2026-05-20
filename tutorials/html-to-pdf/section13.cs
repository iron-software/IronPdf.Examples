using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section13
    {
        public static void Run()
        {
            // Define Handlebars template with placeholders for HTML content
            var source = 
                @"<div class=""entry"">
                    <h1>{{title}}</h1>
                    <div class=""body"">
                        {{body}}
                    </div>
                </div>";
            
            // Compile template for reuse in PDF conversion
            var template = Handlebars.Compile(source);
            
            // Create data object (can be database records) for HTML to PDF directly
            var data = new { 
                title = "Monthly Report", 
                body = "Sales increased by 15% this month." 
            };
            
            // Merge template with data to create HTML content
            var htmlResult = template(data);
            
            // Convert templated HTML to PDF using the PDF converter
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf(htmlResult);
            
            pdf.SaveAs("monthly-report.pdf");
        }
    }
}