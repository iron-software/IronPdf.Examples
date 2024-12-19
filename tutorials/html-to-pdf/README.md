# HTML to PDF C# Conversion

***Based on <https://ironpdf.com/tutorials/html-to-pdf/>***


As the creators of IronPDF, we recognize the importance of producing PDF documents that not only appear flawless but also meet the precise expectations of our customers. In this tutorial, we'll guide you through the process of creating an HTML-to-PDF converter tailored for your [C# applications](https://learn.microsoft.com/en-us/training/paths/build-dotnet-applications-csharp/), various projects, and web deployments. We'll construct a robust C# HTML-to-PDF converter whereby the resultant PDF documents produced by IronPDF will be indistinguishable from those created using the Google Chrome web browser in terms of quality and accuracy.

<h3>IronPDF Features:</h3>

### Key Features of IronPDF:

- **PDF Creation Capabilities:** Easily generate PDF files from various sources including HTML content, URLs, JavaScript, CSS, and several image formats.
  
- **Enhanced PDF Features:** Effortlessly incorporate features such as headers and footers, digital signatures, file attachments, and robust security measures including password protection into your PDF documents.
  
- **Optimized Performance:** IronPDF is engineered for performance, supporting full multithreading and asynchronous operations to enhance speed and efficiency in PDF processing tasks.

<hr class="separator">
<p class="main-content__segment-title">Overview</p>




<br class="main-article__clear-both">

## HTML to PDF Conversion with C# and VB.NET

Generating PDF documents within .NET platforms can often be cumbersome. Designed primarily for printer interaction rather than programmatic ease, the PDF format can pose unique challenges for developers. Moreover, C# inherently lacks robust, built-in libraries for PDF creation, and external libraries frequently necessitate extensive coding to perform seemingly straightforward tasks.

In this guide, we'll explore using IronPDF from Iron Software, an acclaimed library for generating and editing PDFs in C#. Renowned for its comprehensive features, IronPDF operates straight from installation with minimal coding needed, and boasts [excellent documentation across over 50 features](https://ironpdf.com/features/). Significantly, it supports various frameworks such as **.NET 8, .NET 7, .NET 6, and .NET 5**, and environments like Windows, macOS, Linux, Docker, Azure, and AWS.

With C# combined with IronPDF, [creating a PDF](https://ironpdf.com/blog/using-ironpdf/csharp-generate-pdf-tutorial/) or [converting HTML to PDF](https://ironpdf.com/examples/using-html-to-create-a-pdf/) becomes intuitive. Leveraging IronPDF's advanced Chrome Renderer, the tool integrates seamlessly with your existing HTML content for design and layout purposes.

This approach to PDF generation is versatile, supporting different applications such as console, Windows Forms, WPF, and MVC platforms.

**IronPDF enhances productivity with features like Chrome HTML debugging for flawless PDFs. Consult this [detailed guide](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/) for setup instructions.**

IronPDF caters to diverse programming languages within and outside the .NET ecosystem:

- [F# tutorial](https://ironpdf.com/how-to/fsharp-pdf-library-html-to-pdf/)
- [VB.NET guide](https://ironpdf.com/how-to/vb-net-pdf/)
- [Python instruction](https://ironpdf.com/python/tutorials/html-to-pdf/)
- [Java resources](https://ironpdf.com/java/tutorials/html-to-pdf/)
- [Node.js tutorial](https://ironpdf.com/nodejs/tutorials/html-to-pdf/)

To utilize IronPDF, a trial or commercial license is necessary. [Secure your license here](https://ironpdf.com/licensing/) or [register for a 30-day free trial](https://ironpdf.com/licensing/).

<hr class="separator">

<p class="main-content__segment-title">Step 1</p>

## Setting Up the HTML to PDF Conversion Library in C#

### Using Visual Studio's NuGet Package Manager
To integrate IronPDF into your project using Visual Studio, right-click on your project in Solution Explorer and select `Manage NuGet Packages...`. Simply look for IronPDF using the search bar, and proceed to install the most recent version to your project. Confirm any prompts that appear. This method is also suitable for VB.NET projects.

```shell
Install-Package IronPdf
```

### Directly From NuGet's Website
For a detailed overview of IronPDF’s capabilities, supported platforms, and installation guides, make sure to visit IronPDF's official NuGet page: [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf).

### Manual Installation Using DLL
Alternatively, you can directly download and integrate the IronPDF DLL into your project or GAC. The DLL file can be obtained from the provided link and placed manually in your project directory.

Download from [IronPDF DLL](https://ironpdf.com/packages/IronPdf.zip)

### Visual Studio - NuGet Package Management

Within Visual Studio, perform a right-click on the Solution Explorer for your project and choose the `Manage NuGet Packages...` option. Simply enter "IronPDF" in the search field and proceed to install the most recent version into your project. Accept any dialog boxes that may appear during the installation process. This method is equally effective for projects using VB.NET.

```shell
# Install the IronPdf library via NuGet

***Based on <https://ironpdf.com/tutorials/html-to-pdf/>***

Install-Package IronPdf
```

### Discover IronPDF on the NuGet Website

Explore the full suite of features, system compatibility, and download options for IronPDF by visiting the official NuGet website at: [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf){: .js-modal-open target="_blank" data-modal-id="trial-license-after-download"}.

### Installation through Direct DLL Download

Alternatively, you can directly download the IronPDF DLL and manually integrate it into your project or the Global Assembly Cache (GAC). You can obtain the DLL from [this link](https://ironpdf.com/packages/IronPdf.zip).

<hr class="separator">

<p class="main-content__segment-title">How to Tutorials</p>

## Generating a PDF from an HTML String in C# .NET

**Tutorial on Converting HTML Strings into PDFs:** Mastering the conversion of HTML strings to PDFs in C# is both a valuable and fulfilling skill.

To achieve this, you can utilize the [`ChromePdfRenderer.RenderHtmlAsPdf`](https://ironpdf.com/object-reference/api/IronPdf.ChromePdfRenderer.html) method, which conveniently transforms any HTML5 string into a PDF document. This **C# HTML to PDF conversion** process is powered by a complete implementation of the Google Chromium engine, seamlessly integrated within the IronPDF DLL.

Here's the paraphrased section of the article and the updated code snippet with absolute URL paths resolved:

```cs
using IronPdf;

// Initialize a new Chrome PDF renderer
var pdfRenderer = new ChromePdfRenderer();
// Render HTML content directly to a PDF file
var document = pdfRenderer.RenderHtmlAsPdf("<h1> Hello IronPdf </h1>");
// Save the generated PDF to a file
document.SaveAs("pixel-perfect.pdf");
```

The `RenderHtmlAsPdf` method comprehensively supports HTML5, CSS3, JavaScript, and Images. Should these resources reside on a local drive, it’s advisable to assign the assets' directory as the second argument to `RenderHtmlAsPdf`.

### Exact Chrome Rendering with IronPDF

IronPDF ensures that your HTML content is faithfully reproduced in the generated PDFs, just as it appears in Chrome.

To aid in this, we provide a comprehensive guide on setting up Chrome to fully debug your HTML. This enables you to ensure that all modifications in your HTML, CSS, and JavaScript reflect accurately in the PDFs generated by IronPDF. You can access this helpful guide by visiting: [How to Debug HTML in Chrome to Create Pixel Perfect PDFs](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).

**BaseUrlPath**:

Here's the paraphrased section of the article, with corrected URL paths:

```cs
using IronPdf;

// Renders image located at C:\MyProject\Assets\image1.png
var pdf = renderer.RenderHtmlAsPdf("<img src='image1.png'/>", @"C:\MyProject\Assets\");
```

All linked CSS stylesheets, images, and JavaScript files will be organized neatly by using `BaseUrlPath`, providing a clean and structured storage. Additionally, it's possible to link to external resources like web-fonts, including Google Fonts and jQuery, by referencing them in your project.

<hr class="separator">

## Convert Web Pages to PDFs

Converting live URLs to PDFs using C# is a straightforward and efficient process. This method also facilitates collaboration by allowing different teams to work separately on PDF design and the backend PDF rendering process.

Here's how you can convert a webpage from Wikipedia into a PDF file:

```cs
using IronPdf;

// Generate a PDF by capturing content from a web URL
var pdfCreator = new ChromePdfRenderer();
var generatedPdf = pdfCreator.RenderUrlAsPdf("https://en.wikipedia.org/wiki/PDF");
generatedPdf.SaveAs("wikipedia.pdf");
```

You'll find that all hyperlinks and HTML forms remain intact within the PDF files created using our C# coding.

When dealing with the rendering of existing web pages, there are several techniques we suggest applying:

### CSS for Print and Screen Media

In the realm of contemporary CSS3, there exist distinct directives tailored for print and screen media types. Users can configure IronPDF to prioritize the rendering of "Print" CSS, which are typically more streamlined yet frequently neglected. Conversely, the default behavior is to render "Screen" CSS, a choice that most [IronPDF](https://ironpdf.com) users prefer due to its intuitive nature.

```cs
using IronPdf;
using IronPdf.Rendering;

// Set the CSS media type to 'Screen' for web-based rendering.
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
// Alternatively, set it to 'Print' for print-ready PDFs.
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
```

Main Page: For a detailed comparison, including visual guides, between Screen and Print CSS media types, please visit [this section](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#decide-to-use-css-media-type-print-or-screen).

### JavaScript Support in IronPDF

IronPDF fully embraces JavaScript, jQuery, and AJAX capabilities. To ensure a complete and accurate rendering of web pages that leverage these technologies, developers can configure IronPDF to [pause until JavaScript or AJAX operations have completed](https://ironpdf.com/how-to/javascript-to-pdf/). This feature allows a faithful capture of dynamic and asynchronously loaded content on your web pages before conversion to PDF.

Here's the paraphrased content for the provided section with appropriate markdown formatting:

```cs
// Enable JavaScript to ensure all scripts are processed before rendering
renderer.RenderingOptions.EnableJavaScript = true;
// Set a render delay to allow time for JavaScript execution prior to PDF generation
renderer.RenderingOptions.WaitFor.RenderDelay(500); // value in milliseconds
```

Here is the paraphrased section with the relative URL path resolved:

-----
We can showcase adherence to JavaScript standards by generating a sophisticated [d3.js JavaScript chord chart](https://bl.ocks.org/mbostock/4062006) using a CSV dataset in the following manner:

Here's the paraphrased section with the URLs resolved:

```cs
using IronPdf;

// Generate a PDF from a live-rendered data chart using d3.js and JavaScript
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
pdfDocument.SaveAs("chart.pdf");
```

### Responsive CSS in .NET

Converting HTML to PDF with responsive CSS in .NET can pose challenges. Responsive web designs are intended for browser display and may not render optimally when converted directly to PDF because IronPDF does not mimic a real browser window within your operating system[Responsive Design in PDFs](https://ironpdf.com/how-to/html-to-pdf-responsive-css/). This often results in responsive elements displaying at their minimum size.

To address this, it's advisable to utilize **Print** CSS media types. Unlike screen CSS, Print CSS is typically designed to be non-responsive and provides a more consistent layout for PDF outputs.

```cs
// Change CSS media type to 'Print' for PDF rendering
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
```

<hr class="separator">

## Creating a PDF from Local HTML Content

IronPDF enables you to convert any local HTML file into a PDF document. This includes all associated assets like CSS, images, and JavaScript, which will be processed as though the file was accessed via the **file://** protocol.

```cs
using IronPdf;

// Generate a PDF from an existing HTML file in C#
var pdfGenerator = new ChromePdfRenderer();
var generatedPdf = pdfGenerator.RenderHtmlFileAsPdf("Assets/TestInvoice1.html");
generatedPdf.SaveAs("Invoice.pdf");
```

This approach benefits developers by providing the ability to preview and test HTML content in a browser while developing. It is advised to use Chrome, since IronPDF's rendering engine is designed to be compatible with this browser.

For transforming XML into PDF documents, consider using XSLT templating to format your XML data for PDF output. Learn more about this process [here](https://ironpdf.com/how-to/xml-to-pdf/).

<hr class="separator">

## Implementing Custom Headers and Footers

Enhancing PDFs with headers and footers during rendering, as well as appending them to existing PDF documents, is seamless with IronPDF.

IronPDF allows you to include straightforward text through the `TextHeaderFooter` class or incorporate elaborate designs with images and HTML using the `HtmlHeaderFooter` class. Whether you're simplifying the documentation with basic headers or enriching it with stylish footers, IronPDF provides versatile classes to accommodate both needs.

```cs
using IronPdf;

// Initialize a new Chrome PDF renderer to create a PDF from HTML content
var pdfRenderer = new ChromePdfRenderer
{
    // Configure rendering options for the PDF
    RenderingOptions =
    {
        MarginTop = 50, // Set the top margin in millimeters
        MarginBottom = 50, // Set the bottom margin in millimeters
        CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print, // Use print CSS media type for rendering
        TextHeader = new TextHeaderFooter
        {
            CenterText = "{pdf-title}", // Center the title in the header
            DrawDividerLine = true, // Include a divider line below the header
            FontSize = 16 // Set the font size for the header text
        },
        TextFooter = new TextHeaderFooter
        {
            LeftText = "{date} {time}", // Display the current date and time on the left of the footer
            RightText = "Page {page} of {total-pages}", // Show page number and total pages on the right of the footer
            DrawDividerLine = true, // Include a divider line above the footer
            FontSize = 14 // Set the font size for the footer text
        }
    }
};

// Render an HTML file as a PDF document
var invoicePdf = pdfRenderer.RenderHtmlFileAsPdf("assets/TestInvoice1.html");
invoicePdf.SaveAs("Invoice.pdf");

// Automatically open the produced PDF to view the outcome
System.Diagnostics.Process.Start("Invoice.pdf");
```

Discover the full range of rendering options detailed in our guide: [How to Use the Rendering Options](https://ironpdf.com/how-to/rendering-options/).

### Creating HTML Headers and Footers

With the `HtmlHeaderFooter` class, you can craft detailed headers and footers employing HTML5. This includes the ability to incorporate images, stylesheets, and hyperlinks to enrich your PDF documents with dynamic content.

```cs
using IronPdf;

// Set up the HTML footer for the PDF document
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = "<div style='text-align:right'><em style='color:#FFC0CB'>Page {page} of {total-pages}</em></div>"
};
```

### Dynamic Content in PDF Headers and Footers

IronPDF allows you to seamlessly integrate dynamic data into the text or HTML of your PDF headers and footers. This is achieved through the use of dynamic placeholders, which update automatically to reflect relevant data such as:

- `{page}` representing the current page number within the PDF.
- `{total-pages}` indicating the total number of pages in the document.
- `{url}` which will show the URL of the PDF if it is rendered from a web page.
- `{date}` for inserting today's date.
- `{time}` to display the current time.
- `{html-title}` to include the `title` attribute from the HTML document being rendered.
- `{pdf-title}` for specifying the document title, which can be adjusted using ChromePdfRenderOptions.

These placeholders allow for the automatic updating of content in headers and footers, making document customization both dynamic and straightforward.

<hr class="separator">

## Configuration Settings for HTML to PDF Conversion in C#

The process of converting HTML content to PDF can vary widely based on user and client expectations regarding the final PDF's appearance.

Within the `ChromePdfRenderer` class, there is a `RenderingOptions` property. This powerful feature allows developers to customize the conversion process to meet specific requirements.

For instance, if the need arises to focus solely on "print" type CSS3 directives for the rendering, this can be easily configured:

```cs
using IronPdf;

// Set CSS media type to 'Print' for PDF rendering
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
```

Adjusting the print margins may be necessary to enhance the whitespace of your page, allowing for the inclusion of prominent headers or footers, or to set no margins at all, which is particularly useful for commercial printing projects like brochures or posters.

```cs
using IronPdf;

// Set the top and bottom margins of the PDF document
renderer.RenderingOptions.MarginTop = 50; // Set top margin in millimeters
renderer.RenderingOptions.MarginBottom = 50; // Set bottom margin in millimeters
```

```cs
using IronPdf;

renderer.RenderingOptions.PrintHtmlBackgrounds = true;
```

```cs
using IronPdf;

// Enable the rendering of backgrounds in HTML elements when converting to PDF
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
```

You can also configure your output PDFs to be displayed in various virtual paper sizes, encompassing both portrait and landscape orientations along with custom dimensions, which can be specified in either millimeters or inches.

Here's the paraphrased content, with updated URLs:

```cs
using IronPdf;
using IronPdf.Rendering;

// Set the paper size to A4 and orientation to landscape
renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
```

Delve into the full spectrum of rendering capabilities by visiting the comprehensive guide: "[Learn about Rendering Options](https://ironpdf.com/how-to/rendering-options/)."

<hr class="separator">

## Implementing HTML Templating for PDF Generation

Creating multiple PDFs from templates is a recurring task for developers in the online and website sphere.

With IronPDF, instead of directly templating within the PDF, you can apply existing, robust technologies to HTML templating. When this template is populated with data, either from a query string or a database, it results in a dynamically crafted PDF file.

For basic scenarios, leveraging the C# `String.Format` method proves to be an efficient approach. This provides a straightforward way to inject data into the HTML before converting it to a PDF.

```cs
using System;

// Simple formatting of strings in C#
String.Format("<h1>Welcome, {0}!</h1>", "World");
```

For lengthy HTML documents, it's possible to utilize arbitrary placeholders, like `[[NAME]]`, which can be substituted with actual data subsequently.

In the illustrated example below, three personalized PDFs are generated for different users:

```cs
var htmlTemplate = "<p>[[NAME]]</p>";
var names = new[] { "John", "James", "Jenny" };
foreach (var name in names)
{
    var htmlInstance = htmlTemplate.Replace("[[NAME]]", name);
    var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
    pdf.SaveAs(name + ".pdf");
}
```

Here's the paraphrased section of C# code you requested:

```cs
// Define the HTML template with a placeholder
var htmlTemplate = "<p>[[NAME]]</p>";
// List of names to personalize the PDFs
var names = new[] { "John", "James", "Jenny" };
// Loop through each name in the list
foreach (var name in names)
{
    // Replace the placeholder with the actual name
    var personalizedHtml = htmlTemplate.Replace("[[NAME]]", name);
    // Generate the PDF from the personalized HTML
    var pdf = renderer.RenderHtmlAsPdf(personalizedHtml);
    // Save the PDF with a unique name
    pdf.SaveAs($"{name}.pdf");
}
```

This code snippet defines an HTML template and substitutes a placeholder with each name from a list to create personalized PDF documents for each individual. Each generated PDF is then saved using the name of the individual as the filename.

### Advanced Templating Using Handlebars.NET

For complex PDF generation that integrates C#'s data structures into HTML, one efficient approach is to employ the Handlebars templating engine.

Handlebars allow for dynamic HTML generation from various C# sources like objects and database records. This is especially useful in scenarios where the output is dynamic in nature, for example in invoice generation where the number of data rows might vary.

To start leveraging this capability, you'll need to include the [Handlebars.NET NuGet package](https://www.nuget.org/packages/Handlebars.NET/) into your project. This initial setup is essential for enabling advanced templating features in your applications.

Here is the paraphrased section of the article:

```cs
var htmlTemplate =
    @"<div class=""article"">
        <h1>{{pageTitle}}</h1>
        <div class=""content"">
            {{pageContent}}
        </div>
    </div>";
var handlebarsTemplate = Handlebars.Compile(htmlTemplate);

var pageData = (pageTitle: "My First Article", pageContent: "Welcome to my blog!");

var htmlOutput = handlebarsTemplate(pageData);

/* This would produce:
<div class="article">
  <h1>My First Article</h1>
  <div class="content">
    Welcome to my blog!
  </div>
</div>
*/
```

To convert HTML into a PDF, we can effortlessly employ the `RenderHtmlAsPdf` method.

Here is the paraphrased section with resolved URL paths:

```cs
using IronPdf;

// Create a Chrome PDF renderer instance
var pdfRenderer = new ChromePdfRenderer();

// Render the HTML content into a PDF document
var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlInstance);

// Save the newly created PDF document to a file
pdfDocument.SaveAs("HandlebarsOutput.pdf");
```

Discover more about the Handlebars HTML templating standard and its application in C# by visiting [Handlebars.NET on GitHub](https://github.com/rexm/Handlebars.NET).

### Implementing Page Breaks in HTML5 for PDFs

It's often necessary to manage pagination within PDF documents to ensure a polished and coherent arrangement. 

One of the simplest solutions for inserting page breaks into your documents involves using a not-so-well-known CSS technique that effectively introduces page breaks into any HTML that is destined to be printed.

The HTML code segment you provided dictates a page break in a document. It's a practical tool when you need to ensure content begins on a new page, particularly in printable documents. Here’s a cleaner and more sophisticated way to implement page breaks in your HTML:

```html
<!DOCTYPE html>
<html>
<head>
  <style type="text/css" media="print">
    .new-page {
      break-after: page; /* Ensures content following this element starts on a new page */
      break-inside: avoid; /* Avoid breaking elements inside */
    }
  </style>
</head>
<body>
  <div class="new-page">
    Content at the end of the page here.
  </div>
  <div class="new-page">
    Content starting on a new page here.
  </div>
</body>
</html>
``` 

This structured method not only applies the page break effectively but also improves maintainability and readability of your HTML document.

The provided HTML is functional, yet it doesn't align with best practices. We recommend modifying the media attribute as shown in the example below for a clean and structured layout of multipage HTML content.

```html
<!DOCTYPE html>
<html>
  <head>
    <style type="text/css" media="print">
      /* Styling for page breaks to ensure each section starts on a new page */
      .page-break {
        page-break-after: always;
        page-break-inside: avoid;
      }
    </style>
  </head>
  <body>
    <section class="page-break">
      <h1>Page Number One</h1>
    </section>
    <section class="page-break">
      <h1>Page Number Two</h1>
    </section>
    <section class="page-break">
      <h1>Page Number Three</h1>
    </section>
  </body>
</html>
```

For further guidance and helpful techniques on incorporating page breaks in your PDFs, explore the detailed guide available [here](https://ironpdf.com/how-to/html-to-pdf-page-breaks/).

<hr class="separator">

## Appending a Cover Page to a PDF Document

IronPDF simplifies the process of merging PDF files, particularly when it comes to incorporating a front or back cover into an existing PDF.

To implement this, start by rendering a desired cover page. Afterward, employ the `PdfDocument.Merge()` method to seamlessly integrate this page with your existing PDF document.

```cs
using IronPdf;

// Initiating the PDF rendering process for a specific URL.
var newPdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
// Merge the newly created PDF with an existing cover page PDF
var mergedPdf = PdfDocument.Merge(new PdfDocument("CoverPage.pdf"), newPdf).SaveAs("Combined.Pdf");
```

Here's the paraphrased section with the URL resolved to `ironpdf.com`:

-----
You can view a complete coding sample here: [PDF Cover Page Code Example](https://ironpdf.com/examples/pdf-cover-page/)

<hr class="separator">

## Watermark Integration

IronPDF empowers you to enhance your PDF documents with watermarks, a valuable feature for [C# PDF](https://ironpdf.com/use-case/csharp-pdf/) operations. Watermarks can be beneficial in labeling each page with critical designations such as "confidential" or "sample".

Here's the paraphrased section you requested with fully resolved URLs from Iron Software:

```cs
using IronPdf;
using IronPdf.Editing;

// Initialize a new Chrome PDF Renderer to render a URL as a PDF document.
var pdfRenderer = new ChromePdfRenderer();
// Render the PDF from the NuGet page for IronPdf.
var document = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
// Apply a watermark to each page with the text 'SAMPLE' in bold red, centered in the middle.
// Additionally, the watermark is clickable.
document.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 0, VerticalAlignment.Middle, HorizontalAlignment.Center);
// Save the watermarked PDF to the specified path.
document.SaveAs(@"C:\Path\To\Watermarked.pdf");
```

A comprehensive code sample is available at this link: [PDF Watermarking Code Example](https://ironpdf.com/examples/pdf-watermarking/)

<hr class="separator">

## Access the Complete C# Tutorial Source Code

The entire **free C# source code** for converting HTML to PDF is available for download as a compressed Visual Studio 2022 project. This project utilizes its rendering capabilities to produce PDF documents in C#.

[Download the full tutorial as a Visual Studio project](https://ironpdf.com/downloads/CSharp-Html-To-Pdf-Tutorial.zip)

This complimentary download provides all the necessary components to generate a PDF from HTML, including functional C# PDF sample code for:

1. Transforming an HTML string into a PDF in C#
2. Converting HTML files to PDF in C#, inclusive of CSS, JavaScript, and image support
3. Utilizing a URL for HTML to PDF conversions in C#
4. Examples of editing PDF settings in C#
5. Drawing JavaScript canvas graphs, such as d3.js, into a PDF
6. Overview of the PDF Library specifically designed for C# applications

### Class Reference Details

Developers might find the `IronPdf.PdfDocument` Class Reference especially useful:




[Explore the IronPdf.PdfDocument Class Reference](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html)




This class model illustrates the capabilities available for handling PDF files, which include:

* Encryption and secure password protection
* Modifying or appending new HTML content
* Augmentation with images, either in the foreground or background
* Combining, dividing, shortening, or extending PDF documents at page-level precision
* Optical Character Recognition (OCR) to convert images to editable text and extract images

<hr class="separator">

## Integrating HTML to PDF Conversion in Blazor

Enabling HTML to PDF capabilities within your Blazor server applications is straightforward:

1. Start with a new Blazor server project, or integrate into an existing one.
2. Incorporate the IronPDF library into your application through the NuGet package manager.
3. Introduce a new Razor Component or modify an existing one.
4. Insert an `InputTextArea` component and connect it to the IronPDF library.
5. Allow IronPDF to handle the conversion process and manage the deployment.

For a comprehensive, detailed guide complete with visuals and example code, refer to the full tutorial available [here](https://ironpdf.com/how-to/blazor-tutorial/).

<img src="/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp"/>

<hr class="separator">

## Comparison with Other PDF Libraries

For developers considering HTML to PDF transformations, numerous free open-source libraries like iTextSharp and PdfSharp are accessible on platforms such as GitHub. These libraries are freely available, presenting an appealing choice for developers who wish to forego buying a library. However, employing these solutions in .NET Core projects without a comprehensive library may pose challenges, particularly in accurately rendering contemporary web standards like HTML5, CSS3, and JavaScript.

In contrast, IronPDF offers a holistic, feature-enriched, and straightforward integration solution for converting HTML to PDF. Open-source alternatives typically necessitate more manual configuration and may not support some advanced features. IronPDF provides a seamless, ready-to-use experience, empowering .NET Core developers to create PDFs effortlessly, without the intricacies often associated with manual setup and configuration.

<h3>PDFSharp</h3>

**PDFSharp** is an open-source .NET library provided at no cost, facilitating the logical editing and creation of PDF files.

In contrast, IronPDF distinguishes itself by incorporating an integrated Web Browser, enabling the accurate generation of PDFs from HTML, CSS, JavaScript, and image files.

Unlike PDFSharp, which is structured around the technical aspects of PDFs, IronPDF is designed around practical applications, making it more straightforward and user-friendly for developers.

While PDFSharp is capable of converting HTML content into PDFs, its functionality in handling HTML to PDF conversion is somewhat restricted, primarily limited to .html files.

<h3>wkhtmltopdf</h3>

**wkhtmltopdf** is an open-source library, available for free and developed in C++, which facilitates the rendering of HTML content into PDF documents.

One significant distinction between wkhtmltopdf and IronPDF lies in the language and compatibility: IronPDF is crafted in C# and designed to be stable and thread-safe for .NET applications and websites.

Furthermore, IronPDF maintains comprehensive support for modern web standards such as CSS3 and HTML5, in contrast to wkhtmltopdf, which lags nearly ten years behind in terms of technology.

Moreover, the IronPDF API is much more robust and comprehensive compared to wkhtmltopdf’s. It allows extensive capabilities for PDF manipulation including editing, compressing, importing, exporting, signing, securing, and adding watermarks to documents.

While wkhtmltopdf offers a stable environment for HTML to PDF conversion, it relies on an outdated rendering engine that does not support the latest web technologies.

<h3>iTextSharp</h3>

iTextSharp, an open-source adaptation of the iText Java library, can indeed transform HTML to PDF. However, its capabilities are somewhat constrained by Java's available functionalities or by relying on the wkhtmltopdf conversion tool under an LGPL license.

IronPDF provides a superior solution for HTML to PDF conversion in C# by incorporating a modern Chrome-based browser engine, unlike iTextSharp's outdated wkhtmltopdf dependency. This difference results in more precise and advanced rendering of HTML content into PDFs.

Furthermore, IronPDF's licensing model offers explicit terms for both commercial and private use, contrasting with iTextSharp's AGPL license which mandates that the complete source code be freely accessible to all users, including those online.

For an in-depth comparison between iTextSharp and IronPDF, please visit our extensive C# documentation page on the subject at [iTextSharp Differences](https://ironpdf.com/blog/compare-to-other-components/itextsharp/).

<h3>Other Commercial Libraries</h3>

*Aspose PDF*, *Spire PDF*, *EO PDF*, and *SelectPdf* represent alternative commercial PDF libraries in the .NET arena. IronPDF, however, distinguishes itself with its robust features, broad compatibility, meticulously crafted documentation, and competitive pricing. For a detailed comparison of IronPDF against these competitors and the Chrome rendering engine, visit [this link](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#what-is-ironpdf-s-chrome-renderer).

<hr class="separator">

## HTML to PDF Tutorial Video Overview

You can access detailed video guidance on HTML to PDF conversion with IronPDF by visiting this link: [Learn how to open PDFs in Chrome Without Downloading](https://knowledge.workspace.google.com/kb/how-to-open-a-pdf-file-without-downloading-it-000002252). The video tutorial provides an insightful walkthrough, helping you understand the process more comprehensively.

<a name ="video"></a>

You can learn how to view a PDF in Chrome directly without needing to download the file by following this [link](https://knowledge.workspace.google.com/kb/how-to-open-a-pdf-file-without-downloading-it-000002252).

<hr class="separator">

<h4 class="tutorial-segment-title">Tutorial Quick Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/brand-visual-studio.svg">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Download this Tutorial as C# Source Code</h3>
      <p>The full free HTML to PDF C# Source Code for this tutorial is available to download as a zipped Visual Studio project file.</p>
      <a class="btn btn-white3" href="downloads/CSharp-Html-To-Pdf-Tutorial.zip">
        <i class="fa fa-cloud-download"></i> Download</a>
      </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-8">
      <h3>Explore this Tutorial on GitHub</h3>
      <p>The source code for this project is available in C# and VB.NET on GitHub.</p>
      <p>Use this code as an easy way to get up and running in just a few minutes. The project is saved as a Microsoft Visual Studio 2017 project, but is compatible with any .NET IDE.</p>
      <a class="doc-link" href="https://github.com/iron-software/c-sharp-html-to-pdf-tutorial" target="_blank">C# HTML to PDF <i class="fa fa-chevron-right"></i></a>
      <a class="doc-link" href="https://github.com/iron-software/vb.net-html-to-pdf-tutorial" target="_blank">VB.NET HTML to PDF <i class="fa fa-chevron-right"></i></a>
    </div>
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/github-icon.svg">
      </div>
    </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/html-to-pdf-icon.svg" width="214" height="141">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Download the C# PDF Quickstart guide</h3>
      <p>To make developing PDFs in your .NET applications easier, we have compiled a quick-start guide as a PDF document. This "Cheat-Sheet" provide quick access to common functions and examples for generating and editing PDFs in C# and VB.NET - and may help save time in getting started using IronPDF in your .NET project.</p>
      <a class="btn btn-white3" target="_blank" href="/csharp-pdf.pdf">
        <i class="fa fa-cloud-download"></i> Download</a>
      </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-8">
      <h3>View the API Reference</h3>
      <p>Explore the API Reference for IronPDF, outlining the details of all of IronPDF’s features, namespaces, classes, methods fields and enums.</p>
      <a class="doc-link" href="/object-reference/api/IronPdf.html" target="_blank">View the API Reference <i class="fa fa-chevron-right"></i></a>
    </div>
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
  </div>
</div>

