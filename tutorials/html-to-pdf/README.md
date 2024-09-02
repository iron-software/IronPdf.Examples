# HTML to PDF Conversion in C#

At IronPDF, we prioritize ensuring that the PDFs created are not only flawless but also meet the exact expectations of our users. This tutorial will guide you through the process of creating an HTML to PDF converter using C# for your applications, websites, and projects. We aim to develop a converter that produces PDFs exactly mirroring the PDF output you see in Google Chrome.

### Utilizing IronPDF in C#

With the IronPDF C# library, you will learn to:

* Generate PDFs directly from HTML strings or files, integrating seamlessly within a C# application.
* Implement PDF editing and creation capabilities using C#.
* Transform web URLs into PDFs while preserving the original formatting.

<hr class="separator">
<p class="main-content__segment-title">Overview</p>




<br class="main-article__clear-both">

## C# & VB.NET HTML to PDF Conversion

Developing PDF files through programming within the .NET ecosystem can often be challenging. The design of the PDF file format is primarily tailored for printers rather than software developers. Moreover, the native libraries within C# for handling PDF creation are limited, and most third-party libraries available are not directly operational, complicating tasks with their need for extensive coding just to perform basic functions.

For this tutorial, we will employ IronPDF from Iron Software, a prominent library for creating and editing PDFs in C#. IronPDF offers extensive features for PDF manipulation and creation and is engineered to work right out of the box, simplifying processes with minimal code and is equipped with [superior documentation detailing over 50 features](https://ironpdf.com/features/). Additionally, IronPDF provides robust support for **.NET 8, .NET 7, .NET 6, and .NET 5**, along with .NET Core, Standard, and Framework across multiple platforms including Windows, macOS, Linux, Docker, Azure, and AWS.

Using C# coupled with IronPDF, integrating PDF creation functionality, such as [generating a PDF document](https://ironpdf.com/blog/using-ironpdf/csharp-generate-pdf-tutorial/) or performing [HTML to PDF conversions](https://ironpdf.com/examples/using-html-to-create-a-pdf/), becomes intuitive and efficient, leveraging IronPDF’s sophisticated Chrome Renderer that utilizes existing HTML assets for most of the PDF design and layout.

This approach to dynamic PDF creation with HTML5 in .NET is versatile and can be seamlessly integrated into various applications including console apps, Windows Forms, WPF, and web applications including MVC.

**Additionally, IronPDF features the capability to debug HTML content with Chrome for creating pixel-perfect PDFs. More details on setting this up can be accessed in a special [tutorial here](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).**

<h3>VB.NET : Convert HTML to PDF</h3>

IronPDF is designed as a C# library that simplifies the process of PDF generation in C#, F#, and VB.NET across both .NET Core and .NET Framework. This enables .NET developers to continue using familiar programming languages without the need to adopt unfamiliar file formats or APIs, streamlining the creation of dynamic PDF documents directly from their applications.

To discover more about utilizing IronPDF with **VB.NET**, please consult our [guide](https://ironpdf.com/how-to/vb-net-pdf/).

For detailed insights on implementing IronPDF in **F#** applications, refer to our [guide](https://ironpdf.com/how-to/fsharp-pdf-library-html-to-pdf/).

<h3>IronPDF Features:</h3>

Here's the paraphrased section:

* Creating PDF documents from various sources including HTML, URLs, JavaScript, CSS, and various image formats.
  
* Incorporating elements such as headers and footers, digital signatures, attachments, along with options for encryption and securing documents.

* Enhancing performance through comprehensive support for Multithreading and Asynchronous operations.

<hr class="separator">

<p class="main-content__segment-title">Step 1</p>

Here's the paraphrased section with updates and link resolutions to ironpdf.com:

-----
## How to Install the HTML to PDF Converter in C#

Set up your development environment with IronPDF's library to integrate PDF generation capabilities into your C# applications.

### Using Visual Studio's NuGet Package Manager

In Visual Studio, right-click on the project in the Solution Explorer and choose `Manage NuGet Packages...`. Search for `IronPdf` and install the latest version. Confirm any prompts that appear to ensure a successful installation. This approach is equally efficient for VB.NET projects.

```shell
Install-Package IronPdf
```

### IronPDF on the NuGet Official Site

For detailed information about IronPDF's compatibility, features, and more, visit the NuGet official website at [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf).

### Direct DLL Installation

Alternatively, you can directly download and install the IronPDF DLL. Download it from [IronPDF's DLL package](https://ironpdf.com/packages/IronPdf.zip) and manually integrate it into your project or the Global Assembly Cache (GAC) on your system.

-----

### NuGet Package Manager in Visual Studio

In Visual Studio, navigate to your project's Solution Explorer, right-click, and choose `Manage NuGet Packages...`. Search for IronPDF and select to install the latest version into your project. Approve any dialog prompts that appear during the installation. This method is equally effective for VB.NET projects as well.

```shell
# Install the package via the NuGet command line
Install-Package IronPdf
```

### IronPDF on the NuGet Website

To explore the full suite of features, system compatibility, and download options for IronPDF, visit the official page on the NuGet website: [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf){:target="_blank"}

### Manual DLL Installation

Alternatively, you can directly install the IronPDF DLL. You can manually download and install IronPDF to your project or GAC by accessing the following link: [https://ironpdf.com/packages/IronPdf.zip](https://ironpdf.com/packages/IronPdf.zip).

<hr class="separator">

<p class="main-content__segment-title">How to Tutorials</p>

## Creating PDFs from HTML Strings in C# .NET

**How to: Transform HTML Strings into PDFs?** Mastering the ability to *generate PDF documents in C#* is both highly effective and beneficial.

You can effortlessly convert any HTML5 string into a PDF document using the [`ChromePdfRenderer.RenderHtmlAsPdf`](https://ironpdf.com/object-reference/api/IronPdf.ChromePdfRenderer.html) method. This process of **C# HTML to PDF transformation** leverages a complete version of the Google Chromium engine, seamlessly integrated within the IronPDF library.

Here’s a revised version of the provided C# code snippet, aimed to accomplish similar HTML to PDF conversion tasks using IronPdf's capabilities:

```cs
// Reference IronPdf namespace
using IronPdf;

// Instantiate the PDF renderer
var pdfRenderer = new ChromePdfRenderer();

// Convert HTML code to a PDF document
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");

// Save the generated PDF to a file
pdfDocument.SaveAs("perfectly-rendered.pdf");
```

This code achieves the same result but with slight modifications in variable names and string content to make it distinct and easy to understand.

The `RenderHtmlAsPdf` method comprehensively supports HTML5, CSS3, JavaScript, and image files. If these resources are stored locally on your hard disk, it's advisable to specify the assets' directory as the second argument in the `RenderHtmlAsPdf` method. This ensures that all local resources are correctly accessed and rendered.

### Precise Rendering of HTML Using IronPDF Mimics Chrome Output

IronPDF provides an accurate rendition of your HTML content, ensuring that it matches the appearance in Google Chrome. This feature is crucial for ensuring that your edits in HTML, CSS, and JavaScript are reflected perfectly in your final PDF document.

For a comprehensive guide on setting up Chrome for effective HTML debugging, ensuring your changes are as accurate as possible, see our detailed tutorial: [How to Debug HTML in Chrome to Create Pixel Perfect PDFs](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).

#### `BaseUrlPath`:

```cs
using IronPdf;

// Renders the image located at C:\MyProject\Assets\image1.png
var pdf = renderer.RenderHtmlAsPdf("<img src='image1.png'/>", @"C:\MyProject\Assets\");
```

All CSS stylesheets, images, and JavaScript files you use will be relative to the `BaseUrlPath`, maintaining a tidy and systematic structure. Additionally, it's possible to link to images, stylesheets, and other resources hosted online, including web-fonts like Google Fonts and libraries such as jQuery.

<hr class="separator">

## Convert URL to PDF

**(URL to PDF Conversion)**

Converting web pages to PDF documents using C# is both swift and straightforward. It enables different teams to concurrently handle the design of PDFs and the backend processing.

Here's how we can generate a PDF from a webpage on Wikipedia using C#:

Here's the paraphrased section with the URL paths resolved:

```cs
using IronPdf;

// Generate a PDF from a specific URL
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/PDF");
pdfDocument.SaveAs("wikipedia.pdf");
```

When you generate a PDF using our C# code, you'll find that it retains all hyperlinks and HTML forms from the source content.

Additionally, there are several techniques we recommend when converting existing web pages to PDF:

### Print and Screen CSS3 Options

CSS3 offers separate directives for both screen and print media. This allows us to guide IronPDF to display "Print" style CSS, which is usually more simplified but can often be overlooked in favor of the default "Screen" style CSS. Most users of [IronPDF](https://ironpdf.com) find the screen default to be the most natural to work with.

Here is a paraphrased version of the provided C# code snippet with absolute URL paths:

```cs
// Import the required namespaces from IronPdf
using IronPdf;
using IronPdf.Rendering;

// You can set the CSS media type to 'Screen' for rendering web styles
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Screen;
// Alternatively, set it to 'Print' for styles intended for printing
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
```

Main Page: For a detailed comparison featuring images of both Screen and Print CSS, please visit [this comprehensive guide](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#decide-to-use-css-media-type-print-or-screen).

### JavaScript Integration

IronPDF is fully compatible with JavaScript, jQuery, and AJAX. To ensure a web page is fully loaded before it's captured as a PDF, you can configure [IronPDF to delay rendering](https://ironpdf.com/how-to/javascript-to-pdf/) until after all JavaScript or AJAX content has finished executing. This ensures that the resulting PDF accurately reflects the dynamic content of the page.

Here is the paraphrased version of the provided C# code snippet, with absolute paths for the links:

```cs
// Enable JavaScript for the rendering process
renderer.RenderingOptions.EnableJavaScript = true;

// Set a delay to allow JavaScript execution before rendering
renderer.RenderingOptions.WaitFor.RenderDelay(500); // Delay in milliseconds
```

Here's a paraphrased version of the section you provided, with the URL path resolved:

-----
We can showcase adherence to JavaScript standards by creating a sophisticated **[d3.js JavaScript chord chart](https://bl.ocks.org/mbostock/4062006)** from a CSV file as demonstrated below:

```cs
using IronPdf;

// Generate a PDF document from a live-rendered d3.js dataset, using JavaScript
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
pdfDocument.SaveAs("data-visualization-chart.pdf");
```

### Responsive CSS in .NET

Utilizing responsive CSS in .NET! [Responsive web pages](https://ironpdf.com/how-to/html-to-pdf-responsive-css/) are formatted for optimal viewing in browsers. However, IronPDF does not launch an actual browser interface within your server's operating system. This may result in responsive elements displaying at their minimum size.

To address this, we advise opting for **Print** CSS media types. Generally, Print CSS is configured not to be responsive.

Certainly! Here's the paraphrased section of the article with resolved relative URL paths:

```cs
// Set the CSS media type to print for rendering the PDF
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
```

<hr class="separator">

## Creating a PDF from an HTML File

It's also possible to convert any HTML page saved on your hard drive directly to a PDF. All associated assets, including CSS, images, and JavaScript files, will be processed as though the HTML file were being viewed locally via the **file://** protocol.

Here's the paraphrased section of the C# code, with the relative URL paths resolved appropriately:

```cs
using IronPdf;

// Initialize the PDF renderer from IronPDF library to create a PDF from HTML file in C#
var pdfRenderer = new ChromePdfRenderer();
// Render a specific HTML file into a PDF
var pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("Assets/TestInvoice1.html");
// Save the generated PDF to a file
pdfDocument.SaveAs("Invoice.pdf");
```

This approach offers the benefit of letting developers preview HTML content within a browser while developing. We suggest using Chrome, as IronPDF's rendering engine is modeled after this browser.

To transform [XML to PDF, XSLT templating can be utilized to convert your XML content into PDF format](https://ironpdf.com/how-to/xml-to-pdf/).

<hr class="separator">

## Customizing PDF Headers and Footers

IronPDF allows you to enhance your PDF documents by adding headers and footers either during the PDF generation process or to already existing PDF files.

### Utilizing IronPDF for Headers and Footers

IronPDF provides two main classes to incorporate headers and footers into your PDF documents:
- **`TextHeaderFooter`**: This class is used for adding basic text-only headers and footers.
- **`HtmlHeaderFooter`**: This class is suitable for creating headers and footers that include rich HTML content, images, and styles.

```cs
using IronPdf;

// Initialize the PDF renderer with custom settings
var pdfRenderer = new ChromePdfRenderer
{
    RenderingOptions =
    {
        // Set top and bottom margins
        MarginTop = 50, // millimeters
        MarginBottom = 50,
        // Use Print media type for CSS rendering
        CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print,
        // Configure text header with PDF title and divider line
        TextHeader = new TextHeaderFooter
        {
            CenterText = "{pdf-title}",
            DrawDividerLine = true,
            FontSize = 16 // size in points
        },
        // Configure text footer with date, time and pagination
        TextFooter = new TextHeaderFooter
        {
            LeftText = "{date} {time}",
            RightText = "Page {page} of {total-pages}",
            DrawDividerLine = true,
            FontSize = 14 // size in points
        }
    }
};

// Generate a PDF from an HTML file located in the project's assets
var generatedPdf = pdfRenderer.RenderHtmlFileAsPdf("assets/TestInvoice1.html");
generatedPdf.SaveAs("Invoice.pdf");

// Open the generated PDF file for viewing
System.Diagnostics.Process.Start("Invoice.pdf");
```

### Enhanced HTML Headers and Footers

The `HtmlHeaderFooter` class enables the creation of sophisticated headers and footers composed of HTML5 elements. This functionality supports the inclusion of images, CSS, and clickable links, offering enhanced design possibilities for your document headers and footers.

Here's the paraphrased section with the relative URL paths resolved against ironpdf.com:

```cs
using IronPdf;

// Add a custom HTML footer to each page of the PDF
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = "<div style='text-align:right'><em style='color:pink'>Page {page} of {total-pages}</em></div>"
};
```

### Customizing PDF Headers and Footers with Dynamic Content

In PDF documents, dynamic content can be seamlessly integrated into headers and footers using a robust "mail-merge" approach. By employing placeholders, you can inject live data directly from your application into the PDF output. Here are the types of dynamic placeholders you can use:

- `{page}`: Displays the current page number within the PDF.
- `{total-pages}`: Shows the total page count of the document.
- `{url}`: Includes the URL from which the PDF was rendered, if applicable.
- `{date}`: Inserts the current date.
- `{time}`: Adds the exact time of PDF generation.
- `{html-title}`: Captures the `title` attribute from the HTML source.
- `{pdf-title}`: Sets the title of the PDF document, configurable through the ChromePdfRenderOptions. 

By leveraging these placeholders, the flexibility and contextual relevance of your PDF documents increase, thereby enhancing their utility and professionalism.

<hr class="separator">

## Configuration Settings for C# HTML to PDF Conversion

Rendering PDFs precisely as per client expectations involves various subtleties. The `ChromePdfRenderer` class provides a `RenderingOptions` property, enabling customization of rendering preferences.

For instance, one might opt to adhere solely to CSS3 directives designed for print media: 
```cs
using IronPdf;

renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;
```

```cs
using IronPdf;

// Set the CSS media type for rendering to 'Print'
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
```

We might want to adjust the size of our page margins to include more whitespace, which can accommodate larger headers or footers. Alternatively, setting the margins to zero is ideal for commercial print jobs involving brochures or posters:

Here's a paraphrased version of the given section from the article, with relative URL paths resolved:

```cs
using IronPdf;

// Set top and bottom margins for the document
renderer.RenderingOptions.MarginTop = 50;  // Margin at the top in millimeters
renderer.RenderingOptions.MarginBottom = 50;  // Margin at the bottom in millimeters
```

```cs
using IronPdf;

renderer.RenderingOptions.PrintHtmlBackgrounds = true;
```

This toggle allows developers to control whether to display background colors and images from HTML content when rendering PDFs.

Here's the paraphrased version of the provided code snippet, with the relative URL resolved:

```cs
using IronPdf;

// Enable the printing of backgrounds in HTML content
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
```

Furthermore, you can configure the output PDFs to be produced in any virtual paper size you prefer. This includes options for portrait or landscape orientations, as well as custom dimensions that can be specified in millimeters or inches.

```cs
using IronPdf;
using IronPdf.Rendering;

// Set the paper size to A4
renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
// Set the orientation of the paper to landscape
renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
```

Comprehensive details and full documentation for the HTML [C# PDF Creator](https://ironpdf.com/use-case/csharp-pdf-creator/) settings can be accessed via the [official API documentation for IronPdf.ChromePdfRenderer](https://ironpdf.com/object-reference/api/IronPdf.ChromePdfRenderer.html).

The extensive list of PDF printing options includes:

* **CreatePdfFormsFromHtml**: Transforms all HTML form elements into editable PDF forms.
* **CssMediaType**: Select between `Screen` or `Print` CSS Styles and StyleSheets. For more detailed information, refer to our [comprehensive tutorial with visuals](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).
* **CustomCssUrl**: Facilitates the application of a custom CSS style-sheet on HTML before its conversion to PDF. This could either be from a local file path or a remote URL.
* **EnableMathematicalLaTex**: Allows toggling the rendering of mathematical LaTeX elements on or off.
* **EnableJavaScript**: Activates JavaScript and JSON execution prior to rendering the page, which is ideal for applications involving Ajax or Angular. Further details can be found in the [RenderDelay section](https://ironpdf.com/troubleshooting/render-delay-timeout/).
* **Javascript**: Specifies a custom script to run after the HTML has fully loaded but just before the PDF rendering starts.
* **JavascriptMessageListener**: Defines a callback function to be called when a JavaScript console message is generated in the browser.
* **FirstPageNumber**: Allows setting the starting page number for PDF headers and footers.
* **TableOfContents**: Automatically creates a table of contents at the specified HTML location with an id of "ironpdf-toc".
* **TextHeader**: Configures the header for each PDF page using plain text, supporting mail-merge features.
* **TextFooter**: Similarly, this sets the plain text footer content for every PDF page, with support for mail-merge.
* **HtmlHeader**: Assigns the header of every PDF page using HTML content.
* **HtmlFooter**: Sets the HTML content for the footer of every PDF page.
* **MarginBottom**: Adjusts the bottom paper margin in millimeters, can be set to zero for border-less and commercial printing needs.
* **MarginLeft**: Left paper margin, in millimeters.
* **MarginRight**: Right paper margin, in millimeters.
* **MarginTop**: Top paper margin, in millimeters, adjustable to zero for border-less printing.
* **UseMarginsOnHeaderAndFooter**: Determines if the document’s main margins are applied to headers and footers.
* **PaperFit**: Manages how content is fitted to the virtual paper pages in a PDF, with options including default Chrome behavior, zoomed views, responsive CSS3 layouts, and scale-to-page settings.
* **PaperOrientation**: Controls the orientation of the new document’s paper. Further explanation and code samples are found [here](https://ironpdf.com/examples/pdf-page-orientation/).
* **PageRotation**: Rotate pages in an existing document. More details [here](https://ironpdf.com/examples/pdf-page-orientation/).
* **PaperSize**: Defines the paper size for PDF output as types listed under `System.Drawing.Printing.PaperKind`.
* **SetCustomPaperSizeinCentimeters**: Establish a custom paper size in centimeters.
* **SetCustomPaperSizeInInches**: Define the paper size in inches.
* **SetCustomPaperSizeinMilimeters**: Sets the paper size in millimeters.
* **SetCustomPaperSizeinPixelsOrPoints**: Determine the paper size in pixels or printer points.
* **ForcePaperSize**: Enforce exact page sizes as specified in PaperSize by resizing the page after HTML to PDF conversion.
* **PrintHtmlBackgrounds**: Print background colors and images from HTML.
* **GrayScale**: Outputs the PDF in black and white format.
* **Timeout**: Configures the timeout setting for rendering in seconds.
* **WaitFor**: Manages various timing mechanisms for rendering, useful for JavaScript, Ajax, or animation rendering:
  * **PageLoad**: Renders immediately with no waiting.
  * **RenderDelay**: Allows setting a specific delay time.
  * **Fonts**: Delays rendering until all fonts have loaded.
  * **JavaScript**: Delays rendering until a specified JavaScript function executes.
  * **HTML elements**: Wait for certain HTML elements to load based on IDs, names, tags, or query selectors.
  * **NetworkIdle**: Waits for network activity to settle before rendering.
* **Title**: Specifies the meta-data title for the PDF document but isn't mandatory.
* **InputEncoding**: Designates the character input encoding.
* **RequestContext**: Sets up specific request contexts for rendering.

<hr class="separator">

## HTML Templating for PDFs

Creating batches of PDFs is a frequent necessity for developers working on internet and websites. Instead of manipulating the PDF format directly, IronPDF enables you to utilize established technologies to template HTML. By merging these HTML templates with data from a query string or a database, dynamic PDF documents are automatically generated.

For basic scenarios, leveraging the `String.Format` method in C# proves to be a straightforward and efficient approach. This technique allows for quick templating of HTML for PDF transformation.

Below is a paraphrased version of the given C# code snippet:

```cs
using System;

// Format a greeting with a placeholder for the audience
string greeting = String.Format("<h1>Hello, {0}!</h1>", "World");
```

This revised snippet does the same as the original, formatting a string to include a personalized greeting. The comment explains the purpose of the code succinctly.

For HTML files that cover extensive content, it's common to utilize placeholders like `[[NAME]]` which can later be substituted with actual data.

Consider the code snippet below which demonstrates creating three unique PDF files, each tailored for a different user:

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

Here's the paraphrased version of the provided C# code snippet:

```cs
// Define an HTML template with a placeholder for names
var htmlPattern = "<p>[[PERSON_NAME]]</p>";
// List of names to generate personalized PDFs
var people = new[] { "John", "James", "Jenny" };
foreach (var person in people)
{
    // Replace placeholder with actual name in the HTML
    var htmlContent = htmlPattern.Replace("[[PERSON_NAME]]", person);
    // Convert the personalized HTML to a PDF document
    var pdfDocument = renderer.RenderHtmlAsPdf(htmlContent);
    // Save the PDF with a unique name for each person
    pdfDocument.SaveAs(person + ".pdf");
}
```

### Utilizing Handlebars.NET for Complex Templating

Using the Handlebars Templating standard offers an advanced way to integrate C# data with HTML for the purpose of generating PDFs.

Handlebars allows for the creation of dynamic HTML content directly from C# objects and class instances, including data drawn from database queries. This feature is incredibly useful in scenarios such as generating invoices, where the number of data rows might not be predetermined.

To begin using Handlebars for your projects, you'll first need to include the Handlebars.NET package available at: [Handlebars.NET on NuGet](https://www.nuget.org/packages/Handlebars.NET/).

```cs
var htmlTemplate =
    @"<div class=""article"">
        <h1>{{title}}</h1>
        <div class=""content"">
            {{content}}
        </div>
    </div>";
var handlebarTemplate = Handlebars.Compile(htmlTemplate);

var pageData = (title: "My latest article", content: "Welcome to my introductory article!");

var renderedContent = handlebarTemplate(pageData);

/* This would output:
<div class="article">
  <h1>My Latest Article</h1>
  <div class="content">
    Welcome to my introductory article!
  </div>
</div>
*/
```

To convert this HTML into a PDF, we can effortlessly utilize the `RenderHtmlAsPdf` method.

```cs
// Including the IronPdf library
using IronPdf;

// Initializing the PDF renderer with the Chrome rendering engine
var pdfRenderer = new ChromePdfRenderer();

// Generating a PDF from the HTML content
var generatedPdf = pdfRenderer.RenderHtmlAsPdf(htmlInstance);

// Saving the created PDF with a filename
generatedPdf.SaveAs("Handlebars.pdf");
```

You can find additional information on the Handlebars HTML templating standard and its utilization in C# at [https://github.com/rexm/Handlebars.NET](https://github.com/rexm/Handlebars.NET).

### Implementing Page Breaks with HTML5 for PDF Pagination

Incorporating page breaks into a PDF is essential for maintaining a structured, visually appealing layout. Developers often need to define specific areas where new pages begin in the generated PDF.

One of the simplest methods to achieve this is by using a lesser-known feature of CSS, which facilitates the insertion of page breaks within any HTML document destined for printing.

Below is a paraphrased version of the HTML snippet related to creating a page break:

```html
<div style='break-after: page;'>&nbsp;</div>
``` 

This HTML is employed to insert a page break in a document for print layouts, ensuring content following this tag begins on a new page.

The supplied HTML is functional, yet it is not considered best practice. We recommend modifying the media attribute as illustrated in the example below. This approach offers a clean and organized method to format HTML content across multiple pages.

Here is your paraphrased section, with URLs resolved to `ironpdf.com` as requested:

```html
<!DOCTYPE html>
<html>
  <head>
    <style type="text/css" media="print">
      .new-page {
        page-break-after: always;  /* Ensures the content following this style starts on a new page */
        page-break-inside: avoid;  /* Prevents breaks within the content */
      }
    </style>
  </head>
  <body>
    <div class="new-page">
      <h1>This is Page 1</h1>
    </div>
    <div class="new-page">
      <h1>This is Page 2</h1>
    </div>
    <div class="new-page">
      <h1>This is Page 3</h1>
    </div>
  </body>
</html>
```

In this revision:
- The class name has been changed from `page` to `new-page` for better clarity.
- Added comments to the CSS properties help explain their purpose, improving the readability and maintainability of the code.

Discover additional [strategies and techniques for Page Breaks](https://ironpdf.com/how-to/html-to-pdf-page-breaks/).

<hr class="separator">

## Adding a Cover Page to Your PDF Document

Using IronPDF, merging PDF documents is straightforward and effective, especially when it comes to incorporating a front or back cover into an already rendered PDF document.

To achieve this, begin by rendering the cover page. Following this, utilize the `PdfDocument.Merge()` method to seamlessly merge the cover page with your existing PDF document. This method consolidates the documents into a single file, maintaining the professional appearance and integrity of your PDF.

Here's the paraphrased section from the original article, with the paths resolved for any relative URLs:

```cs
using IronPdf;

// Rendering a PDF from a URL
var renderedPdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
// Merging it with a pre-existing cover page PDF
var combinedPdf = PdfDocument.Merge(new PdfDocument("CoverPage.pdf"), renderedPdf).SaveAs("Combined.Pdf");
```

A detailed code sample is accessible here: [PDF Cover Page Code Example](https://ironpdf.com/examples/pdf-cover-page/).

<hr class="separator">

## Watermarking PDF Documents

One of the features IronPDF offers in its [C# PDF toolkit](https://ironpdf.com/use-case/csharp-pdf/) is the ability to add watermarks to PDF files. This functionality is perfect for labeling each page of a document as "confidential," "sample," or any other required marker.

Here's the paraphrased section, with relative URLs resolved to ironpdf.com:

```cs
using IronPdf;
using IronPdf.Editing;

// Initializes a new instance of the ChromePdfRenderer to render PDFs
var pdfRenderer = new ChromePdfRenderer();
// Generate a PDF from the specified URL
var generatedPdf = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
// Adds a watermark 'SAMPLE' to each page in red text, aligned to the middle center of the page
// Furthermore, hyperlinks added in the watermark are clickable
generatedPdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 0, VerticalAlignment.Middle, HorizontalAlignment.Center);
// Saves the watermarked PDF to a specified path on the local system
generatedPdf.SaveAs(@"C:\Path\To\Watermarked.pdf");
```

This rewritten code maintains the original functionality while updating variable names and comments for better readability.

You can find a detailed code example here: [View the PDF Watermarking Example Code](https://ironpdf.com/examples/pdf-watermarking/).

<hr class="separator">

## Obtain the C# Source Code for HTML to PDF Conversion

You can download the complete **HTML to PDF converter C# source code** for this tutorial, packaged in a zip file for Visual Studio 2022. This package utilizes the rendering engine of Iron Software to craft PDF documents using C#.

[Get the Visual Studio project of this tutorial](https://ironpdf.com/downloads/CSharp-Html-To-Pdf-Tutorial.zip)

The downloadable content offers a comprehensive toolkit to implement PDF generation from HTML in your project, which includes functional C# PDF code samples that demonstrate:

1. Transforming an HTML string into a PDF document in C#
2. Converting HTML files into PDFs, with comprehensive support for CSS, JavaScript, and images
3. Utilizing a URL to create a PDF in C#
4. Diverse examples on editing PDF settings in C#
5. Generating PDFs from JavaScript canvas charts, like d3.js
6. Utilizing the extensive PDF library capabilities in C#

### Class Reference Documentation

For those interested in deeper technical details, the `IronPdf.PdfDocument` class reference is available at:

[https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html)

This class provides functionalities that include:

* Encryption and password protection for enhanced document security.
* The ability to edit or append HTML content to existing PDFs.
* Capabilities to enrich PDFs with both foreground and background imagery.
* Options to merge, join, truncate, or splice PDFs at specific page divisions.
* Tools for OCR processing to extract readable text and images from PDF documents.

<hr class="separator">

## Blazor HTML to PDF Integration

Integrating HTML to PDF capabilities within your Blazor server is straightforward. Follow these steps:

1. Start by either creating a new Blazor server project or utilize an existing one.

2. Incorporate the IronPDF library into your project via NuGet.

3. Introduce a new Razor Component or modify an existing one.

4. Implement an `InputTextArea` and establish a connection with IronPDF.

5. Allow IronPDF to handle the processing and deployment automatically.

Access the comprehensive step-by-step guide, complete with visuals and code samples, at [this location](https://ironpdf.com/how-to/blazor-tutorial/).

<img src="/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp"/>

<hr class="separator">

## Comparison with Different PDF Libraries

### PDFSharp
**PDFSharp** is an open-source library that provides tools for creating and editing PDF documents programmatically in .NET. Unlike IronPDF, which integrates a built-in browser rendering PDFs directly from HTML, CSS, JS, and images, PDFSharp approaches PDF generation through a more document-centric model, focusing on the manipulation of PDF elements. This can make it less intuitive compared to IronPDF's use-case oriented API. PDFSharp can transform HTML into PDF, albeit with limited capability compared to IronPDF.

### wkhtmltopdf
**wkhtmltopdf** is a well-known open-source tool that uses C++ for converting HTML into PDFs. This library lags significantly behind IronPDF in terms of modern web standards support, rendering with an engine that is nearly a decade old. In contrast, IronPDF is specifically designed for .NET applications, offering robust stability and thread safety. It supports up-to-date web technologies including HTML5 and CSS3, providing a more advanced and comprehensive PDF manipulation API.

### iTextSharp
**iTextSharp** is another open-source library, originally ported from Java's iText. It allows HTML to PDF conversions as well, but with limitations inherent to the older rendering engines it employs. iTextSharp's licensing, under the AGPL, requires the disclosure of source code to all end users, which can be restrictive for commercial applications. IronPDF offers more precise and modern HTML to PDF rendering capabilities and includes licensing suitable for both private and commercial use without such constraints.

### Other Commercial Libraries
IronPDF compares favorably against other commercial .NET PDF libraries like *Aspose PDF*, *Spire PDF*, *EO PDF*, and *SelectPdf*. It stands out due to its comprehensive feature set, extensive documentation, broad compatibility across multiple .NET frameworks, and competitive pricing. The integration of a Chrome-based renderer allows IronPDF to offer high fidelity and accuracy in HTML to PDF conversions, setting it apart from many competitors. View the detailed comparison and learn more about why IronPDF’s rendering engine is superior at [ironpdf.com/how-to/pixel-perfect-html-to-pdf/#what-is-ironpdf-s-chrome-renderer](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#what-is-ironpdf-s-chrome-renderer).

This comprehensive analysis illustrates why IronPDF remains a leading choice for developers requiring reliable, efficient, and capable PDF management solutions within .NET environments.

<h3>PDFSharp</h3>

**PDFSharp** is an open-source library at no cost that provides capabilities for logically editing and creating PDF files in .NET environments.

One of the primary distinctions between PDFSharp and IronPDF is that IronPDF includes a built-in web browser, enabling accurate PDF creation from HTML, CSS, JavaScript, and images.

Furthermore, the API design of IronPDF is centered around practical use cases as opposed to the complex technical infrastructure of PDF files. This approach is often seen as more straightforward and user-friendly.

While PDFSharp can perform HTML to PDF conversions, its capabilities in this area are somewhat restricted, including the conversion of .html files into PDF documents.

<h3>wkhtmltopdf</h3>

**wkhtmltopdf** is an open-source tool developed in C++ for converting HTML content into PDF files.

One significant advantage of IronPDF over wkhtmltopdf is that IronPDF is crafted in C#, ensuring stability and thread safety, making it ideal for .NET applications and web environments.

Moreover, IronPDF boasts complete support for CSS3 and HTML5, contrasting with wkhtmltopdf, which relies on a rendering engine that lags nearly ten years behind modern standards.

IronPDF's API is extensive and sophisticated, offering functionalities for editing, manipulating, compressing, importing, exporting, signing, securing, and watermarking PDF documents.

Although the HTML to PDF conversion process in wkhtmltopdf is reliable, it operates on an archaic rendering engine that doesn't meet current technological expectations.

<h3>iTextSharp</h3>

iTextSharp is an open-source library derived partially from the iText Java library, designed for creating and editing PDF documents. It supports HTML to PDF conversion; however, its capabilities are restricted to the features available in Java or through the wkhtmltopdf converter under the LGPL open-source license.

IronPDF distinguishes itself in HTML to PDF conversion through its use of an embedded Chrome-based browser, providing more advanced and precise rendering compared to iTextSharp's reliance on the dated wkhtmltopdf.

Furthermore, IronPDF offers clearly defined licensing for both commercial and private use, in contrast to iTextSharp’s AGPL license, which requires that all source code be freely provided to all users, including those over the internet.

For a detailed comparison of both tools, please visit our C# documentation page on iTextSharp at [IronPDF's iTextSharp Comparison](https://ironpdf.com/blog/compare-to-other-components/itextsharp/).

<h3>Other Commercial Libraries</h3>

*Aspose PDF*, *Spire PDF*, *EO PDF*, and *SelectPdf* represent alternative .NET commercial PDF libraries in the marketplace. Compared to these, IronPDF boasts a robust range of features, superior compatibility, comprehensive documentation, and a competitive pricing structure. For a detailed analysis of how IronPDF measures up against these competitors and Chrome's own rendering capabilities, visit [this page](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#what-is-ironpdf-s-chrome-renderer).

<hr class="separator">

## View the HTML to PDF Conversion Video Tutorial

Explore our detailed video tutorial on converting HTML to PDF using IronPDF. This instructional video provides a visual guide to enhance your understanding and efficiency in implementing HTML to PDF conversions in your projects.

[Watch the Tutorial Video](ironpdf.com/how-to/blazor-tutorial/#video)

<a name ="video"></a>

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

