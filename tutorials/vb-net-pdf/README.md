# VB.NET PDF Creator (Code Example Tutorial)

***Based on <https://ironpdf.com/tutorials/vb-net-pdf/>***


This guide will walk you through the process of creating and editing PDF files using VB.NET. This method is applicable to various types of applications including **ASP.NET web apps**, **console applications**, **Windows Services**, and **desktop programs**. We will focus on PDF creation projects targeting .NET Framework 4 or .NET Core 2. To get started, you'll need a Visual Basic .NET development environment, like Microsoft Visual Studio Community.

## Quickstart: Generate Your Initial PDF in VB.NET

Begin your journey with IronPDF in VB.NET by generating your first PDF file with just a couple of lines of code. This introductory guide illustrates how seamlessly IronPDF can be integrated into your .NET applications, enabling you to quickly create high-quality PDF documents. Convert your HTML content into polished PDF files effortlessly. Here's a straightforward example to show you how rapidly you can create your initial PDF while discovering the myriad of features IronPDF has to offer for your projects.

```cs
:title=Quick PDF Generation with IronPDF
Dim myPdf As New IronPdf.PdfDocument() 
myPdf.SaveAs("your_first_pdf.pdf")
```

### Minimalistic Workflow: 5 Essential Steps

1. [Acquire the VB.NET PDF Library](https://nuget.org/packages/IronPdf/)

2. Generate a PDF using the VB.NET framework.

3. Design and style your PDF.

4. Decide on the approach to integrate dynamic elements.

5. Modify and manipulate your PDF through the VB.NET interface.

## Generating and Editing PDFs in VB.NET with IronPDF

Effortlessly convert HTML to PDF using VB.NET, style your documents, incorporate dynamic content, and manage your files conveniently. The process of creating PDFs is straightforward and compatible with multiple .NET versions including .NET Framework 4, .NET Core 3.1, as well as .NET 5 and 6. You don't need to worry about using proprietary file formats or different APIs.

This guide provides detailed documentation to help you navigate each step using the developer-preferred [IronPDF](https://ironpdf.com) that is free during development phases. The code examples in VB.NET are tailored to address specific scenarios, making it simple for you to follow the procedures in an environment you're comfortable with. The VB.NET PDF Library boasts extensive capabilities for creation and customization suitable for a variety of projects from ASP.NET applications to console and desktop applications.

### Features Included with IronPDF

- Access dedicated ticket-based support from our authentic .NET PDF Library team, ensuring you get help from real experts!

- Enjoy compatibility with HTML, ASPX forms, MVC views, images, and every other document format you are accustomed to using.

- Experience a streamlined setup process with Microsoft Visual Studio to get your PDF projects up and running quickly.

- Benefit from an unlimited free development period, with affordable licensing options available when you're ready to launch commercially, beginning at `$liteLicense`.

---

## Step 1

### 1. Acquire the VB .NET PDF Library at No Cost from IronPDF

**Start a Free Trial by Installing via NuGet:**

Open your Visual Studio environment, navigate to your project in the solution explorer, right-click, and choose "Manage NuGet Packages...". Search for "IronPDF" and install the newest version available. Confirm any prompts that appear to complete the installation.

This method is applicable for any C# .NET Framework project starting from Framework 4, as well as .NET Core from version 2 and upwards. It is also compatible with VB.NET projects.

```shell
Install-Package IronPdf
```

[Find IronPdf on NuGet](https://www.nuget.org/packages/IronPdf)

**Manual Installation via DLL:**

You can also opt to download the IronPDF DLL and manually incorporate it into your project or Global Assembly Cache (GAC) from [IronPDF Downloads](https://ironpdf.com/packages/IronPdf.zip).

Add this line to the top of your VB.NET files to use IronPDF:
```vbnet
Imports IronPdf
```

### 1. Acquire the Free VB .NET PDF Library from IronPDF

**Installation via NuGet:**

To begin using IronPDF in your VB.NET projects, open Visual Studio, navigate to your project in the Solution Explorer, right-click it, and choose "Manage NuGet Packages...". In the search bar, type "IronPDF" and install the most recent version, accepting any confirmation dialogs that appear.

This installation is compatible across various project types, including C# .NET Framework (version 4 onwards) and .NET Core (from version 2). It is equally functional in VB.NET environments.

```shell
Install-Package IronPdf
```

```vbnet
' Import IronPDF namespace to utilize its features
Imports IronPdf
```

**Alternative Installation Method: DLL**

As an alternative to the NuGet package, you may choose to download the IronPDF DLL directly and integrate it manually into your project or the Global Assembly Cache (GAC). Download the DLL from the following link: [IronPDF Download](https://ironpdf.com/packages/IronPdf.zip).

**Implementation in Visual Basic.NET**

For utilizing IronPDF in your VB.NET project, ensure to include the appropriate namespace at the beginning of your class file by adding the following import statement:

```vbnet
Imports IronPdf
```

# VB.NET PDF Creator (Code Example Tutorial)

***Based on <https://ironpdf.com/tutorials/vb-net-pdf/>***


Explore how to construct and modify PDF files using VB.NET in this detailed guide. Perfect for any .NET application such as **ASP.NET web apps**, **console applications**, **Windows Services**, and **desktop applications**, the techniques illustrated here are designed for projects targeting either .NET Framework 4 or .NET Core 2. Just ensure you have a Visual Basic .NET development setup like Microsoft Visual Studio Community.

### Quickstart: How to Make Your First PDF with VB.NET

Kick off your PDF creation journey in VB.NET with IronPDF by quickly crafting your initial PDF file in just a couple of lines. This quickstart provides a seamless way to add IronPDF into your applications, facilitating the immediate generation of high-quality PDFs from HTML content. Follow this straightforward example to rapidly produce your own PDF and delve into the extensive capabilities of IronPDF for your various projects.

```cs
:title=Efficient PDF Creation with IronPDF
Dim MyPdf As New IronPdf.PdfDocument()
MyPdf.SaveAs("example.pdf")
```

### Basic Steps for Creating PDFs (5 Essential Actions)

1. [Acquire the VB.NET PDF Library](https://nuget.org/packages/IronPdf/)
2. Create a PDF document using VB.NET Libraries
3. Refine PDF document styles
4. Utilize methods to generate dynamic content
5. Modify your PDFs using VB.NET Libraries

## Practical PDF Generation and Editing using VB.NET with IronPDF

Effortlessly convert HTML into PDFs in VB.NET, personalize the styling, leverage dynamic contents, and modify PDF documents conveniently. The process aligns seamlessly with various .NET frameworks such as .NET 4, .NET Core 3.1, and .NET 5 & 6, avoiding reliance on proprietary formats or multiple APIs.

This guide provides comprehensive documentation to assist you in each step using [IronPDF's free library](https://ironpdf.com), a top choice among developers. The provided VB.NET code examples fit well within your project context, enhancing understandability and ease of use. This VB.NET PDF Library is equipped with extensive creation and adjustment features suitable for all kinds of .NET applications, whether on the web, console, or desktop.

#### IronPDF Inclusions

- Direct support from our .NET PDF Library team (real people!)
- Compatible with HTML, ASPX forms, MVC views, images, and familiar document formats
- Quick and simple setup through Microsoft Visual Studio
- Perpetual free development use, with live deployment licenses starting from `$liteLicense`

---

## Step 1: Download the VB.NET PDF Library for FREE from IronPDF

### **Start Your Trial with IronPDF Now**

**Install via NuGet:**

In Visual Studio, right-click your project in the solution explorer and select "Manage NuGet Packages...". Search for IronPDF and confirm the install of the latest version through any prompted dialog boxes.

This is compatible with any C# .NET Framework project, starting from Framework 4 or .NET Core 2, and also in VB.NET projects.

```shell
/Install-Package IronPdf
```

[NuGet Package - IronPdf](https://www.nuget.org/packages/IronPdf)

**Install via DLL:**

Alternatively, you can manually download and install the IronPDF DLL into your project or Global Assembly Cache (GAC) from [IronPDF Downloads](https://ironpdf.com/packages/IronPdf.zip).

Add the following line at the top of any **VB.NET** class file to use IronPDF:
```vbnet
Imports IronPdf
```

---

## Step-by-Step Guides for PDF Creation and Editing in VB.NET

### 2. Crafting Your First PDF with VB.NET

Utilizing **Visual Basic ASP.NET**, crafting your initial PDF document is straightforward with the use of IronPDF. IronPDF leverages a highly capable rendering engine based on Google's Chromium, allowing you to design your content with HTML and precisely render it into a PDF file.

**Get started with coding in VB.NET for PDF creation:**

```vbnet
Module Module1
    Sub Main()
        Dim pdfRenderer = New ChromePdfRenderer()
        Dim createdPdf = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to Your First PDF</h1>")
        createdPdf.SaveAs("FirstPDF.pdf")
    End Sub
End Module
```

To enhance the experience, employ the `System.Diagnostics.Process.Start` to open the created PDF using the default viewer in your system.

**Rendering a web page as a PDF document:**

```vbnet
Imports IronPdf

Module Module1
    Sub Main()
        Dim pdfProducer = New ChromePdfRenderer()
        Dim pdfFromUrl = pdfProducer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
        pdfFromUrl.SaveAs("WebPageAsPdf.pdf")
        System.Diagnostics.Process.Start("WebPageAsPdf.pdf")
    End Sub
End Module
```

To ensure your PDF meets compliance standards, such as [PDF/A](ironpdf.com/how-to/pdfa/), utilize IronPDF followed by an application like Ghostscript for conversion.

---

### 3. Adding Styles to PDFs in VB.NET

For styling your PDFs, VB.NET allows tremendous flexibility using CSS, JavaScript, and images. You can incorporate local resources or refer to external assets like Google Fonts. Use [Data URIs](ironpdf.com/how-to/datauris/) for embedding images directly within your HTML string.

For a structured approach:

1. Design and finalize your HTML.
2. Convert the HTML to a PDF using VB.NET and IronPDF for an effective final document.

**Here's how to convert a styled HTML file to PDF:**

```vbnet
Imports IronPdf

Module Module3
    Sub Main()
        Dim pdfRenderer = New HtmlToPdf()

        ' Set options for PDF rendering
        pdfRenderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print
        pdfRenderer.PrintOptions.EnableHtmlBackgrounds = False
        pdfRenderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape
        pdfRenderer.PrintOptions.RenderDelay = 500  ' Delay in milliseconds

        ' Convert HTML to PDF
        Dim resultedPdf = pdfRenderer.RenderHtmlFileAsPdf("yourfile.html")
        resultedPdf.SaveAs("StyledPDF.pdf")
    End Sub
End Module
```

**Sample HTML for a Responsive Slideshow**:

This HTML code sets up a responsive slideshow which can be found on [GitHub](https://github.com/leemark/better-simple-slideshow):

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Responsive Slideshow</title>
        <link rel="stylesheet" href="css/slideshow-styles.css">
    </head>
    <body>
        <header>
            <h1>Interactive Slideshow Demo</h1>
        </header>
        <div class="slideshow-container">
            <figure>
                <figcaption>Caption Here</figcaption>
                <img src="img/slide1.jpg" alt="Slideshow Image 1">
            </figure>
            <figure>
                <figcaption>Caption Here</figcaption>
                <img src="img/slide2.jpg" alt="Slideshow Image 2">
            </figure>
        </div>
    </body>
</html>
```

When the HTML is rendered to PDF using IronPDF, all features like external fonts and dynamic layouts are retained, resulting in a polished and professional PDF document.

### 2. Generate a PDF in VB.NET

Creating a PDF using **Visual Basic ASP.NET** for the first time is straightforward with IronPDF, especially when compared to other libraries with more bespoke APIs like ***iTextSharp***.

Leverage HTML (featuring a pixel-perfect rendering engine powered by Google's Chromium) to craft your PDF's content and then seamlessly produce the final document.

**Basic code example for generating a PDF in VB.NET:**

```vbnet
Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderHtmlAsPdf("<h1>My First VB.NET PDF</h1>")
        document.SaveAs("FirstPDF.pdf")
    End Sub
End Module
```

Here's the paraphrased section of the VB.NET code snippet for creating a PDF file:

```vbnet
Module Module1
    Sub Main()
        ' Initialize a new instance of ChromePdfRenderer
        Dim pdfRenderer = New ChromePdfRenderer()

        ' Convert HTML code to a PDF document
        Dim pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to VB.NET PDF Generation!</h1>")

        ' Save the generated PDF to a file
        pdfDocument.SaveAs("WelcomeDocument.pdf")
    End Sub
End Module
```

In this revised version, I've changed variable names for clarity, altered the HTML content slightly, and updated the output file name to reflect a more specific scenario.

To make the project more engaging, the PDF is automatically opened in the operating system's default PDF viewer using the `System.Diagnostics.Process.Start` method.

**Convert an Online Web Page to a PDF Document:**

```vbnet
' Include the IronPdf namespace
Imports IronPdf

' Define the main Module
Module MyPdfModule
    Sub Main()
        ' Create a new instance of ChromePdfRenderer
        Dim pdfRenderer = New ChromePdfRenderer()
        ' Render a PDF from a webpage
        Dim pdfDocument = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
        ' Save the rendered PDF to a file
        pdfDocument.SaveAs("DownloadedPdf.pdf")
        ' Open the saved PDF using the default PDF reader
        System.Diagnostics.Process.Start("DownloadedPdf.pdf")
    End Sub
End Module
```

Create your PDF document using IronPDF, and then utilize Ghostscript to convert it into the [PDF/A format](https://ironpdf.com/how-to/pdfa/).

### 3. Styling PDFs in VB.NET

In VB.NET, styling your PDF content is versatile, utilizing CSS, JavaScript, and images. Incorporate both local and remote/CDN resources like Google Fonts, and even employ [DataURIs for embedding images directly into your HTML as strings](https://ironpdf.com/how-to/datauris/).

For sophisticated designs, the process involves two essential steps:

1. Perfectly craft and design your HTML content, potentially involving your design team.
2. Convert that HTML into a PDF with VB.NET using our robust PDF Library.

**Example VB.NET Code for Converting HTML to PDF:**

```vbnet
' Initialize PDF renderer
Dim Renderer = New HtmlToPdf()

' Set rendering options
Renderer.PrintOptions.CssMediaType = IronPdf.Rendering.PdfPrintOptions.PdfCssMediaType.Print
Renderer.PrintOptions.EnableHtmlBackgrounds = False
Renderer.PrintOptions.PaperOrientation = IronPdf.Rendering.PdfPrintOptions.PdfPaperOrientation.Landscape
Renderer.PrintOptions.RenderDelay = 500 ' milliseconds adjustment for content rendering

' Convert the well-crafted HTML to PDF
Dim PDF = Renderer.RenderHtmlFileAsPdf("path/to/yourfile.html")

' Save the styled PDF document
PDF.SaveAs("StyledPDF.pdf")
```

This method allows you to leverage full HTML and CSS capabilities to design your PDF files, making them as interactive and engaging as possible.

```vbnet
Imports IronPdf

' Create the PDF rendering module
Module StylePDFGenerator
    Sub Main()
        ' Construct a new PDF renderer
        Dim pdfRenderer = New HtmlToPdf()

        ' Define printing options
        pdfRenderer.PrintOptions.CssMediaType = IronPdf.Rendering.PdfPrintOptions.PdfCssMediaType.Print
        pdfRenderer.PrintOptions.EnableHtmlBackgrounds = False
        pdfRenderer.PrintOptions.PaperOrientation = IronPdf.Rendering.PdfPrintOptions.PdfPaperOrientation.Landscape
        pdfRenderer.PrintOptions.RenderDelay = 500 ' Delay in milliseconds to allow for content rendering

        ' Convert an HTML document to PDF
        Dim createdPdf = pdfRenderer.RenderHtmlFileAsPdf("yourfile.html")

        ' Save the generated PDF
        createdPdf.SaveAs("styled_output.pdf")
    End Sub
End Module
```

**Sample HTML File**

This HTML code produces a responsive, mobile-friendly slideshow. You can access the complete source code at [this GitHub repository](https://github.com/leemark/better-simple-slideshow).

```html
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Crafting a Customizable Responsive Slideshow Using HTML5, CSS3, and JavaScript</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href='http://fonts.googleapis.com/css?family=Open+Sans|Open+Sans+Condensed:700' rel='stylesheet' type='text/css'>
        <link rel="stylesheet" href="demo/css/demostyles.css">
        <link rel="stylesheet" href="css/simple-slideshow-styles.css">
    </head>
    <body>
        <!--[if lt IE 8]>
            <p class="browsehappy">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
        <header>
            <h1>Enhanced Simple Slideshow</h1>
            <p><span class="desc">A straightforward DIY responsive JavaScript slideshow.</span> [<a href="https://github.com/leemark/better-simple-slideshow">GitHub<span> repo</span></a>]</p>
        </header>
        <div class="bss-slides num1" tabindex="1" autofocus="autofocus">
            <figure>
              <img src="demo/img/medium.jpg" width="100%" /><figcaption>"Medium" by <a href="https://www.flickr.com/photos/thomashawk/14586158819/">Thomas Hawk</a>.</figcaption>
            </figure>
            <figure>
              <img src="demo/img/colorado.jpg" width="100%" /><figcaption>"Colorado" by <a href="https://www.flickr.com/photos/stuckincustoms/88370744">Trey Ratcliff</a>.</figcaption>
            </figure>
            <figure>
              <img src="demo/img/monte-vista.jpg" width="100%" /><figcaption>"Early Morning at the Monte Vista Wildlife Refuge, Colorado" by <a href="https://www.flickr.com/photos/davesoldano/8572429635">Dave Soldano</a>.</figcaption>
            </figure>
            <figure>
              <img src="demo/img/sunrise.jpg" width="100%" /><figcaption>"Sunrise in Eastern Colorado" by <a href="https://www.flickr.com/photos/35528040@N04/6673031153">Pam Morris</a>.</figcaption>
            </figure>
            <figure>
              <img src="demo/img/colorado-colors.jpg" width="100%" /><figcaption>"Colorado Colors" by <a href="https://www.flickr.com/photos/cptspock/2857543585">Jasen Miller</a>.</figcaption>
            </figure>
        </div>
<div class="content">
<h2>Introduction</h2>
<p>This javascript slideshow is simple yet functional. It can be effortlessly embedded within your website and serves both as an operational component and a methodological guide for crafting your own slideshow. <a href="http://themarklee.com/2014/10/05/better-simple-slideshow/">View the tutorial/walkthrough here</a>.</p>
<h2>Key Features</h2>
<ul>
    <li>fully responsive</li>
    <li>automatic or manual slide advancements</li>
    <li>enables multiple slideshows on a single page</li>
    <li>support for keyboard arrow navigation</li>
    <li>full-screen capability through the HTML5 Fullscreen API</li>
    <li>touch swipe functionality supported on mobile devices (requires <a href="https://github.com/hammerjs/hammer.js">Hammer.js</a>)</li>
    <li>developed with pure JavaScript, no jQuery required (but still a big &hearts; for <a href="https://github.com/jquery/jquery">jQuery</a>)</li>
</ul>
<h2>Getting Started</h2>
<ol>
<li><p>The HTML structure for the slideshow is straightforward: wrap your slides inside a container, typically a <span class="code">&lt;div&gt;</span>, with each individual slide encapsulated by a <span class="code">&lt;figure&gt;</span> tag.</p>
<script src="https://gist.github.com/leemark/83571d9f8f0e3ad853a8.js"></script> </li>
<li>Include the slideshow script: either <span class="code">js/better-simple-slideshow.min.js</span> or <span class="code">js/better-simple-slideshow.js</span></li>
<li>Link the related stylesheet: <span class="code">css/simple-slideshow-styles.css</span></li>
<li>Activate the slideshow:
<script src="https://gist.github.com/leemark/479d4ecc4df38fba500c.js"></script>
</li>
</ol>
<h2>Customization Options</h2>
To tailor the slideshow functionality, construct an options object and input it into <span class="code">makeBSS()</span> as the secondary parameter as illustrated below:
<script src="https://gist.github.com/leemark/c6e0f5c47acb7bf9be16.js"></script>
<h2>Practical Examples</h2>
    <h3>Example #1 (the slideshow at the beginning)</h3>
    <p>Visual representation in HTML:</p>
    <script src="https://gist.github.com/leemark/19bafdb1abf8f6b4e147.js"></script>
    <p>Corresponding JavaScript:</p>
    <script src="https://gist.github.com/leemark/a09d2726b5bfc92ea68c.js"></script>
    <h3>Example #2 (displayed below)</h3>
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
<p>HTML structure:</p>
<script src="https://gist.github.com/leemark/de90c78cb73673650a5a.js"></script>
<p>Respective JavaScript:</p>
<script src="https://gist.github.com/leemark/046103061c89cdf07e4a.js"></script>
</div> 
<footer>Images are property of their respective owners; all code is <a href="https://github.com/leemark/better-simple-slideshow/blob/gh-pages/LICENSE">freely licensed for usage</a>. <br>Created for you by <a href="http://themarklee.com">Mark Lee</a> alias <a href="http://twitter.com/@therealmarklee">@therealmarklee</a> <br><span>&#9774; + &hearts;</span></footer>
<script src="demo/js/hammer.min.js"></script>
<script src="js/better-simple-slideshow.min.js"></script>
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

This example demonstrates the comprehensive capabilities of an HTML web page. The rendering process is handled by IronPDF, which utilizes Google's Chromium HTML engine and v8 JavaScript engine. There's no need for separate installations on your system; the complete set is seamlessly integrated into your project whenever you employ IronPDF.

### 3.1. Enhancing PDFs with Headers and Footers

After creating an elegant PDF, you might consider enhancing its appearance by integrating appealing headers and footers. This addition can significantly improve the document's professionalism and readability.

Here is your paraphrased section:

```vbnet
' Import necessary IronPDF and Drawing libraries
Imports IronPdf
Imports IronSoftware.Drawing

Module Module1
    Sub Main()
        ' Create a new renderer instance
        Dim pdfRenderer = New ChromePdfRenderer()
        
        ' Set up rendering options
        With pdfRenderer.RenderingOptions
            .CssMediaType = Rendering.PdfCssMediaType.Print
            .PrintHtmlBackgrounds = False
            .PaperOrientation = Rendering.PdfPaperOrientation.Landscape
            .WaitFor.RenderDelay(150) ' Delay rendering to ensure contents are fully loaded
            .TextHeader.CenterText = "VB.NET PDF Slideshow"
            .TextHeader.DrawDividerLine = True
            .TextHeader.FontSize = "13"
            .TextFooter.RightText = "page {page} of {total-pages}"
            .TextFooter.Font = FontTypes.Arial
            .TextFooter.FontSize = "9"
        End With
        
        ' Render the HTML file as a PDF document
        Dim pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("..\..\slideshow\index.html")
        
        ' Save the PDF to a file
        pdfDocument.SaveAs("Html5WithHeader.pdf")
        
        ' Open the PDF document in the default viewer
        System.Diagnostics.Process.Start("Html5WithHeader.pdf")
    End Sub
End Module
```

HTML headers and footers can be included as detailed in the [VB.NET PDF development API reference](https://ironpdf.com/object-reference/api/IronPdf.HtmlHeaderFooter.html).

Additionally, you can access and review the [source code of the "VB.NET HTML to PDF" project](https://ironpdf.com/downloads/VB.Net.Pdf.Tutorial.zip) available as a Visual Studio project designed for VB.NET.

### 4. Generating Dynamic PDFs: Two Effective Techniques

Creating template-based PDFs has traditionally posed significant challenges for software developers due to the diversity and complexity of content. Interestingly, HTML proves to be a robust medium capable of adeptly managing dynamic information.

We offer two effective methods for producing dynamic PDF documents:

1. Employ HTML string templating followed by its conversion to a PDF with .NET technology.
2. Output content via an ASP.NET web page and subsequently convert this page into a PDF document.

#### 4.1. Approach 1 - ASP.NET - Converting ASPX to PDF with VB.NET Web Forms

This method is refreshingly straightforward. You can convert any type of .NET Web Form, Razor included, into a PDF using VB.NET. This is done within the `Page_Load` event handler in the code-behind file of your ASP.NET application.

You can configure the resulting PDF to either display directly in a web browser or to be downloaded as a file, using the content-disposition header.

Here is the paraphrased section of the article with resolved URL paths:

```vbnet
Imports IronPdf

Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
    ' Initialize PDF rendering options using IronPDF
    Dim pdfRenderOptions = New IronPdf.ChromePdfRenderOptions()
    ' Convert the current ASPX web page to PDF and specify the behavior as an attachment file
    IronPdf.AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", pdfRenderOptions)
End Sub
```

#### 4.2. Approach 2 - Generating PDFs Using HTML String Templates

Generating PDFs that contain specific data requires constructing an HTML string that corresponds to the desired content of your PDF.

One of the key benefits of this method in VB.NET is the straightforward and intuitive creation of dynamic PDFs, allowing developers to construct and manipulate HTML content dynamically before converting it to PDF.

**Here's the simplest way to accomplish this using the `String.Format` method in VB.NET:**

```vbnet
Imports IronPdf

Module Module1
    Sub Main()
        ' Create a Chrome-based PDF renderer
        Dim renderer = New ChromePdfRenderer()
        
        ' Define HTML content with a format placeholder
        Dim HtmlContent = "Hello {0}"
        
        ' Insert dynamic data into HTML
        HtmlContent = String.Format(HtmlContent, "World")
        
        ' Render the HTML string to a PDF document
        Dim pdfDocument = renderer.RenderHtmlAsPdf(HtmlContent)

        ' Save the generated PDF
        pdfDocument.SaveAs("DynamicHtmlToPdf.pdf")
        
        ' Optionally, open the PDF in the default viewer
        System.Diagnostics.Process.Start("DynamicHtmlToPdf.pdf")
    End Sub
End Module
```

This code snippet efficiently creates a personalized PDF document by embedding dynamic data directly into the HTML structure, illustrating a practical use case of HTML templating in VB.NET.

Below is the paraphrased version of the given VB.NET code snippet:

```vbnet
' Include the IronPDF namespace
Imports IronPdf

' Main module where PDF operation takes place
Module Module1
    Sub Main()
        ' Create a new instance of ChromePdfRenderer
        Dim pdfRenderer = New ChromePdfRenderer()
        ' Prepare the HTML string with a placeholder
        Dim htmlContent = "Hello {0}"
        ' Replace the placeholder with the actual string
        String.Format(htmlContent, "World")
        ' Convert the HTML string to a PDF document
        Dim pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent)
        ' Save the generated PDF to a file
        pdfDocument.SaveAs("HtmlTemplate.pdf")
        ' Automatically open the PDF document after creation
        System.Diagnostics.Process.Start("HtmlTemplate.pdf")
    End Sub
End Module
```

This reformulated code retains the original functionality while reframing some of the variables and comments for clarity.

As the complexity of PDFs increases, more intricate Strings are necessary. It's advisable to utilize a `StringBuilder` or a sophisticated templating framework such as HandleBars.Net or Razor to manage this complexity effectively. You can learn more about HandleBars.Net [here](https://github.com/rexm/Handlebars.Net).

## 5. Manipulate PDF Files with VB.NET

IronPDF provides capabilities for VB.NET developers to modify PDF files by performing several operations such as editing, encrypting, applying watermarks, and converting them to plain text.

### 5.1. Combining Several PDFs into a Single File Using VB.NET

In VB.NET, you can efficiently consolidate multiple PDF documents into a single file using IronPDF. This feature is particularly beneficial for managing large numbers of documents or creating composite reports. Here’s a step-by-step guide:

```vbnet
' Create a list to hold your PDF documents
Dim pdfCollection = New List(Of PdfDocument)

' Add PDF files to the list
pdfCollection.Add(PdfDocument.FromFile("Document1.pdf"))
pdfCollection.Add(PdfDocument.FromFile("Document2.pdf"))
pdfCollection.Add(PdfDocument.FromFile("Document3.pdf"))

' Merge all PDFs into one document
Dim combinedPdf As PdfDocument = PdfDocument.Merge(pdfCollection)

' Save the merged PDF to a new file
combinedPdf.SaveAs("CombinedDocument.pdf")

' Clean up resources by disposing of the PDFs
combinedPdf.Dispose()
For Each pdf As PdfDocument In pdfCollection
    pdf.Dispose()
Next
```

Here's a paraphrased section of the VB.NET code for merging PDF documents:

```vbnet
' Create a new list to hold PdfDocument objects
Dim listOfPdfs = New List(Of PdfDocument)

' Add PDF files to the list
listOfPdfs.Add(PdfDocument.FromFile("A.pdf"))
listOfPdfs.Add(PdfDocument.FromFile("B.pdf"))
listOfPdfs.Add(PdfDocument.FromFile("C.pdf"))

' Merge the PDF files into a single document
Dim combinedPdf As PdfDocument = PdfDocument.Merge(listOfPdfs)

' Save the merged PDF document
combinedPdf.SaveAs("combined_output.pdf")

' Clean up: Dispose of the merged PDF document
combinedPdf.Dispose()

' Clean up: Dispose each individual PDF document
For Each individualPdf As PdfDocument In listOfPdfs
    individualPdf.Dispose()
Next
```

```vbnet
// Prepend a cover page to an existing PDF document
pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Front Cover</h1><hr>"))
```

The section you provided adds a cover page to a PDF document. Here is a paraphrased version of that code snippet:

```vbnet
pdf.AddToFront(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
```

### 5.3. Delete the Final Page of the PDF

To remove the last page from your PDF document using VB.NET, execute the following simple command: 

```vbnet
pdf.RemovePage(pdf.PageCount - 1)
```

Here's how you could rewrite the provided VB.NET code snippet:

```vbnet
' Remove the last page from the PDF document
pdf.RemovePage(pdf.PageCount - 1)
```

### 5.4. Secure a PDF with 128-Bit Encryption

Encrypt your PDF document using 128-bit encryption to enhance its security. This process ensures that your sensitive data remains protected, requiring a password for access.

```vbnet
' Apply a strong password for encryption.
pdf.Password = "my.secure.password"
pdf.SaveAs("secured.pdf")
``` 

By setting a secure password, you limit the accessibility of the PDF to only those who possess the correct credentials, safeguarding your document from unauthorized access.

```vbnet
// Utilize high-security encryption with a robust password.
pdf.Password = "my.secure.password";
pdf.SaveAs("secured.pdf")
```

### 5.5. Inserting HTML Overlays in PDFs with VB.NET

Using VB.NET, you can seamlessly introduce additional HTML content onto your PDF pages utilizing the IronPDF library. This procedure allows you to add customized content over the primary PDF in a non-intrusive way.

```vbnet
Imports IronPdf
Imports IronPdf.Editing

Module Module1
    Sub Main()
        'Initialize the PDF renderer to fetch the PDF file
        Dim renderer = New ChromePdfRenderer
        'Generate PDF from an HTML source
        Dim pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")
        'Configure the HTML stamper for adding overlay content
        Dim stamp = New HtmlStamper() 
        stamp.Html = "<h2>Document Finalized</h2>" ' HTML content to overlay
        stamp.Opacity = 50 ' Set the opacity for the stamp overlay
        stamp.Rotation = -45 ' Degree of rotation for the text
        stamp.VerticalAlignment = VerticalAlignment.Top ' Positioning the stamp at the top
        stamp.VerticalOffset = New Length(10) ' Offset position from vertical start point
        'Apply the HTML stamp to the PDF
        pdf.ApplyStamp(stamp)
        'Save the newly stamped PDF to a file location
        pdf.SaveAs("C:\Path\To\Stamped.pdf")
    End Sub
End Module
```

This functionality allows for dynamic customization of PDF documents, providing an effective method for adding annotations, watermarks, or other pertinent information directly onto the PDF page.

```vbnet
' Include required namespaces
Imports IronPdf
Imports IronPdf.Editing

' Entry point of VB.NET Script
Module Module1
    Sub Main()
        ' Create a PDF renderer instance
        Dim pdfRenderer = New ChromePdfRenderer()

        ' Convert URL to PDF
        Dim outputPdf = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")

        ' Create an HTML stamp
        Dim htmlStamp = New HtmlStamper()
        htmlStamp.Html = "<h2>Completed</h2>"
        htmlStamp.Opacity = 50
        htmlStamp.Rotation = -45
        htmlStamp.VerticalAlignment = VerticalAlignment.Top
        htmlStamp.VerticalOffset = New Length(10)

        ' Apply the HTML stamp to the PDF
        outputPdf.ApplyStamp(htmlStamp)

        ' Save the stamped PDF to a file
        outputPdf.SaveAs("C:\Path\To\Stamped.pdf")
    End Sub
End Module
```

### 5.6. Inserting Page Breaks into PDFs Using HTML

You can seamlessly introduce page breaks in your PDF documents by leveraging HTML and CSS. This method is straightforward and effective for managing content flow across PDF pages.

```html
<div style='page-break-after: always;'>&nbsp;</div>
```

# VB.NET PDF Creator (Code Sample Tutorial)

***Based on <https://ironpdf.com/tutorials/vb-net-pdf/>***


Explore how to produce and modify PDF documents using VB.NET in this detailed tutorial. Whether you're working on an ASP.NET web application, a console, a Windows service, or a desktop program, this method is versatile. Targeting both .NET Framework 4 and .NET Core 2, all you require is a Visual Basic .NET development setup, ideally via Microsoft Visual Studio Community.

## Quickstart: Generate Your First PDF with VB.NET

Dive into using IronPDF in VB.NET and craft your initial PDF in just a couple of lines. This beginner's guide shows how smoothly IronPDF integrates with your .NET applications, enabling swift PDF document creation. Leverage IronPDF to turn HTML content into high-quality PDF files. Check out this straightforward example to quick-start your PDF creation journey and uncover the robust features that IronPDF offers for your development projects.

```vb
:title=Quick PDF Generation Using IronPDF
Dim PDF As New IronPdf.PdfDocument()
PDF.SaveAs("example.pdf")
```

## Simple Steps (5-Step Workflow)

1. [Acquire the VB.NET PDF Library](https://www.nuget.org/packages/IronPdf/)
2. Instantiate a PDF document using the VB.NET Library
3. Tailor your PDF document's appearance
4. Select methods to generate dynamic content
5. Modify PDF files using the VB.NET Library

## VB.NET Examples for PDF Creation and Modification with IronPDF

Easily convert HTML to PDF, implementing styles, dynamic content, and editing capabilities within VB.NET. The process is straightforward and supports various .NET environments including NET Framework 4, .NET Core 3.1, .NET 6, and NET 5, without requiring proprietary file types or distinct APIs.

Access detailed step-by-step documentation in this tutorial that leverages the freely available [IronPDF software, a favorite among developers](https://ironpdf.com). The VB.NET code examples provided are tailored to specific scenarios, ensuring ease of understanding in a context that feels familiar. This VB.NET PDF Library boasts extensive creation and customization capabilities suitable for use in ASP.NET applications, consoles, and desktop environments.

### Benefits of Using IronPDF

- Direct ticket support from our dedicated .NET PDF Library team (actual people!)
- Compatibility with HTML, ASPX forms, MVC views, graphics, and multiple document formats already part of your projects
- Effortless setup within Microsoft Visual Studio
- Free development along with commercial licenses starting from `$liteLicense`

---

## Additional .NET PDF Learning Resources

Explore more resources that might catch your interest:

- [Complete VB.NET and C# API reference in MSDN style](https://ironpdf.com/object-reference/api/IronPdf.html)

- [Detailed guide on converting ASPX to PDF using VB.NET and C#](https://ironpdf.com/how-to/aspx-to-pdf/)

- [Comprehensive tutorial on converting HTML to PDF for VB.NET and C# projects](https://ironpdf.com/tutorials/html-to-pdf/)

---
```

## Conclusion

Throughout this guide, we explored six different methodologies for converting various content into PDF using VB.NET:

- Converting an HTML string directly into a PDF document.
- Formulating a PDF using an HTML string that articulates its contents.
- Transforming web URLs into PDF files.
- Creating PDF documents from HTML sources.
- Employing HTML templates in VB.NET and rendering them into dynamic PDFs.
- Translating live ASP.NET pages, like ASPX, into PDF documents.

For all these techniques, we leveraged the versatile [IronPDF VB.NET library](https://ironpdf.com/use-case/vb-dot-net-library/) which facilitates the direct conversion of HTML to PDF within .NET frameworks.

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
      <a class="btn btn-white3" href="downloads/VB.Net.Pdf.Tutorial.zip">
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

