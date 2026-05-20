using IronPdf;
namespace IronPdf.Examples.HowTo.RenderingOptions
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate a ChromePdfRenderer object, which uses a headless version of the Chrome browser
            // to render HTML/CSS as a PDF document.
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure rendering options
            // Enable printing of HTML backgrounds to ensure all styles are visible.
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            
            // Set HTML header content using HtmlHeaderFooter.
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
            {
                // HTML fragment to add a header at the top of every page in the PDF.
                HtmlFragment = "<h1>Header Content</h1>"
            };
            
            // Set a custom paper size for the PDF in millimeters (width and height).
            renderer.RenderingOptions.SetCustomPaperSizeinMilimeters(150, 150);
            
            // Set the top margin to zero to start the content from the very top of the page.
            renderer.RenderingOptions.MarginTop = 0;
            
            // Define a Markdown string that will be rendered as a PDF.
            // Markdown text allows basic formatting like bold and italic styles.
            string md = "This is some **bold** and *italic* text.";
            
            // Render the Markdown string to a PDF document.
            // The library will convert Markdown syntax into equivalent HTML before rendering it as a PDF.
            PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);
            
            // Save the generated PDF to a file named "renderingOptions.pdf."
            pdf.SaveAs("renderingOptions.pdf");
        }
    }
}