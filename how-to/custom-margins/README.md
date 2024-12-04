# Customizing Margins for PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/custom-margins/>***


Working on PDFs usually calls for setting specific margins to ensure the document meets various formatting standards. Whether you follow MLA and APA styles with their 1-inch margins or university guidelines requiring 1.5-inch margins for dissertations, targeting these requirements is essential.

IronPDF simplifies the process of customizing margins when converting HTML to PDF. This functionality is highly adjustable with minimum coding required.

## Example of Setting Custom Margins

To define custom margins, begin by creating an instance of the `ChromePdfRenderer` class. Within this context, you can modify the `RenderingOptions` object to set precise margins (top, bottom, left, and right) in millimeters, as demonstrated below:

```cs
using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.MarginTop = 40;
            renderer.RenderingOptions.MarginLeft = 20;
            renderer.RenderingOptions.MarginRight = 20;
            renderer.RenderingOptions.MarginBottom = 40;
        }
    }
}
```

This code effectively sets additional margins on top of those specified within your HTML's style section. For example, if the HTML code initially sets a 50 mm margin, applying the `RenderingOptions` margins as in the second example below results in a combined margin of 80 mm:

```cs
using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section2
    {
        public void Run()
        {
            const string htmlWithStyle = @"
            <!DOCTYPE html>
            <html>
                <head>
                    <style>
                        body {margin: 50mm 50mm 50mm 50mm;}
                    </style>
                </head>
            <body>
                <h1>Hello World!</h1>
            </body>
            </html>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.MarginTop = 30;
            renderer.RenderingOptions.MarginLeft = 30;
            renderer.RenderingOptions.MarginRight = 30;
            renderer.RenderingOptions.MarginBottom = 30;
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlWithStyle);
            pdf.SaveAs("PdfWithCustomMargins.pdf");
        }
    }
}
```

The final outcome of the customized margins is showcased below:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-margins/PdfWithCustomMargins.pdf" width="100%" height="500px"></iframe>

## Applying Custom Margins to Headers and Footers

By default, `RenderingOptions` does not govern header and footer margins. To apply the document's custom margins to headers and footers, leverage the `UseMarginsOnHeaderAndFooter` property:

```cs
using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section3
    {
        public void Run()
        {
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.All;
        }
    }
}
```

It's feasible to select specific margins (top, bottom, left, right) for headers and footers. To view the complete set of options, see the [full API reference here](https://ironpdf.com/object-reference/api/IronPdf.UseMargins.html). Below are some examples:

```cs
using IronPdf;
namespace ironpdf.CustomMargins
{
    public class Section4
    {
        public void Run()
        {
            // Apply only the left margin to the header and footer.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.Left;
            
            // Apply both left and right margins to the header and footer.
            renderer.RenderingOptions.UseMarginsOnHeaderAndFooter = UseMargins.LeftAndRight;
        }
    }
}
```