# Converting HTML String into PDF

***Based on <https://ironpdf.com/how-to/html-string-to-pdf/>***


IronPDF delivers robust capabilities in C#, F#, and VB.NET to developers working with both .NET Core and .NET Framework. This tool harnesses the power of the Google Chromium engine, which is fully operational, to convert HTML strings into polished PDF files.

## Example: Converting HTML String to PDF

Below, you'll find an illustration of how IronPDF can convert an HTML string into a PDF document through the `RenderHtmlAsPdf()` method. This method accepts an HTML string as its parameter for PDF conversion.

```cs
using IronPdf;
namespace ironpdf.HtmlStringToPdf
{
    public class ConvertHTML
    {
        public void Execute()
        {
            // Initialize PDF Renderer
            var pdfRenderer = new ChromePdfRenderer();

            // Convert HTML string to PDF
            var document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

            // Save the PDF document
            document.SaveAs("hello-world.pdf");
        }
    }
}
```

If the HTML string is sourced externally and there’s a necessity to disable disk access or block cross-origin requests, setting the `Installation.EnableWebSecurity` property to true can safely address these concerns.

### Conversion Output

This is the resultant PDF from the above code:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/output.pdf" width="100%" height="500px">
</iframe>

## Enhanced HTML to PDF Conversion Example

This scenario demonstrates using IronPDF to include an external image asset, by setting the `BaseUrlOrPath` which is critical for resolving paths for images, hyperlinks, CSS, and JavaScript included in the HTML.

```cs
using IronPdf;
namespace ironpdf.HtmlStringToPdf
{
    public class AdvancedConversion
    {
        public void Execute()
        {
            // Initialize PDF Renderer
            var pdfRenderer = new ChromePdfRenderer();

            // Convert HTML using external assets
            var enrichedPdf = pdfRenderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
            enrichedPdf.SaveAs("detailed-html.pdf");
        }
    }
}
```

This is the resulting file from the advanced conversion:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-string-to-pdf/html-with-assets.pdf" width="100%" height="500px">
</iframe>