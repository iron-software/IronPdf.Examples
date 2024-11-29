# Working with Base URLs & Asset Encoding in IronPDF

***Based on <https://ironpdf.com/how-to/base-urls/>***


IronPDF excels in generating PDFs within .NET applications and often involves converting HTML to PDF. This raises the question: *How do we integrate CSS stylesheets and image files into our HTML to PDF conversions?* Let's explore the details.

## Generating PDFs from HTML Strings Using Assets

When converting HTML strings into PDF, it is crucial to configure the **BaseUrlOrPath** parameter to ensure the accurate loading of assets like CSS, JavaScript files, and images. The **BaseUrlOrPath** stipulates the base URL for fetching all referenced assets.

Assets can be fetched from a web URL beginning with 'http' or from local storage using a local file path. Configuring this correctly guarantees that assets are correctly located during the conversion.

```cs
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section1
    {
        public void Run()
        {
            // Create instance of ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            string baseUrl = @"C:\site\assets\";
            string htmlContent = "<img src='icons/iron.png'>";
            
            // Translate HTML to PDF
            PdfDocument pdfDocument = renderer.RenderHtmlAsPdf(htmlContent, baseUrl);
            
            // Save the generated PDF
            pdfDocument.SaveAs("html-with-assets.pdf");
        }
    }
}
```

### Applying Base URLs within MVC Applications

In the context of an MVC application, correctly linking an image file requires precise configuration of the **baseUrl** in IronPDF alongside the **src** attribute in the HTML string.

Setting up your directory like this:
- Set `baseUrlOrPath` to @"wwwroot/image"
- Point the `src` attribute to "../image/Sample.jpg"

```txt
wwwroot
└── image
    ├── Sample.jpg
    └── Sample.png
```

**For instance:**

```cs
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("html.Result", @"wwwroot/image");
        }
    }
}
```

```html
<img src="../image/Sample.jpg"/>
<img src="../image/Sample.png"/>
```

#### Path Formats to Avoid

The following path formats may function correctly in Chrome, but may not correctly locate directories in an MVC application unless paired with the appropriate `BaseUrlOrPath` setting in IronPDF:

```html
<img src="image/footer.png"/>  
<img src="./image/footer.png"/>  
```

Conversely, these paths are suitable for MVC setup but not for file locating in IronPDF:

```html
<img src="/image/footer.png"/>  
<img src="~/image/footer.png"/>
```

## PDF Rendering with HTML Headers and Footers

HTML headers and footers in a PDF are treated as separate documents and thus do not inherit the BaseURL. Specify a BaseURL to load assets from:

```cs
using System;
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                MaxHeight = 20,
                HtmlFragment = "<img src='logo.png'>",
                BaseUrl = new Uri(@"C:\assets\images\").AbsoluteUri
            };
        }
    }
}
```

## Converting HTML Files to PDFs Including Asset Links

When converting an entire HTML file to PDF, all linked assets (JS, CSS, images) are presumed to be local to the file's directory.

```cs
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section4
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("C:\\Assets\\TestInvoice1.html");
            
            pdf.SaveAs("Invoice.pdf");
        }
    }
}
```

Additionally, you can specify a unique stylesheet for .NET PDF rendering by using the [CustomCssUrl in ChromePdfRenderOptions](https://ironpdf.com/api/IronPdf.ChromePdfRenderOptions.html#IronPdf_ChromePdfRenderOptions_CustomCssUrl).

```cs
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section5
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.CustomCssUrl = "./style.css";
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            pdf.SaveAs("tryCss.pdf");
        }
    }
}
```

## Direct Encoding of Image Assets

To circumvent issues where images fail to load, you can embed images directly using base64 encoding. First, convert the image's binary data to a base64 string.

```cs
using System.IO;
using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section6
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");
            
            string imgDataUri = Convert.ToBase64String(binaryData);
            
            string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            pdf.SaveAs("embedImageBase64.pdf");
        }
    }
}
```

These methods allow for flexible and reliable PDF generation from HTML, leveraging both local and web assets within .NET applications using IronPDF.