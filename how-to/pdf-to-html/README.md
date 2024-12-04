# Transforming PDF to HTML

***Based on <https://ironpdf.com/how-to/pdf-to-html/>***


### Advantages of PDF to HTML Conversion

Transforming a PDF into HTML format offers numerous advantages that enhance user interaction and accessibility. This includes making content easily accessible on the web across different devices, enhancing SEO, ensuring seamless integration into websites, facilitating straightforward edits via web tools or CMS, and achieving across-the-board compatibility while allowing dynamic and multimedia elements.

IronPdf streamlines and simplifies the conversion from PDF to HTML in .NET C# environments.

## Example: Converting PDF to HTML

The method `ToHtmlString` is designed to facilitate the examination of HTML content within a PDF file. This is particularly useful for debugging or comparing PDF documents. Alongside, IronPdf features the `SaveAsHtml` method. This method enables users to save a PDF as an HTML file directly, adding flexibility to select an approach that best fits their requirements.

It should be noted that any interactive form fields from the source PDF will not function in the HTML output.

#### Sample PDF File

```html
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/sample.pdf" width="100%" height="500px">
</iframe>
```

```cs
using System;
using IronPdf;

namespace ironpdf.PdfToHtml
{
    public class Section1
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("sample.pdf");
            
            // Converting PDF to HTML string
            var html = pdf.ToHtmlString();
            Console.WriteLine(html);
            
            // Converting PDF to HTML file
            pdf.SaveAsHtml("output.html");
        }
    }
}
```

#### Rendered HTML Output

The full HTML output generated via `SaveAsHtml` can be viewed at the link below.

```html
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/myHtml.html" width="100%" height="500px">
</iframe>
```

<hr>

## Advanced PDF to HTML Conversion Example

The methods `ToHtmlString` and `SaveAsHtml` provide various configuration options:

- **BackgroundColor**: Sets the background color of the HTML.
- **PdfPageMargin**: Defines margins around the PDF pages.
- For the `title` parameter in both `ToHtmlString` and `SaveAsHtml`, the properties below can be used to prepend a title to the output:
  - **H1Color**: Color of the title.
  - **H1FontSize**: Font size of the title.
  - **H1TextAlignment**: Alignment of the title text (left, center, or right).

```cs
using System;
using IronPdf;

namespace ironpdf.PdfToHtml
{
    public class Section2
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("sample.pdf");
            
            // Configuration options for PDF to HTML conversion
            var htmlFormatOptions = new HtmlFormatOptions
            {
                BackgroundColor = Color.White,
                PdfPageMargin = 10,
                H1Color = Color.Blue,
                H1FontSize = 25,
                H1TextAlignment = TextAlignment.Center,
            };
            
            // Converting PDF to HTML string considering formatting
            var html = pdf.ToHtmlString();
            Console.WriteLine(html);
            
            // Saving the PDF as a HTML file with configuration and a custom title
            pdf.SaveAsHtml("configuredOutput.html", true, "Document Title", htmlFormatOptions: htmlFormatOptions);
        }
    }
}
```

#### Configured Output HTML

See the generated HTML through the configured `SaveAsHtml` method:

```html
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-to-html/myHtmlConfigured.html" width="100%" height="500px">
</iframe>
```

Note: These methods produce an HTML string with inline CSS, utilizing SVG terms/tags instead of the standard HTML tags. Although there's a slight difference, it remains valid HTML that can be rendered identically in browsers. It is crucial to understand that the HTML output might differ when the input PDF was previously converted from HTML using the `RenderHtmlAsPdf` method, because of the reasons mentioned.