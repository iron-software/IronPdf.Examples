# Getting Started with IronPDF C# PDF Library

IronPDF effortlessly resolves the complex issue of integrating PDF creation into your application by automating the conversion of formatted content into PDF format.

- Transform local HTML pages, web forms, and other web assets into PDFs utilizing .NET technologies.
- Enable document downloads, facilitate emailing them, or allow for cloud storage.
- Generate crucial business documents such as invoices, contracts, quotes, and reports.
- Compatible across numerous .NET environments including ASP.NET, ASP.NET Core, web forms, MVC, and Web APIs on both .NET Framework and .NET Core.

<div class="learnn-how-section">
  <div class="row">
    <div class="col-sm-6">
      <h2>Work with PDFs in C&num; Quick Steps:</h2>
      <ul class="list-unstyled">
        <li><a href="#anchor-1-install-the-ironpdf-c-library-to-your-project">Download IronPDF free</a></li>
        <li><a href="#anchor-5-asp-net-web-forms-to-pdf">Turn an ASP Page in to a PDF</a></li>
        <li><a href="#anchor-6-route-asp-mvc-view-to-pdf">Route an ASP MVC View to a PDF</a></li>
        <li><a href="#anchor-7-add-headers-and-footers">Add headers & footers</a></li>
        <li><a href="#anchor-8-encrypt-pdfs-with-a-password">Password protect PDF documents</a></li>
        <li><a href="#anchor-10-extract-images-from-pdf-documents">Extract images, enable JavaScript, use OCR scanning, and more</a></li>
      </ul>
    </div>
    <div class="col-sm-6">
      <div class="download-card">
        <a href="/downloads/csharp-pdf.pdf" target="_blank">
          <img style="box-shadow: none; width: 308px; height: 320px;" src="/img/tutorials/html-to-pdf/cheat-sheet-card.svg" data-hover-src="/img/tutorials/html-to-pdf/cheat-sheet-card-hover.svg" class="img-responsive learn-how-to-img replaceable-img" width="308" height="320">
        </a>
      </div>
    </div>
  </div>
</div>

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Installing the IronPDF C# Library in Your Project

Begin integrating PDF capabilities into your application by including the IronPDF library. Here's how you can get started:

### 1.1. Use NuGet Package Manager

Set up IronPDF in Visual Studio or utilize the command line via NuGet Package Manager. For ease of access in Visual Studio:

- Navigate to `Tools`.
- Open `NuGet Package Manager`.
- Select `Package Manager Console`.

Execute the following command in the console:

```shell
Install-Package IronPdf
```

Visit [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf) to discover more about the updates and installation details.

There are additional **IronPdf NuGet Packages** designed for specific implementations on Linux, macOS, Azure, and AWS, which are detailed in our [IronPDF advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

### 1.2. Direct Download of DLL

If you prefer direct installation, the DLL can be downloaded [here](https://ironpdf.com/packages/IronPdf.zip).

You can find IronPDF DLLs for various platforms:

- [Windows DLL](https://ironpdf.com/packages/IronPdf.zip)
- [Linux DLL](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [macOS DLL](https://ironpdf.com/packages/IronPdf.MacOs.zip)

After downloading, don’t forget to include the following using statement at the beginning of your `.cs` files:

```csharp
using IronPdf;
```

### 1.3. Installation and Setup Guide

For detailed installation and setup procedures, refer to the [installation and deployment guide](https://ironpdf.com/how-to/installation/).

### 1.4A Optional Configuration for Linux Deployment

For deployments on Linux, please visit [Deploying IronPDF on Linux](https://ironpdf.com/how-to/linux/). We provide official support for:

- Ubuntu, Debian, CentOS, Fedora, and Amazon Linux 2.

### 1.4B Docker Configuration Options

For Docker implementations, check the [IronPDF deployment on Docker](https://ironpdf.com/how-to/docker-linux/) guide.

We officially support Docker on:

- Windows, Ubuntu, Debian, CentOS, and Amazon Linux 2, with [sample Dockerfiles](https://ironpdf.com/how-to/docker-linux/).

### 1.4C Azure Deployments

Azure WebApps, WebJobs, Functions, Docker instances, and VMs are supported.

More about the setup is available in the [IronPDF Azure Setup Guide](https://ironpdf.com/how-to/azure/).

### 1.4D Deploying on Amazon AWS

Learn how to implement IronPDF with Amazon AWS Lambda through our [dedicated guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

### 1.4E macOS Support

For macOS developers, refer to our guide on [developing and deploying on macOS](https://ironpdf.com/how-to/macos/) using Rider or Visual Studio for Mac.

### 1.1. Setting Up IronPDF with NuGet Package Manager

To integrate IronPDF into your application, use the NuGet Package Manager either in Visual Studio or via the command line. Follow these steps in Visual Studio to access the Package Manager Console:

- Select 'Tools' from the menu
- Choose 'NuGet Package Manager'
- Click on 'Package Manager Console'
```

```shell
# Install the IronPdf library using the following command
Install-Package IronPdf
```

Explore more about version updates and installation details on the [IronPDF NuGet page](https://www.nuget.org/packages/IronPdf).

For tailored deployments on Linux, Mac, Azure, and AWS, additional **IronPdf NuGet Packages** exist. Learn more in the [IronPDF Advanced NuGet Installation Guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

### 1.2. Direct Download of DLL Files

You have the option to [download the DLL directly](https://ironpdf.com/packages/IronPdf.zip), which is facilitated through a modal download window.

IronPDF also provides platform-specific DLL zip packages for:

- [Windows](https://ironpdf.com/packages/IronPdf.zip)
- [Linux](https://ironpdf.com/packages/IronPdf.Linux.zip)
- [MacOS](https://ironpdf.com/packages/IronPdf.MacOs.zip)

To utilize IronPDF in your **C#** class files, ensure to include the following using directive at the beginning of your code:

```csharp
using IronPdf;
```

### 1.3. Installation and Deployment of the Library

For comprehensive instructions on installing and deploying the IronPDF C# Library, refer to the [installation and deployment guide](https://ironpdf.com/how-to/installation/).

### 1.4A Optional: Linux Deployment

Deploying IronPDF in a Linux environment is thoroughly documented and commonly chosen for cloud services, including Azure deployments.

Officially, we provide support for Linux distributions such as Ubuntu, Debian, CentOS, Fedora, and Amazon Linux 2. Detailed information is available in our Linux deployment guide at [IronPDF Linux Deployment](https://ironpdf.com/how-to/linux/).

### 1.4B Optional: Docker Deployment

- [Deploying IronPDF with Docker](https://ironpdf.com/how-to/docker-linux/) is thoroughly documented.

IronPDF offers official Docker support for several platforms, including Windows, Ubuntu, Debian, CentOS, and Amazon Linux 2. We also supply [functional Docker files](https://ironpdf.com/how-to/docker-linux/) for these environments.

### 1.4C Optional: Azure Deployment

- Comprehensive support is available for deployment on Azure WebApps, Azure WebJobs, Azure Functions, Azure Docker instances, and Azure VMs.

- For detailed instructions and configurations, refer to the IronPDF [Azure & Azure Function Setup Guide](https://ironpdf.com/how-to/azure/).

### 1.4D Optional: Deployment on Amazon AWS

- Comprehensive guidance and support for deploying on Amazon AWS Lambda are provided [here](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

### 1.4E Optional: Support for macOS

- [Comprehensive macOS Support](https://ironpdf.com/how-to/macos/) for both deployment and development using Rider and Visual Studio for Mac.

<hr class="separator">

<h4 class="tutorial-segment-title">How to Tutorials</h4>

### Implementing License Key

To activate IronPDF in your application, it's essential to insert the following code during the application's initialization phase. This setup ensures that the library is ready for use right from the start and is straightforward to apply.

```cs
IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
```

This method of licensing is robust and universally applicable. For alternative licensing approaches, see the detailed guide on [IronPDF License Keys](https://ironpdf.com/how-to/license-keys/).

Here is the paraphrased version of the code snippet you provided, with enhanced comments:

```cs
// Set the license key for IronPdf to unlock its full capabilities
IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
```

If you would rather not embed the license key directly into your code, consider visiting the [IronPDF License Keys](https://ironpdf.com/how-to/license-keys/) page to learn about other methods of application.

## 2. Transform HTML Text to PDF

With IronPDF, converting HTML text into a PDF file is straightforward. This example demonstrates how you can achieve this. It's ideal for scenarios where your PDF needs to include basic text.

- Begin by creating a new .NET Core console project.
- Add IronPDF by installing the NuGet package.
- At the top of your code file, include `using IronPdf;` to access IronPDF classes.
- Initialize a `ChromePdfRenderer` object to handle the PDF rendering.
- Use the `RenderHtmlAsPdf` method to generate the PDF from HTML, and then `SaveAs` to store the result.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<p>Sample Text</p>");
pdf.SaveAs("simple-text.pdf");
``` 

This example shows how effortlessly you can convert HTML into PDF documents with IronPDF, which is especially useful for plain text documents.

Here's a paraphrased version of the given C# code snippet from the IronPDF tutorial section:

```cs
// Import the IronPdf namespace
using IronPdf;

// Initialize a new instance of the ChromePdfRenderer class
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Generate a PDF from an HTML string
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Save the generated PDF to a file
document.SaveAs("simple-html.pdf");
```

<hr class="separator">

## 3. Convert an HTML File to PDF

This process involves transforming HTML files that include images, CSS, forms, hyperlinks, and JavaScript into PDF documents. It's particularly useful when you have local access to the HTML file you wish to convert.

In the example provided, we utilize the `RenderHtmlFileAsPdf` method, which generates a PDF object.

Next, utilize the `SaveAs` method to export the generated PDF.

It's assumed that the HTML file is located in the "Assets" folder for this demonstration.

```cs
using IronPdf;

// Generate a PDF from an HTML file using C#
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
PdfDocument myPdfDocument = pdfRenderer.RenderHtmlFileAsPdf("Assets/MyHTML.html");
myPdfDocument.SaveAs("MyCustomPdf.pdf");
```

<hr class="separator">

## 4. Convert Online Content to PDF

Effortlessly transform online content into PDF files using a small amount of C# or VB.NET code. This function is ideal for converting already well-structured web documents directly into PDF format.

Invoke the method `RenderUrlAsPdf` to fetch the content from a webpage, followed by `SaveAs` to locally store the resulting PDF document.

```cs
using IronPdf;

// Generate a PDF from an existing web page URL
ChromePdfRenderer webPageToPdfRenderer = new ChromePdfRenderer();
PdfDocument generatedPdf = webPageToPdfRenderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Portable_Document_Format");
generatedPdf.SaveAs("wikipedia.pdf");
```

<hr class="separator">

## 5. ASP.NET Web Forms to PDF Transformation

Effortlessly convert your ASP.NET web forms from HTML to PDF format. Simply embed a straightforward code snippet within the `Page_Load` method of your page's code-behind.

- Kick off by either setting up a new ASP.NET WebForms project or by opening an existing project.
- Ensure the inclusion of the IronPDF NuGet package.
- In your project's files, include the `IronPdf` namespace by adding `using IronPdf;` at the beginning of your file.
- Navigate to the code-behind file (`Default.aspx.cs`, for instance) where you wish to implement PDF rendering.
- Utilize the `RenderThisPageAsPdf` function from the `AspxToPdf` class to trigger the conversion.

Here is the paraphrased section of the C# code mentioned in the article, with the relative URL path resolved:

```cs
using IronPdf;
using System;
using System.Web.UI;

// Define the namespace for your web application 
namespace WebApplication
{
    // Define a partial class for the default page that inherits from Page
    public partial class _Default : Page
    {
        // On page load, convert the current ASP.NET page to a PDF and display it in the browser
        protected void Page_Load(object sender, EventArgs e)
        {
            AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.InBrowser);
        }
    }
}
```

<hr class="separator">

## 6. Convert ASP MVC View to PDF

Seamlessly convert views to PDFs within the ASP MVC framework. This functionality is ideal whether you're starting a new ASP MVC application or enhancing an existing one with additional controllers.

Firstly, launch the new project wizard in Visual Studio and select the option for an ASP.NET Web Application under the .NET Framework, specifying the MVC template. Alternatively, if you're working on an existing MVC project, proceed with that.

Navigate to the Controllers directory, access the `HomeController`, and either modify the Index method or introduce a new controller to suit your needs.

The following snippet provides a demonstration of how the code should be structured:
```

```cs
using IronPdf;
using System;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // The controller's Index action converts a URL to a PDF document
        public ActionResult Index()
        {
            // Create a PDF from the content of Wikipedia's main page
            using var PDF = IronPdf.ChromePdfRenderer.StaticRenderUrlAsPdf(new Uri("https://en.wikipedia.org"));
            // Return the generated PDF in the browser
            return File(PDF.BinaryData, "application/pdf", "Wikipedia-Snapshot.pdf");
        }
        
        // Provides details about the application on the About page
        public ActionResult About()
        {
            ViewBag.Message = "Learn more about our application.";
            return View();
        }
        
        // Displays contact information on the Contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Reach out to us with your questions.";
            return View();
        }
    }
}
```

<hr class="separator">

## 7. Customize Headers and Footers

The `RenderingOptions` attribute provides the flexibility to design headers and footers for each page of your PDF. These settings can be adjusted using the `ChromePdfRenderer` instance. This technique is applicable within a .NET Core console application.

Utilize the following placeholders to customize your content:

- `{page}` - Current page number
- `{total-pages}` - Total number of pages
- `{url}` - URL of the document (if applicable)
- `{date}` - Current date
- `{time}` - Current time
- `{html-title}` - Title of the HTML source
- `{pdf-title}` - Title of the PDF document

```cs
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.FirstPageNumber = 1;

// Configure the header of each PDF page
pdfRenderer.RenderingOptions.TextHeader.DrawDividerLine = true;
pdfRenderer.RenderingOptions.TextHeader.CenterText = "{url}";
pdfRenderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Helvetica;
pdfRenderer.RenderingOptions.TextHeader.FontSize = 12;

// Configure the footer for the PDF document
pdfRenderer.RenderingOptions.TextFooter.DrawDividerLine = true;
pdfRenderer.RenderingOptions.TextFooter.Font = IronSoftware.Drawing.FontTypes.Arial;
pdfRenderer.RenderingOptions.TextFooter.FontSize = 10;
pdfRenderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
pdfRenderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";

// Generate the PDF from HTML content and save it
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
document.SaveAs("html-string.pdf");
```

### 7.1. Implementing HTML Headers and Footers

Similar to the previous examples, this task can be accomplished within a .NET Core console application by utilizing the `HtmlFragment` attribute. Here, you can define the HTML content directly for both headers and footers.

```cs
using IronPdf;
using System;

// Set up a new PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Configure the footer with dynamic fields using HTML for styling
// Available placeholders include: {page}, {total-pages}, {url}, {date}, {time}, {html-title}, and {pdf-title}
pdfRenderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    MaxHeight = 30, // Set the maximum height of the footer
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>", // Specify the content of the footer
    DrawDividerLine = true // Include a divider line at the top of the footer
};

// Configure the header using an image, with a specified base URL for relative asset paths
pdfRenderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
{
    MaxHeight = 30, // Set the maximum height of the header
    HtmlFragment = "<img src='logo.jpg'>", // Include an image in the header
    BaseUrl = new Uri(@"C:\assets\images").AbsoluteUri // Provide the base URL for locating the 'logo.jpg' file
};

// Render an HTML string to PDF
PdfDocument pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
pdfDocument.SaveAs("hello-world.pdf"); // Save the generated PDF to a file
```

<hr class="separator">

## 8. Secure PDFs with Password Encryption

To secure your PDF files with encryption, simply set the `Password` property on the PDF document. This ensures that the document can only be opened by users who know the correct password. Here's an example for setting up password protection within a .NET Core Console application:

```cs
using IronPdf;

// Instantiate a new PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Create a PDF document from HTML content
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Set a strong password for the PDF document
document.Password = "strong!@#pass&^%word";

// Save the PDF with the applied security settings
document.SaveAs("secured.pdf");
```

<hr class="separator">

## 9. Combine and Separate PDF Files

Utilize the `Merge` method to combine several PDF files into one, or use `CopyPages` to extract specific pages from a document. Ensure to add the PDFs as Content in your project to reference them by name.

```cs
using IronPdf;
using System.Collections.Generic;

// Set up the PDF rendering engine
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Combine several PDF files into one
List<PdfDocument> documents = new List<PdfDocument>();
documents.Add(PdfDocument.FromFile("A.pdf"));
documents.Add(PdfDocument.FromFile("B.pdf"));
documents.Add(PdfDocument.FromFile("C.pdf"));
PdfDocument consolidatedPdf = PdfDocument.Merge(documents);
consolidatedPdf.SaveAs("merged.pdf");

// Insert a cover page at the beginning
PdfDocument coverPage = renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");
consolidatedPdf.PrependPdf(coverPage);

// Delete the final page and save the document again
consolidatedPdf.RemovePage(consolidatedPdf.PageCount - 1);
consolidatedPdf.SaveAs("final-merged.pdf");

// Extract the first two pages into a separate PDF file
PdfDocument firstTwoPages = consolidatedPdf.CopyPages(1, 2);
firstTwoPages.SaveAs("selected-pages.pdf");

// Clean up: Dispose all individual PDF documents
foreach (PdfDocument doc in documents) {
    doc.Dispose();
}
```

<hr class="separator">

## 10. Retrieve Images from PDF Files

To utilize this functionality, you will need to install an additional NuGet package called `System.Drawing.Common`. This will allow you to access and execute methods such as `ExtractAllText` and `ExtractAllImages`, which are crucial for extracting text and images from PDF files, respectively.

Here's the paraphrased section of the article:

```cs
using IronPdf;

// Load a PDF file
PdfDocument pdfDoc = PdfDocument.FromFile("A.pdf");

// Extract all textual content from the PDF
string completeText = pdfDoc.ExtractAllText();

// Extract all images from the PDF
var images = pdfDoc.ExtractAllImages();

// Iterate through each page to extract text and images individually
for (var i = 0 ; i < pdfDoc.PageCount ; i++)
{
    int currentPage = i + 1;
    string textOnPage = pdfDoc.ExtractTextFromPage(i);
    var imagesOnPage = pdfDoc.ExtractImagesFromPage(i);
}
```

This rewritten code maintains the original functionality while modifying variable names and comments for a fresh perspective.

<hr class="separator">

## 11. Enable JavaScript Support

IronPDF provides functionality to enable JavaScript execution within PDF documents. This allows for a more dynamic and interactive PDF rendering experience. Here's how to configure IronPDF to process JavaScript:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Delay rendering to ensure all scripts are processed
renderer.RenderingOptions.WaitFor.RenderDelay(500);

// Set rendering options to enable JavaScript
renderer.RenderingOptions = new ChromePdfRenderOptions()
{
    EnableJavaScript = true,
};
```

```cs
using IronPdf;

// Initialize a PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
// Set a delay to wait before rendering
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(500);
// Update rendering options to enable JavaScript
pdfRenderer.RenderingOptions = new ChromePdfRenderOptions()
{
    EnableJavaScript = true,
};
```

<hr class="separator">

## 12. PDF OCR and Text Recognition

Frequently, you have the ability to directly retrieve embedded text from within PDF files:

Here's the paraphrased section:

```cs
using IronPdf;

// Load a PDF document with a specified password
PdfDocument securedPdf = PdfDocument.FromFile("Invoice.pdf", "password");

// Extract all the text from the loaded PDF
string extractedText = securedPdf.ExtractAllText();
```

If the methods above fail, it's likely because the text in your document is part of an image.

To recognize text visually entrenched in images within your PDFs, employ the IronOCR library.

Start by installing the `IronOcr` NuGet package. For further details on how to utilize IronOCR for extracting text from PDFs, refer to [scanning PDFs with IronOCR](https://ironsoftware.com/csharp/ocr/examples/csharp-pdf-ocr/).

Here's the paraphrased version of the given C# code section, including resolved relative URL paths for IronPDF's domain:

```cs
using IronOcr;
using System;

IronTesseract tesseract = new IronTesseract();
using (OcrInput input = new OcrInput("Invoice.pdf", password: "password"))
{
    // Perform OCR on the entire PDF document
    input.Deskew();  // Correct any skew in the scanned document
    input.DeNoise();  // Reduce noise to improve OCR accuracy

    // Read the document content using OCR
    OcrResult ocrResult = tesseract.Read(input);

    // Output the text recognized from the PDF
    Console.WriteLine(ocrResult.Text);
    var detectedBarcodes = ocrResult.Barcodes;  // Extract any barcodes found
    string extractedText = ocrResult.Text;  // Store the text from the OCR result
}
```

<hr class="separator">

## 13. Explore Additional Rendering Options

Dive into a variety of advanced rendering settings available:

```cs
using IronPdf;
using System.Text;

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.SetCustomPaperSizeInInches(12.5, 20);
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;
renderer.RenderingOptions.Title = "My PDF Document Name";
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.WaitFor.RenderDelay(50);
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
renderer.RenderingOptions.GrayScale = false;
renderer.RenderingOptions.FitToPaperMode = IronPdf.Engines.Chrome.FitToPaperModes.Automatic;
renderer.RenderingOptions.InputEncoding = Encoding.UTF8;
renderer.RenderingOptions.Zoom = 100;
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Adjust margins (measured in millimeters)
renderer.RenderingOptions.MarginTop = 40;
renderer.RenderingOptions.MarginLeft = 20;
renderer.RenderingOptions.MarginRight = 20;
renderer.RenderingOptions.MarginBottom = 40;

// Configure if a cover page will be used
renderer.RenderingOptions.FirstPageNumber = 1;
renderer.RenderHtmlFileAsPdf("my-content.html").SaveAs("my-content.pdf");
```

```cs
using IronPdf;
using System.Text;

// Instantiate a PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Set custom PDF attributes for rendering
pdfRenderer.RenderingOptions.SetCustomPaperSizeInInches(12.5, 20);
pdfRenderer.RenderingOptions.PrintHtmlBackgrounds = true;
pdfRenderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;
pdfRenderer.RenderingOptions.Title = "My PDF Document Name";
pdfRenderer.RenderingOptions.EnableJavaScript = true;
pdfRenderer.RenderingOptions.WaitFor.RenderDelay(50);
pdfRenderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Screen;
pdfRenderer.RenderingOptions.GrayScale = false;
pdfRenderer.RenderingOptions.FitToPaperMode = IronPdf.Engines.Chrome.FitToPaperModes.Automatic;
pdfRenderer.RenderingOptions.InputEncoding = Encoding.UTF8;
pdfRenderer.RenderingOptions.Zoom = 100;
pdfRenderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Configure margin settings in millimeters
pdfRenderer.RenderingOptions.MarginTop = 40;
pdfRenderer.RenderingOptions.MarginLeft = 20;
pdfRenderer.RenderingOptions.MarginRight = 20;
pdfRenderer.RenderingOptions.MarginBottom = 40;

// Set the starting page number, useful if you add a cover page later
pdfRenderer.RenderingOptions.FirstPageNumber = 1;

// Render an HTML file to a PDF and save it
pdfRenderer.RenderHtmlFileAsPdf("my-content.html").SaveAs("my-content.pdf");
```

<hr class="separator">

## 14. Download the C# PDF Cheat Sheet

This guide has been compiled into a user-friendly PDF document, fully explaining the processes of creating and editing PDF files using the IronPDF library in both C# and VB.NET. You can access the cheat sheet [here](https://ironpdf.com/csharp-pdf.pdf "C# PDF Development PDF").

Feel free to download and utilize it as a development manual for your .NET applications, or print it out to keep as a useful reference during your work with IronPDF. Utilizing this cheat sheet can streamline the integration of PDF functionalities into your .NET projects, saving valuable time and effort.

<hr class="separator">

## 15. Further Learning Opportunities

For a comprehensive guide on converting HTML to PDF using C# or VB.NET, explore the in-depth [C# HTML to PDF Tutorial](https://ironpdf.com/tutorials/html-to-pdf/). This tutorial thoroughly delineates utilizing HTML templates, CSS, images, and JavaScript for advanced PDF configurations.

Interested in transforming ASPX pages from ASP.NET frameworks into PDF documents? Dive into the complete [ASPX to PDF Tutorial](https://ironpdf.com/how-to/aspx-to-pdf/).

Additionally, the extensive [IronPDF API reference](https://ironpdf.com/object-reference/api/IronPdf.html) is accessible for .NET developers seeking detailed insights into IronPDF's functionalities.

## 16. License Activation

To utilize IronPDF, a valid license key is mandatory. For guidance on how to properly implement the license key, please refer to the [IronPDF License Keys](https://ironpdf.com/how-to/license-keys/) page.

<hr class="separator">

<h4 class="tutorial-segment-title">Tutorial Quick Access</h4>

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

