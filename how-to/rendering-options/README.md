# Exploring PDF Rendering Options

***Based on <https://ironpdf.com/how-to/rendering-options/>***


PDF rendering options encompass the diverse settings and configurations utilized during the generation, viewing, and printing of PDF documents. These options cover a broad spectrum of functionalities such as integrating form fields, activating JavaScript, creating a table of contents, appending headers and footers, adjusting margins, and defining the size of the PDF paper, among others.

The **ChromePdfRenderer** class from IronPDF offers a versatile set of rendering options, empowering users to tailor the generation of PDFs to their specific needs. This class includes features like PaperFit, which manages content layout across PDF pages. It supports various layout modes such as responsive CSS3 layouts and continuous feed.

```cs
:title=Refine PDF Output with Advanced Rendering Options
new IronPdf.ChromePdfRenderer { RenderingOptions = { PrintHtmlBackgrounds = true, MarginTop = 0, MarginBottom = 0, CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print, HtmlHeader = new IronPdf.HtmlHeaderFooter { HtmlFragment = "<div>Custom Header</div>" }, Language = "en-US", Timeout = 120000 } }
    .RenderHtmlStringAsPdf("<h1>Explore Options</h1>")
    .SaveAs("advancedOptions.pdf");
```

## Example of Rendering Options

Although many properties within the rendering options are primarily focused on converting HTML to PDF, they are equally applicable to other PDF conversion scenarios. Below, we'll convert Markdown to PDF while applying specific rendering configurations.

```csharp
using IronPdf;

// Create a new ChromePdfRenderer instance, utilizing a headless Chrome browser to convert HTML/CSS to PDF.
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Configure the rendering settings
renderer.RenderingOptions.PrintHtmlBackgrounds = true; // Ensures visibility of HTML styles.

// Setting up the header of the PDF.
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
{
    HtmlFragment = "<h1>Sample Header</h1>"
};

// Specify a unique paper size in millimeters.
renderer.RenderingOptions.SetCustomPaperSizeinMilimeters(150, 150);

// Eliminate the top margin to align content at the top edge of the page.
renderer.RenderingOptions.MarginTop = 0;

// Prepare a Markdown text with basic formatting.
string md = "Experience **bold** and *italic* styling.";

// Convert the Markdown to a PDF.
PdfDocument pdf = renderer.RenderMarkdownStringAsPdf(md);

// Output the generated PDF with a specific file name.
pdf.SaveAs("advancedOptions.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/rendering-options/renderingOptions.pdf" width="100%" height="400px">
</iframe>

<hr>

## Comprehensive Rendering Options

We provide a collection of advanced settings for PDF rendering which include paper size management, margin adjustments, and more.

Below is an explanatory table delineating these various options.

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Class</th>
          <th colspan="2">ChromePdfRenderer</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Description</th>
          <th colspan="2">Handles a plethora of PDF printout settings like paper size, DPI, headers, and footers</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Properties / functions</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Description</th>
      </tr>
      <!-- Example properties illustrated -->
    </tbody>
  </table>
</div>

Discover more about the powerful capabilities of our tools through our detailed tutorial here: [Convert PDFs](https://ironpdf.com/tutorials/convert-pdf/)