# How to Incorporate Page Numbers into a PDF Document

***Based on <https://ironpdf.com/how-to/page-numbers/>***


Page numbers are essential markers for each page in a PDF, facilitating easy navigation, reference, and citation by indicating precise page locations and total page counts. Incorporating these into your documents enhances usability significantly. IronPDF offers a straightforward method to insert page numbers into your PDFs.

## Example on Adding Page Numbers

With IronPDF, you can employ placeholder strings `{page}` and `{total-pages}` within the `TextHeaderFooter` or `HtmlHeaderFooter` classes to display the current and total page numbers.

```cs
using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section1
    {
        public void Run()
        {
            // Initializes a new text header
            TextHeaderFooter textHeader = new TextHeaderFooter()
            {
                CenterText = "{page} of {total-pages}"
            };

            // Initializes a new HTML footer
            HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };

            // Create and render a PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

            // Append header and footer to the PDF
            pdf.AddTextHeaders(textHeader);
            pdf.AddHtmlFooters(htmlFooter);

            pdf.SaveAs("pdfWithPageNumber.pdf");
        }
    }
}
```

Here is the rendered PDF from the above code implemented:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/page-numbers/pdf-with-page-numbers.pdf" width="100%" height="500px">
</iframe>

It's also feasible to insert these headers and footers directly into the rendering settings of the `ChromePdfRenderer`.

```cs
using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section2
    {
        public void Run()
        {
            // Configure rendering options with headers and footers
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
            {
                CenterText = "{page} of {total-pages}"
            };
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };

            string html = @"
                <h1>Hello World!</h1>
            <div style='page-break-after: always;'/>
                <h1>2nd Page!</h1>";
            
            // Generate the PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

            pdf.SaveAs("applyPageNumberWithRenderingOptions.pdf");
        }
    }
}
```

## Tailoring Page Numbers for Specific Pages

IronPDF allows for precise control over the placement of page numbers, whether starting them from a specific page or applying them to designated groups, such as even or odd-indexed pages.

### Configuration of the Document

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section3
    {
        public void Run()
        {
            string multi_page_html = @"
                <p>This is the 1st Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 2nd Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 3rd Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 4th Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 5th Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 6th Page</p>
            <div style='page-break-after: always;'></div>
                <p>This is the 7th Page</p>";

            HtmlHeaderFooter header = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };

            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf(multi_page_html);

            var allPageIndices = Enumerable.Range(0, pdf.PageCount);
        }
    }
}
```

### Application on Even and Odd Pages

```cs
using IronPdf;
namespace ironpdf.PageNumbers
{
    // Code for adding page numbers exclusively to even-indexed pages resulting in odd page numbering
    public class Section4
    {
        public void Run()
        {
            var evenPageIndices = allPageIndices.Where(i => i % 2 == 0);

            pdf.AddHtmlHeaders(header, 1, evenPageIndices);
            pdf.SaveAs("EvenPages.pdf");
        }
    }

    // Code for adding page numbers exclusively to odd-indexed pages resulting in even page numbering
    public class Section5
    {
        public void Run()
        {
            var oddPageIndexes = allPageIndices.Where(i => i % 2 != 0);

            pdf.AddHtmlHeaders(header, 1, oddPageIndexes);
            pdf.SaveAs("OddPages.pdf");
        }
    }
}
```

#### Specifying First and Last Pages	EIF_IDENTIFIER	end_column	end_line

- **First Page**: ` {First page only code snippet}`.StylePriority