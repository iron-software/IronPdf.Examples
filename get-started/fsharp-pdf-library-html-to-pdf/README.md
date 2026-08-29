# F# PDF Library (Complete Guide)

> Full guide: [F# PDF Library (Complete Guide)](https://ironpdf.com/get-started/fsharp-pdf-library-html-to-pdf/)


This guide will elaborate on the procedures for creating and manipulating PDF documents in F# using the IronPDF library. Ensure you have Visual Studio installed and an F# project set up to follow along.

For instructions on integrating IronPDF with **C#**, refer to [this guide](https://ironpdf.com/docs/).

For integration details with **VB.NET**, check out [this guide](https://ironpdf.com/get-started/vb-net-pdf/).

## Setting Up the F# PDF Library

### Installation via NuGet Package Manager

In Visual Studio, select your project in the solution explorer, right-click, and choose "Manage NuGet Packages...". Search for IronPDF and proceed to install the most recent version, accepting any prompts that appear. This is compatible with any .NET project.

### Installation via NuGet Package Manager Console

Alternatively, you can install IronPDF using the NuGet package manager console with the following command:
```shell
/Install-Package IronPdf
```

### Manual Installation in the .fsproj file

You can also manually insert this `ItemGroup` into your `.fsproj` file:
```xml
<ItemGroup>
  <PackageReference Include="IronPdf" Version="*" />
</ItemGroup>
```

### Installation via DLL

You can download the IronPDF DLL and manually add it to your project or the Global Assembly Cache (GAC) from [here](https://ironpdf.com/packages/IronPdf.zip).

Add the following import statement at the beginning of your **.fs** class files to utilize IronPDF:
```fsharp
open IronPdf
```

## Generating a PDF from HTML with F#

Start by importing the IronPDF library with `open`. Then, instantiate a `ChromePdfRenderer` and use the `RenderHtmlAsPdf` method to generate a PDF from an HTML string. To convert an HTML file, use the `RenderHtmlFileAsPdf` method by passing the file path as a string.

### Convert HTML String to PDF in F#

```fsharp
open IronPdf

let html = "<p>Hello World</p>"

// Create a new instance of the PDF Renderer
let renderer = ChromePdfRenderer()

// Convert HTML string into a PDF
let pdf = html |> renderer.RenderHtmlAsPdf

// Save the newly created PDF file
pdf.SaveAs("document.pdf") |> ignore
```

### Convert HTML File to PDF in F#

```fsharp
open IronPdf

let htmlFilePath = "C:/designs/html/layout.html"

// Create a new instance of the PDF Renderer
let renderer = ChromePdfRenderer()

// Convert HTML file into a PDF
let pdf = htmlFilePath |> renderer.RenderHtmlFileAsPdf

// Save the resulting PDF file
pdf.SaveAs("document.pdf") |> ignore
```

### Advanced Usage of IronPDF in F#

Here is a detailed example showcasing how to create a PDF from a URL with custom formatting and styling using IronPDF:

```fsharp
open IronPdf

let CreateCompanyStandardDocument (url : string) =
    
    // Define the render options with specific settings
    let renderOptions = ChromePdfRenderOptions(
        CssMediaType = Rendering.PdfCssMediaType.Screen,
        EnableJavaScript = true,
        PrintHtmlBackgrounds = true,
        InputEncoding = System.Text.Encoding.UTF8,
        MarginTop = 0.39,
        MarginBottom = 0.38,
        MarginLeft = 0.39,
        MarginRight = 0.38
    )
    
    // Set up a header template with company branding
    let companyStyleHeader = HtmlHeaderFooter()
    companyStyleHeader.HtmlFragment <- "<img src='https://ironsoftware.com/img/svgs/ironsoftware-logo-black.svg'>"
    companyStyleHeader.DrawDividerLine <- true
    
    // Attach the header to the render options
    renderOptions.HtmlHeader <- companyStyleHeader
    
    // Initialize the renderer with the custom options
    let renderer = ChromePdfRenderer(RenderingOptions = renderOptions)
    
    // Generate a PDF from the URL without added styling
    let htmlPdfWithoutStyle = url |> renderer.renderUrlAsPdf
    
    // Enhance the PDF with the styled header
    htmlPdfWithoutStyle.AddHtmlHeaders companyStyleHeader |> ignore
    
    // Return the final PDF
    htmlPdfWithoutStyle
   
let IronPdfUrlToPdf (url : string) =
    // Generate a formatted PDF from the URL
    let pdf = url |> CreateCompanyStandardDocument
    
    // Store the PDF on your local file system
    pdf.SaveAs("document.pdf") |> ignore

// Apply your IronPDF License Key
IronPdf.License.LicenseKey <- "YOUR_LICENSE_KEY_HERE"

// Demonstrate converting a URL to a PDF
IronPdfUrlToPdf "https://ironpdf.com/"
```