# VB.NET PDF Creation Tutorial (Code Examples)

***Based on <https://ironpdf.com/how-to/vb-net-pdf/>***


This guide provides a detailed, step-by-step approach to creating and editing PDF documents using VB.NET. This method is appropriate for **ASP.NET web applications**, **console applications**, **Windows Services**, and **desktop applications**. We will demonstrate how to generate PDFs specifically targeting .NET Framework 4.6.2 or .NET Core 2, utilizing only a Visual Basic .NET development setup, like Microsoft Visual Studio Community.

For instructions on utilizing IronPDF with **C#**, refer to [this guide](https://ironpdf.com/docs/).

For guidance on implementing IronPDF with **F#**, check out [this tutorial](https://ironpdf.com/how-to/fsharp-pdf-library-html-to-pdf/).

<hr class="separator">
<p class="main-content__segment-title">Overview</p>




<h2>VB .NET Codes for PDF Creating and Editing with IronPDF</h2>

Transform HTML into PDF effortlessly using VB.NET, harnessing styling options and dynamic contents to tailor your document needs. The process of generating PDFs is simple and fully supports versions from .NET Framework 4.6.2 up to .NET 8, without the need for proprietary formats or complex APIs.

This tutorial comes equipped with detailed documentation that guides you through each step, leveraging the [IronPDF tool](https://ironpdf.com), a favorite among developers and provided at no cost for development purposes. You'll find VB.NET code examples tailored to specific scenarios, making it easier to follow along in your project environment. The VB.NET library from IronPDF offers extensive capabilities for creating and managing settings in a wide range of projects, including those in ASP.NET applications, consoles, or desktop environments.

<h3>Included with IronPDF:</h3>

- Direct access to ticket support from our .NET PDF Library development team (staffed by real people!)

- Compatible with HTML, ASPX forms, MVC views, images, and all familiar document formats

- Effortless startup with Microsoft Visual Studio installation

- Enjoy unlimited development for free, with licensing options available when you're ready to deploy, starting at `$liteLicense`

<hr class="separator">

<p class="main-content__segment-title">Step 1</p>

## Downloading the Free VB.NET PDF Library from IronPDF

### How to Install via NuGet

Initiate your installation process in Visual Studio by right-clicking on the project in your solution explorer, then selecting **"Manage NuGet Packages..."**. Enter `IronPDF` in the search box, select the latest version, and affirm any prompts that appear.

This setup is compatible with any C# .NET Framework from version 4.6.2 onwards, including .NET Core 2 and later, and is just as effective in VB.NET projects.

```shell
Install-Package IronPdf
```

Get more details here: [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf)

### Manual Installation via DLL

Alternatively, download the necessary IronPDF DLL manually and add it to your project or the Global Assembly Cache (GAC) from [IronPDF Downloads](https://ironpdf.com/packages/IronPdf.zip).

Make sure to include the following line at the beginning of any VB class file where you intend to use IronPDF to enable its functionality:

```vb
Imports IronPdf
```

<h3>Install via NuGet</h3>

In Microsoft Visual Studio, right-click on your project in the Solution Explorer and choose "Manage NuGet Packages...". Next, search for IronPDF and proceed to install the most recent version. Approve any dialog boxes that appear during the installation process.

This installation strategy is applicable for any project using C# .NET Framework version 4.6.2 or newer, as well as projects using .NET Core 2 or subsequent versions. It is equally effective for VB.NET projects.

Here is the paraphrased version where the relative URL paths have been resolved to `ironpdf.com`, and the content has been rewritten:

```shell
Install-Package IronPdf
```

<a class="js-modal-open" href="https://www.nuget.org/packages/IronPdf" target="_blank" data-modal-id="trial-license-after-download">https://www.nuget.org/packages/IronPdf</a>



<h3>Install via DLL</h3>

Alternatively, you can manually download the IronPDF DLL and integrate it directly into your project or the Global Assembly Cache (GAC) from the following link: <a class="js-modal-open" href="https://ironpdf.com/packages/IronPdf.zip" data-modal-id="trial-license-after-download">https://ironpdf.com/packages/IronPdf.zip</a>.

Ensure you include the following import statement at the beginning of any **VB** class file that utilizes IronPDF:
```vb
Imports IronPdf;
```

```vb
' Required namespace for using IronPdf classes
Imports IronPdf
```

# VB.NET PDF Creation (Step-by-Step Code Guide)

***Based on <https://ironpdf.com/how-to/vb-net-pdf/>***


This guide provides detailed instructions on how to generate and modify PDF documents using VB.NET. Suitable for various applications including **ASP.NET web apps**, **console applications**, **Windows Services**, and **desktop applications**, this tutorial is your starting point for developing PDF functionalities in projects targeting .NET Framework 4.6.2 or .NET Core 2. All that's required is a VB.NET development setup like Microsoft Visual Studio Community.

For tutorials on employing IronPDF with **C#**, refer to [this guide](https://ironsoftware.com/docs/).

For IronPDF utilization with **F#**, check out [this guide](https://ironsoftware.com/how-to/fsharp-pdf-library-html-to-pdf).

<hr class="separator">
<p class="main-content__segment-title">Overview</p>

## VB.NET Code Examples for PDF Manipulation with IronPDF

Easily create and adjust PDFs by rendering HTML to PDF in VB.NET. Apply style, dynamic content, and edit with ease using IronPDF, compatible across various .NET versions from Framework 4.6.2 to .NET 5, 6, 7, and 8. Skip the use of proprietary formats and simplify coding with comprehensive tools provided by the free-for-development [IronPDF library](https://ironpdf.com), a favorite among developers.

<h3>Benefits of Using IronPDF:</h3>
- Direct ticket support from our dedicated .NET PDF Library team,
- Supports a wide array of formats including HTML, ASPX forms, MVC views, images, and documents,
- Quick setup with Microsoft Visual Studio,
- Free unlimited development with licenses available for live deployment starting at `$liteLicense`.

<hr class="separator">

<p class="main-content__segment-title">Step 1</p>

## 1. Get the VB.NET PDF Library for FREE from IronPDF

<h3>Installation via NuGet</h3>

In Visual Studio, right-click your project in the solution explorer and choose "Manage NuGet Packages...". Search for IronPDF and install the most current version, accepting all prompts that appear.

```shell
Install-Package IronPdf
```

For more information and to download, visit the NuGet page directly at [IronPdf on NuGet](https://www.nuget.org/packages/IronPdf).

<h3>Manual Installation</h3>

You can also manually download and install the IronPDF DLL to your project or the Global Assembly Cache (GAC) from [IronPDF DLL Package](https://ironpdf.com/packages/IronPdf.zip).

Add the following to the top of any VB.NET class file utilizing IronPDF:
```vb
Imports IronPdf;
```

<hr class="separator">

<p class="main-content__segment-title">How to Tutorials</p>

## 2. First PDF Creation with VB.NET

Creating a PDF in Visual Basic ASP.NET for the first time is surprisingly straightforward using IronPDF. With the library, you can convert HTML content (with high-fidelity using the Chromium engine) directly into PDF files.
Here's a basic example of creating a PDF in VB.NET:

```vb
Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderHtmlAsPdf("<h1>Welcome to VB.NET PDF creation</h1>")
        document.SaveAs("Welcome.pdf")
    End Sub
End Module
```

This code snippet generates a PDF titled "Welcome.pdf" containing a simple header. Enhance this by reopening the generated PDF in the default viewer:

```vb
Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        var document = renderer.RenderHtmlAsPdf("<h1>Welcome to VB.NET PDF creation</h1>")
        document.SaveAs("Welcome.pdf")
        System.Diagnostics.Process.Start("Welcome.pdf")
    End Sub
End Module
```

Alternatively, convert a web page into a PDF with IronPDF's `RenderUrlAsPdf` method:

```vb
Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
        document.SaveAs("WebPage.pdf")
        System.Diagnostics.Process.Start("WebPage.pdf")
    End Sub
End Module
```

This section has demonstrated the initial steps to incorporate PDF creation into your VB.NET applications using IronPDF. For further customization and advanced features, continue exploring IronPDF's extensive documentation and support.

<hr class="separator">

<p class="main-content__segment-title">How to Tutorials</p>

## 2. Creating a PDF using VB.NET

The process of generating a PDF document with **Visual Basic ASP.NET** is impressively straightforward when utilizing IronPDF, especially when contrasted with other libraries like ***iTextSharp*** that rely on bespoke design APIs.

Utilizing HTML (leveraging a precision rendering engine built on Google's Chromium), you can effortlessly outline the contents of your PDF.

Below is the most basic example of how to craft a PDF in VB.NET:
```

Below is the paraphrased section of the VB.NET example code using IronPDF, ensuring alignment with coding standards and readability:

```vb
Module ExampleModule
    Sub MainRoutine()
        ' Create a new instance of the ChromePdfRenderer class
        Dim pdfRenderer = New ChromePdfRenderer()
        ' Generate a PDF from HTML content
        Dim myFirstPdf = pdfRenderer.RenderHtmlAsPdf("<h1>My First PDF in VB.NET</h1>")
        ' Save the PDF to a file named "MyFirst.pdf"
        myFirstPdf.SaveAs("MyFirst.pdf")
    End Sub
End Module
```

In this code:
- The module and subroutine names are adjusted for better clarity and convention adherence.
- Comments are added to clarify each step of the process, enhancing maintainability and comprehension.

This process will create a PDF file using .NET that includes your specified text, although initially, it may be somewhat plain in appearance.

To enhance this initial code, we should start by inserting the statement `**Imports IronPdf**` at the beginning. Additionally, to make the application more interactive, appending the line `***System.Diagnostics.Process.Start***` will automatically open the PDF with the default viewer installed on your operating system, providing a practical demonstration of the created file.

Here's the paraphrased section of your VB.NET code example:

```vb
' Required namespace for PDF operations
Imports IronPdf

' Main module definition
Module MainModule
    Sub Main()
        ' Create a new PDF renderer instance
        Dim pdfRenderer = New ChromePdfRenderer()
        ' Generate a PDF from HTML content
        Dim pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>My First PDF in VB.NET</h1>")
        ' Save the PDF to a file
        pdfDocument.SaveAs("FirstPdfDocument.pdf")
        ' Open the generated PDF using the default viewer
        System.Diagnostics.Process.Start("FirstPdfDocument.pdf")
    End Sub
End Module
```

This version maintains the original functionality while subtly altering the syntax and comments.

Another approach involves converting any existing webpage into a PDF. This is done through the sophisticated `RenderUrlAsPdf` method provided by IronPDF.

```vb
' Import the IronPdf library
Imports IronPdf

' Define the module
Module PdfCreationModule
    ' Application's main entry point
    Sub Main()
        ' Create a new instance of ChromePdfRenderer
        Dim pdfRenderer = New ChromePdfRenderer()
        ' Convert a webpage URL directly to a PDF document
        Dim pdfDocument = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
        ' Save the generated PDF to a local file
        pdfDocument.SaveAs("DownloadedUrl.pdf")
        ' Automatically open the saved PDF file using the system's default PDF reader
        System.Diagnostics.Process.Start("DownloadedUrl.pdf")
    End Sub
End Module
```

<hr class="separator">

## 3. Apply Styling to VB.NET PDF

In VB.NET, you have the flexibility to enhance your PDF documents using CSS, JavaScript, and images. It's possible to incorporate both local and remote assets, including those hosted on CDNs like Google Fonts. Additionally, you can seamlessly integrate images and other resources directly into your HTML using [DataURIs](https://ironpdf.com/how-to/datauris/).

For a more sophisticated design approach, consider this dual-phase method:

1. **Development and Design Preparation**: Initially, create and refine your HTML content to perfection. This stage might require collaborating with your design team to divide responsibilities and focus on crafting tailored outcomes.

2. **PDF Rendering**: After your HTML is ready, transform it into a professional-grade PDF with VB.NET utilizing our specialized PDF Library.

### The VB.NET Code to Render an HTML File as a PDF:

This approach simulates opening an HTML document as a local file, using the `file://` protocol. Here’s an illustrative example of how you can accomplish this rendering: 

```vb
Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        renderer.RenderingOptions.CssMediaType = Rendering.PdfCssMediaType.Print
        renderer.RenderingOptions.PrintHtmlBackgrounds = False
        renderer.RenderingOptions.PaperOrientation = Rendering.PdfPaperOrientation.Landscape
        renderer.RenderingOptions.WaitFor.RenderDelay(150)
        Dim document = renderer.RenderHtmlFileAsPdf("C:\Users\jacob\Dropbox\Visual Studio\Tutorials\VB.Net.Pdf.Tutorial\VB.Net.Pdf.Tutorial\slideshow\index.html")
        document.SaveAs("Html5.pdf")
        System.Diagnostics.Process.Start("Html5.pdf")
    End Sub
End Module
``` 

This code segment highlights the rendering of an HTML file into a PDF, demonstrating manipulation of rendering options such as CSS media types and paper orientations to optimize output.

```vb
Imports IronPdf

Module Module1
    Sub Main()
        ' Create a new instance of the ChromePdfRenderer class
        Dim renderer = New ChromePdfRenderer()

        ' Configure rendering options for PDF generation
        With renderer.RenderingOptions
            ' Set the CSS media type to 'Print' to apply only print-specific styles
            .CssMediaType = Rendering.PdfCssMediaType.Print
            ' Disable the rendering of HTML backgrounds to clean up the output PDF
            .PrintHtmlBackgrounds = False
            ' Set the paper orientation to Landscape for a wider view
            .PaperOrientation = Rendering.PdfPaperOrientation.Landscape
            ' Specify a delay to ensure that dynamic content has loaded
            .WaitFor.RenderDelay = 150
        End With

        ' Render an HTML file into a PDF document
        Dim document = renderer.RenderHtmlFileAsPdf("C:\Users\jacob\Dropbox\Visual Studio\Tutorials\VB.Net.Pdf.Tutorial\VB.Net.Pdf.Tutorial\slideshow\index.html")
        
        ' Save the PDF file locally
        document.SaveAs("Html5.pdf")
        
        ' Open the generated PDF using the default viewer
        System.Diagnostics.Process.Start("Html5.pdf")
    End Sub
End Module
```

We could also opt to use a shorter file path that is relative to the project such as:

Here's a paraphrased version of the specific section in the article:

```vb
Dim pdfDocument = renderer.RenderHtmlFileAsPdf("../../slideshow/index.html")
```

In the section provided, **ChromePdfRenderer** is utilized which includes a **RenderingOptions** property. This allows for the following configurations:

- Adjusting the CSS media type to 'print', effectively excluding any CSS3 styles intended solely for screens.
- Disabling the rendering of HTML background graphics and colors.
- Changing the PDF orientation to landscape.
- Introducing a brief delay in the rendering process to allow JavaScript executions to complete.

The HTML example used in this scenario incorporates JavaScript, CSS3, and image elements to craft a responsive, mobile-friendly slideshow. The source of this HTML can be found at [Leemark's Better Simple Slideshow](https://leemark.github.io/better-simple-slideshow/).

Here's the paraphrased section of the HTML code:

```html
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Crafting an Easy Responsive Slideshow Using HTML5, CSS3 and JavaScript</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href='http://fonts.googleapis.com/css?family=Open+Sans|Open+Sans+Condensed:700' rel='stylesheet' type='text/css'>
        <link rel="stylesheet" href="https://ironpdf.com/demo/css/demostyles.css">
        <link rel="stylesheet" href="https://ironpdf.com/css/simple-slideshow-styles.css">
    </head>
    <body>
        <!--[if lt IE 8]>
            <p class="browsehappy">Your browser is <strong>antiquated</strong>. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your browsing experience.</p>
        <![endif]-->
        <header>
            <h1>An Improved Simple Slideshow</h1>
            <p><span class="desc">An easy-to-configure, responsive JavaScript slideshow.</span> [<a href="https://github.com/leemark/better-simple-slideshow">GitHub<span> repository</span></a>]</p>
        </header>
        <div class="bss-slides num1" tabindex="1" autofocus="autofocus">
            <figure>
                <img src="https://ironpdf.com/demo/img/medium.jpg" width="100%" /><figcaption>"Medium" by <a href="https://www.flickr.com/photos/thomashawk/14586158819/">Thomas Hawk</a>.</figcaption>
            </figure>
            <figure>
                <img src="https://ironpdf.com/demo/img/colorado.jpg" width="100%" /><figcaption>"Colorado" by <a href="https://www.flickr.com/photos/stuckincustoms/88370744">Trey Ratcliff</a>.</figcaption>
            </figure>
            <figure>
                <img src="https://ironpdf.com/demo/img/monte-vista.jpg" width="100%" /><figcaption>"Early Morning at the Monte Vista Wildlife Refuge, Colorado" by <a href="https://www.flickr.com/photos/davesoldano/8572429635">Dave Soldano</a>.</figcaption>
            </figure>
            <figure>
                <img src="https://ironpdf.com/demo/img/sunrise.jpg" width="100%" /><figcaption>"Sunrise in Eastern Colorado" by <a href="https://www.flickr.com/photos/35528040@N04/6673031153/">Pam Morris</a>.</figcaption>
            </figure>
            <figure>
                <img src="https://ironpdf.com/demo/img/colorado-colors.jpg" width="100%" /><figcaption>"colorado colors" by <a href="https://www.flickr.com/photos/cptspock/2857543585">Jasen Miller</a>.</figcaption>
            </figure>
        </div> 
        <div class="content">
            <h2>Introduction</h2>
            <p>This slideshow is a fundamental display of images, crafted entirely in JavaScript. It serves dual purposes: as a drop-in component for websites and as an instructional kit demonstrating how to create a straightforward slideshow from the ground up. <a href="http://themarklee.com/2014/10/05/better-simple-slideshow/">Explore our step-by-step guide here</a>.</p>
            <h2>Capabilities</h2>
            <ul>
                <li>fully responsive layout</li>
                <li>auto-advance or manual navigation of slides</li>
                <li>allows multiple instances per page</li>
                <li>navigation via arrow keys</li>
                <li>support for full-screen view via HTML5 API</li>
                <li>touch swipe gestures supported on mobile devices (requires <a href="https://github.com/hammerjs/hammer.js">hammer.js</a>)</li>
                <li>crafted with vanilla JavaScript, with no dependency on jQuery (still love <a href="https://github.com/jquery/jquery">jQuery</a>!)</li>
            </ul>
            <h2>Getting Started</h2>
            <ol>
                <li><p>Your slideshow should be wrapped in a container element, typically a <span class="code">&lt;div&gt;</span>, with each slide as a <span class="code">&lt;figure&gt;</span>.</p>
                <script src="https://gist.github.com/leemark/83571d9f8f0e3ad853a8.js"></script></li>
                <li>Include the JavaScript file: <span class="code">js/better-simple-slideshow.min.js</span> or <span class="code">js/better-simple-slideshow.js</span></li>
                <li>Load the corresponding CSS file <span class="code">css/simple-slideshow-styles.css</span></li>
                <li>Initialize the slideshow:
                <script src="https://gist.github.com/leemark/479d4ecc4df38fba500c.js"></script>
                </li>
            </ol>
            <h2>Configuration</h2>
            To tweak the slideshow's functionality, define an options object and pass it to <span class="code">makeBSS()</span> as a second parameter, as illustrated below:
            <script src="https://gist.github.com/leemark/c6e0f5c47acb7bf9be16.js"></script>
            <h2>Demonstrations</h2>
            <h3>Sample #1 (at top)</h3>
            <p>Slideshow HTML structure:</p>
            <script src="https://gist.github.com/leemark/19bafdb1abf8f6b4e147.js"></script>
            <p>Underlying JavaScript:</p>
            <script src="https://gist.github.com/leemark/a09d2726b5bfc92ea68c.js"></script>
            <h3>Sample #2 (below)</h3>
                <div class="bss-slides num2" tabindex="2">
                    <figure>
                        <img src="http://themarklee.com/wp-content/uploads/2013/12/snowying.jpg" width="100%" /><figcaption>"Snowying" by <a href="http://www.flickr.com/photos/fiddleoak/8511209344/">fiddleoak</a>.</figcaption>
                    </figure>
                    <figure>
                        <img src="http://themarklee.com/wp-content/uploads/2013/12/starlight.jpg" width="100%" /><figcaption>"Starlight" by <a href="http://www.flickr.com/photos/chaoticmind75/10738494123/in/set-72157626146319517">ChaoticMind75</a>.</figcaption>
                    </figure>
                    <figure>
                        <img src="http://themarklee.com/wp-content/uploads/2013/12/snowstorm.jpg" width="100%" /><figcaption>"Snowstorm" by <a href="http://www.flickr.com/photos/tylerbeaulawrence/8539457508/">Beaulawrence</a>.</figcaption>
                    </figure>
                    <figure>
                        <img src="http://themarklee.com/wp-content/uploads/2013/12/misty-winter-afternoon.jpg" width="100%" /><figcaption>"Misty winter afternoon" by <a href="http://www.flickr.com/photos/22746515@N02/5277611659/">Bert Kaufmann</a>.</figcaption>
                    </figure>
                    <figure>
                        <img src="http://themarklee.com/wp-content/uploads/2013/12/good-morning.jpg" width="100%" /><figcaption>"Good Morning!" by <a href="http://www.flickr.com/photos/frank_wuestefeld/4306107546/">Frank Wuestefeld</a>.</figcaption>
                    </figure>
                </div> 
            <p>Markup and scripts:</p>
            <script src="https://gist.github.com/leemark/de90c78cb73673650a5a.js"></script>
            <p>JavaScript code:</p>
            <script src="https://gist.github.com/leemark/046103061c89cdf07e4a.js"></script>
        </div> 
        <footer>All images used are the property of their respective owners. All code is <a href="https://github.com/leemark/better-simple-slideshow/blob/gh-pages/LICENSE">openly licensed</a>. Created especially for you by <a href="http://themarklee.com">Mark Lee</a> aka <a href="http://twitter.com/@therealmarklee">@therealmarklee</a> <br><span>&#9774; + &hearts;</span></footer>
        <script src="https://ironpdf.com/demo/js/hammer.min.js"></script>
        <script src="https://ironpdf.com/js/better-simple-slideshow.min.js"></script>
        <script>
            var opts = {
                auto : {
                    speed : 3500,
                    pauseOnHover : true
                },
                fullScreen : false,
                swipe : true
            };
            makeBSS('.num1', opts);
            var opts2 = {
                auto : false,
                fullScreen : true,
                swipe : true
            };
            makeBSS('.num2', opts2);
        </script>
    </body>
</html>
```

This version adjusts some language for clarity and modernity, updates links to HTTPS and absolute paths to ironpdf.com where relevant, and makes slight modifications to the descriptions for a more polished and engaging read.

In this example, a comprehensive array of HTML capabilities is employed. The rendering process is handled in-house by IronPDF, utilizing the Chromium HTML rendering engine and Google's v8 JavaScript engine. There's no need for separate installations on your system; when you integrate IronPDF, the whole setup is automatically incorporated into your project.

### 3.1 Incorporating Headers and Footers

Having successfully achieved a beautiful render of your PDF, the next step is to enhance the layout by adding elegant headers and footers.

Here's the paraphrased section of the article with resolved relative URL paths:

```vb
Imports IronPdf
Imports IronSoftware.Drawing

Module Module1
    Sub Main()
        ' Create a new PDF renderer instance
        Dim pdfRenderer = New ChromePdfRenderer()
        
        ' Configure rendering options for the PDF
        With pdfRenderer.RenderingOptions
            .CssMediaType = Rendering.PdfCssMediaType.Print
            .PrintHtmlBackgrounds = False
            .PaperOrientation = Rendering.PdfPaperOrientation.Landscape
            .WaitFor.RenderDelay(150)
            .TextHeader.CenterText = "VB.NET PDF Slideshow"
            .TextHeader.DrawDividerLine = True
            .TextHeader.FontSize = "13"
            .TextFooter.RightText = "Page {page} of {total-pages}"
            .TextFooter.Font = FontTypes.Arial
            .TextFooter.FontSize = "9"
        End With
        
        ' Render an HTML file to PDF with headers and footers
        Dim pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("https://ironpdf.com/slideshow/index.html")
        
        ' Save the generated PDF document
        pdfDocument.SaveAs("Html5WithHeader.pdf")
        
        ' Open the PDF document in the default viewer
        System.Diagnostics.Process.Start("Html5WithHeader.pdf")
    End Sub
End Module
```

This version reformulates the original code into a more structured and annotated format, improving clarity and resolving URL paths to absolute paths.

IronPDF also offers capabilities for including logical headers and footers within your documents. Additionally, developers have the option to insert headers and footers designed with HTML, as detailed in [the VB.NET PDF developer API reference online](https://ironpdf.com/object-reference/api/IronPdf.HtmlHeaderFooter.html).

For a practical application of these features, you can [download the source code](https://ironpdf.com/downloads/VB.Net.Pdf.Tutorial.zip) for the "VB.NET HTML to PDF" project, provided as a VB.NET Visual Studio project file. This allows you to explore and experiment with the code first-hand.

<hr class="separator">

## 4. Dynamic PDF Creation: Two Approaches

Creating PDFs with dynamic content has traditionally been a daunting task for software developers. The variability in content types and lengths makes it difficult to fit into static PDF templates. However, HTML provides flexibility in managing dynamic content effectively.

Below are two viable methods to dynamically generate PDFs:

1. HTML String Templation followed by conversion to PDF utilizing .NET technologies.
2. Convert an ASP.NET Web Page into a PDF by rendering the page directly to a PDF format.

### 4.1. Approach 1: ASP.NET - From ASPX to PDF Using VB.NET Web Forms

This approach is straightforward. Any form of .NET Web Form, even those that use Razor syntax, can be converted to a PDF document through the following VB.NET script, which is placed in the `Page_Load` method in the code-behind of VB.NET.

This configuration allows the PDF to either be displayed directly in the web browser or to be downloaded, depending on the specified content-disposition settings.

Here's a paraphrased version of the VB.NET code snippet you provided:

```vb
Imports IronPdf

Private Sub Form1_Load(sender As Object, e As EventArgs)
    ' Create rendering options for PDF conversion
    Dim options = New ChromePdfRenderOptions()
    ' Convert current ASPX page to PDF with specific settings
    AspxToPdf.RenderThisPageAsPDF(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", options)
End Sub
```

### 4.2 Technique 2 - Converting HTML to PDF Using String Templating

Creating dynamic PDF documents with content tailored to specific instances can be achieved effortlessly by constructing a HTML string that represents the data you intend to display in the PDF.

This approach is one of the biggest benefits of the HTML-to-PDF conversion using VB.NET—it offers an intuitive way to generate dynamic PDF documents and reports by dynamically generating HTML content.

The most basic method to accomplish this is through VB.NET's **String.Format** function.

Here's the paraphrased section of the article with the relative URL paths resolved as required:

```vb
' Import the IronPdf library
Imports IronPdf

Module Module1
    Sub Main()
        ' Initialize a new instance of ChromePdfRenderer
        Dim pdfRenderer = New ChromePdfRenderer()
        
        ' Define HTML content with a placeholder for dynamic text
        Dim htmlContent = "Hello {0}"
        
        ' Substitute the placeholder in the HTML string
        String.Format(htmlContent, "World")
        
        ' Convert the HTML string to a PDF document
        Dim pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent)
        
        ' Save the generated PDF to a file
        pdfDocument.SaveAs("HtmlTemplate.pdf")
        
        ' Open the saved PDF using the default viewer
        System.Diagnostics.Process.Start("HtmlTemplate.pdf")
    End Sub
End Module
```

As the complexity of PDF documents increases, the strings we use to create them may also need to become more complex. It could be beneficial to employ a `StringBuilder` or a sophisticated templating framework like HandleBars.Net or Razor to handle these complexities.

[HandleBars.Net on GitHub](https://github.com/rexm/Handlebars.Net)

<hr class="separator">

## 5. Modify PDF Documents with VB.NET

With IronPDF for VB.NET, you have the capability to edit, encrypt, watermark, and even convert PDF documents back to plain text:

### 5.1. Combining Several PDFs into a Single File using VB.NET

To integrate multiple PDF documents into a single file in VB.NET, you can utilize the IronPDF library which facilitates the merging process efficiently.

```vb
Dim pdfs = New List(Of PdfDocument)
pdfs.Add(PdfDocument.FromFile("A.pdf"))
pdfs.Add(PdfDocument.FromFile("B.pdf"))
pdfs.Add(PdfDocument.FromFile("C.pdf"))
Dim combinedPdf As PdfDocument = PdfDocument.Merge(pdfs)
combinedPdf.SaveAs("combined.pdf")
combinedPdf.Dispose()
For Each pdf As PdfDocument In pdfs
    pdf.Dispose()
Next
```

This code snippet demonstrates how to instantiate a list of `PdfDocument`, add several PDF files to this list, and then merge these files into one single document named "combined.pdf". Each document is loaded and then disposed of properly to free resources.

Here's a paraphrased and restructured version of the provided VB.NET code snippet, which merges multiple PDF documents into a single file:

```vb
' Create a new list to hold the PDF documents
Dim listOfPdfs = New List(Of PdfDocument)

' Add individual PDF files to the list
listOfPdfs.Add(PdfDocument.FromFile("A.pdf"))
listOfPdfs.Add(PdfDocument.FromFile("B.pdf"))
listOfPdfs.Add(PdfDocument.FromFile("C.pdf"))

' Merge all PDFs in the list into one single document
Dim combinedPdf As PdfDocument = PdfDocument.Merge(listOfPdfs)

' Save the merged PDF as a new file
combinedPdf.SaveAs("merged.pdf")

' Properly release the memory used by the merged PDF
combinedPdf.Dispose()

' Dispose each PDF document in the list to free resources
For Each singlePdf As PdfDocument In listOfPdfs
    singlePdf.Dispose()
Next
```

### 5.2. Inserting a Cover Page into Your PDF

You can easily add a cover page to your existing PDF document using IronPDF. This enhances the presentation of your document, making it more professional and reader-friendly. Here's a simple way to prepend a cover page:

```vb
pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
```

Below is the paraphrased section from the article:

```vb
pdf.AddPdfToBeginning(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
```

```vb
' Remove the final page from the PDF document
pdf.DeletePage(pdf.PageCount - 1)
```

Here is the paraphrased section with updated code snippet:

```vb
' Removing the final page from a PDF document
pdf.DeletePage(pdf.PageCount - 1)
```

```vb
// Implement robust security by encrypting the PDF with a secure password.
pdf.Password = "your-strong-password";
pdf.SaveAs("encrypted.pdf")
```

```vb
// Set a robust encryption password and save the PDF securely.
pdf.Password = "my.secure.password";
pdf.SaveAs("secured.pdf")
```

### 5.5 Embed Additional HTML Content into a PDF Page Using VB.NET

This functionality permits embedding HTML elements directly onto a page in a PDF. This feature is particularly useful for adding labels, marks, or other vital signs to your documents.

Below is an implementation in VB.NET that leverages IronPDF to apply an HTML stamp to an existing PDF page:

```vb
Imports IronPdf
Imports IronPdf.Editing

Module Module1
    Sub Main()
        Dim pdfRenderer = New ChromePdfRenderer()
        Dim pdfDocument = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
        Dim htmlStamp = New HtmlStamper()
        htmlStamp.Html = "<h2>Approved</h2>"  ' Define the HTML to be stamped on the PDF
        htmlStamp.Opacity = 50  ' Set the opacity for the stamp
        htmlStamp.Rotation = -45  ' Rotate the stamp by -45 degrees
        htmlStamp.VerticalAlignment = VerticalAlignment.Top  ' Align the stamp to the top of the page
        htmlStamp.VerticalOffset = New Length(10, UnitType.Pixels)  ' Move the stamp 10 pixels from the top
        pdfDocument.ApplyStamp(htmlStamp)  ' Apply the stamp to the PDF
        pdfDocument.SaveAs("C:\Path\To\Stamped.pdf")  ' Save the modified PDF to a file
        System.Diagnostics.Process.Start("C:\Path\To\Stamped.pdf")  ' Open the stamped PDF
    End Sub
End Module
```

This syntax demonstrates how to append a simple HTML snippet onto your PDF document, enhancing its usage for viewers or documentation standards.

Here's the paraphrased section from the original article with resolved URL paths:

```vb
' Required Imports for the IronPDF library and its editing features.
Imports IronPdf
Imports IronPdf.Editing

' Main program module.
Module Module1
    Sub Main()
        ' Create a new PDF renderer instance.
        Dim pdfRenderer = New ChromePdfRenderer()
        
        ' Render a PDF from a web URL.
        Dim generatedPdf = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")
        
        ' Prepare a new HTML stamp.
        Dim htmlStamp = New HtmlStamper() With {
            .Html = "<h2>Completed</h2>",  ' HTML content of the stamp.
            .Opacity = 50,                 ' Set stamp opacity to 50%.
            .Rotation = -45,               ' Rotate the stamp by -45 degrees.
            .VerticalAlignment = VerticalAlignment.Top,  ' Position at the top.
            .VerticalOffset = New Length(10)  ' Offset from the top by 10 units.
        }
        
        ' Apply the HTML stamp to the PDF.
        generatedPdf.ApplyStamp(htmlStamp)
        
        ' Save the stamped PDF to a specified path.
        generatedPdf.SaveAs("C:\Path\To\Stamped.pdf")
    End Sub
End Module
```

### 5.6. Implementing Page Breaks in PDFs Using HTML and CSS

Inserting page breaks into PDF documents can be effortlessly achieved using simple HTML and CSS.

Here's the paraphrased version of the specific HTML code section you provided:

```html
<div style='break-after: page;'>&nbsp;</div>
```

<hr class="separator">

## Additional .NET PDF Learning Resources

Explore more resources:

- View the comprehensive [VB.NET and C# API reference, styled like MSDN](https://ironpdf.com/object-reference/api/IronPdf.html), which covers all features of the IronPDF library.

- Learn how to convert ASPX pages to PDF specifically for VB.NET and C# in [this detailed tutorial](https://ironpdf.com/how-to/aspx-to-pdf/).

- Dive deep into the process of converting HTML to PDF for VB.NET and C# developers with [this in-depth guide](https://ironpdf.com/tutorials/html-to-pdf/).

<hr class="separator">



<h2>Conclusion</h2>

In this guide, we explored six different methods for converting VB.NET code into PDFs, all utilizing VB.NET as the programming language:

* Converting HTML strings directly into PDF format.
* Generating PDFs in VB.NET by defining PDF content with an HTML string.
* Transforming existing web URLs into PDF documents.
* Creating PDFs from HTML documents.
* Using HTML templating in VB.NET to produce dynamic PDFs.
* Converting live data from ASP.NET pages, like ASPX, into PDF documents.

For all these methods, we effectively utilized the widely recognized [IronPDF VB.NET library](https://ironpdf.com/use-case/vb-dot-net-library/) which facilitates direct HTML-to-PDF conversions within .NET environments.

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
      <h3>Download this Tutorial as Source Code</h3>
      <p>The full free VB.NET HTML to PDF Source Code for this tutorial is available to download as a zipped Visual Studio project file.</p>
      <a class="btn btn-white3" href="downloads/assets/tutorials/VB.Net.Pdf.Tutorial.zip">
        <i class="fa fa-cloud-download"></i> Download</a>
      </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-8">
      <h3>Explore this Tutorial on GitHub</h3>
      <p> You may also be interested in our extensive library of VB.NET PDF generation and manipulation examples on GitHub. Exploring source code is the fastest way to learn, and Github is the definitive way to do so online.  I hope these examples help you get to grips with PDF related functionality in your VB projects. </p>
      <a class="doc-link" href="https://github.com/iron-software/iron-pdf-example-asp.net-create-pdf" target="_blank">Creating PDFS in ASP.NET with VB.NET and C# Source<i class="fa fa-chevron-right"></i></a>
      <a class="doc-link" href="https://github.com/iron-software/iron-pdf-example-hello-world-vb.net" target="_blank">A Simple Hello World Project to Render HTML to PDF in VB.NET using IronPDF<i class="fa fa-chevron-right"></i></a>
      <a class="doc-link" href="https://github.com/iron-software/iron-pdf-example-html-to-pdf-vb.net" target="_blank">Exploring HTML To PDF in-depth with VB.NET<i class="fa fa-chevron-right"></i></a>
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
      <h3>Download C# PDF Quickstart guide</h3>
      <p>To make developing PDFs in your .NET applications easier, we have compiled a quick-start guide as a PDF document. This "Cheat-Sheet" provides quick access to common functions and examples for generating and editing PDFs in C# and VB.NET - and will save time getting started using IronPDF in your .NET project.</p>
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

