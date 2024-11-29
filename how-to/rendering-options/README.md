# Exploring Rendering Options in PDF Creation

***Based on <https://ironpdf.com/how-to/rendering-options/>***


Rendering options in the context of PDF generation encapsulate the various settings and configurations that influence the creation, appearance, and print characteristics of a PDF file. These options encompass a variety of settings, including but not limited to the handling of form field elements, activation of JavaScript, creation of a table of contents, and the inclusion of headers and footers. Other settings allow you to tailor margins, define PDF paper dimensions, and more.

Within the IronPDF toolkit, the `ChromePdfRenderer` class offers a plethora of rendering options to fine-tune how PDFs are produced. It offers features like `PaperFit`, which handles the layout of content on PDF pages, with layout options ranging from responsive CSS3 layouts to continuous feed options.

## Example of Using Rendering Options

Rendering options are not just for converting HTML to PDF. They can be effectively utilized across different PDF generation scenarios. Below is an example where we convert Markdown content into a PDF using specific rendering settings.

```cs
using IronPdf;
namespace ironpdf.RenderingOptions
{
    public class Section1
    {
        public void Execute()
        {
            // Create a new renderer instance
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set various rendering options
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                HtmlFragment = "<h1>Custom Header</h1>"
            };
            renderer.RenderingOptions.SetCustomPaperSizeinMilimeters(150, 150);
            renderer.RenderingOptions.MarginTop = 0;
            
            // Define markdown content
            string markdownContent = "# Title\nThis is some **bold** and *italic* text.";
            
            // Convert markdown to PDF
            PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(markdownContent);
            
            // Save the output PDF
            pdf.SaveAs("UpdatedRenderingOptions.pdf");
        }
    }
}
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/rendering-options/renderingOptions.pdf" width="100%" height="400px">
</iframe>

<hr>

## Comprehensive List of Rendering Options

Below are some of the advanced options available for tailoring PDF rendering, including adjustments to margins, paper orientation, and more.

Here's a detailed table showcasing the diverse array of options you can manipulate.

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <!-- This is just a sample of the many options available. -->
      <!-- Each row defines a different rendering parameter or feature. -->
      <tr class="tr-head">
        <th class="tcol1">Class</th>
        <th colspan="2" style="font-family:'Gotham-Light'">ChromePdfRenderer</th>
      </tr>
      <tr class="tr-head">
        <th class="tcol1">Description</th>
        <th colspan="2" style="font-family:'Gotham-Light'">Defines print out configurations like paper size, DPI, headers, and footers for PDF documents.</th>
      </tr>
      <tr class="tr-head">
        <th class="tcol1">Properties / Functions</th>
        <th class="tcol2">Type</th>
        <th class="tcol3">Description</th>
      </tr>
      <!-- Sample rows showcasing options like CustomCookies, PaperFit, EnableJavaScript and more. -->
      <!-- For a complete list, the user should refer to the IronPDF documentation or contact support. -->
      <!-- Each property description is concise to fit the table but detailed enough to give a clear usage context. -->
      <tr>
        <td>CustomCookies</td>
        <td>Dictionary&lt;string, string&gt;</td>
        <td>Implement custom cookies within the HTML rendering, configured anew with each render cycle.</td>
      </tr>
      <tr>
        <td>UseMarginsOnHeaderAndFooter</td>
        <td>Boolean</td>
        <td>Applies the main document's margin settings to the headers and footers.</td>
      </tr>
      <tr>
        <td>CreatePdfFormsFromHtml</td>
        <td>bool</td>
        <td>Transform HTML form components into interactive PDF forms. Enabled by default.</td>
      </tr>
      <!-- Additional rows continue below. -->
    </tbody>
  </table>
</div>

This table provides a structured overview of key options available within the `ChromePdfRenderer` class, demonstrating the flexibility and control developers have when generating PDFs with IronPDF.