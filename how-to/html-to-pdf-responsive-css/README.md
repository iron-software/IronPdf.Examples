# How to Integrate CSS with HTML

***Based on <https://ironpdf.com/how-to/html-to-pdf-responsive-css/>***


The media type `screen` in CSS is specifically designed for use on computer screens and similar devices. The styles defined under this category are crafted to enhance the visual appeal and interactivity of web content on these devices.

On the other hand, the `print` media type in CSS is tailored for printed outputs. It focuses on how web pages are rendered on paper, emphasizing the optimization of content for printing. This typically involves modifications to font sizes, margins, and the exclusion of non-essential elements for print.

## Utilizing Screen & Print CSS Types in CSS3

IronPDF, a tool for generating PDFs from HTML in C#, seamlessly applies a screen stylesheet to generate PDFs by default. This is particularly useful since print stylesheets are generally less developed and utilized than screen stylesheets.

With CSS3, various styles can be exclusively set for print documents while others are meant for viewing on web browsers. IronPDF offers the flexibility to work with both types of styles.

Explore the intricacies of creating and applying a print stylesheet for your HTML here: [Learn how to craft and apply a perfect print stylesheet](https://www.jotform.com/blog/css-perfect-print-stylesheet-98272/).

The advantages of using either CSS media type depend largely on the specific requirements of the project. Experimenting through trial and error is recommended to determine which type best meets your needs.

![Example of Print Media](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%201.webp)
![Example of Screen Media](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%202.webp)

<hr>

## Repeating Table Headers Across Pages

While working with HTML tables that extend over several pages, setting the **CssMediaType** property to **PdfCssMediaType.Print** ensures that the table header is repeated on each subsequent page. Alternatively, setting it to **PdfCssMediaType.Screen** configures Chrome to print the headers just once.

It is crucial to wrap the table headers within a `<thead>` tag for Chrome to correctly recognize and print them. Below is a demonstration of rendering the [tableHeader.html for repeating table headers](https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.html) as a PDF to illustrate this functionality:

```cs
using IronPdf.Rendering;
using IronPdf;

namespace ironpdf.HtmlToPdfResponsiveCss
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set a custom paper size
            renderer.RenderingOptions.SetCustomPaperSizeinPixelsOrPoints(600, 400);
            
            // Specify the CSS media type for rendering
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
            
            // Convert HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableHeader.html");
            
            pdf.SaveAs("tableHeader.pdf");
        }
    }
}
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.pdf" width="100%" height="400px">
</iframe>