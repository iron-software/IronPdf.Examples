# F# PDF Library: Comprehensive Tutorial

This tutorial provides a step-by-step guide on how to generate and modify PDF files using IronPDF in an F# environment. Ensure you have Visual Studio and an F# project configured.

For integration with **C#**, refer to [this comprehensive guide](https://ironpdf.com/docs/).

For **VB.NET** usage, check out [this resource](https://ironpdf.com/how-to/vb-net-pdf/).

## Setting Up the F# PDF Library

### Installation via NuGet Package Manager

Within Visual Studio, right-click on the project in the solution explorer and choose "Manage NuGet Packages...". Search for `IronPDF`, and proceed to install the latest version, confirming any prompts that appear. This installation method is suitable for any .NET project.

### Installation through NuGet Package Manager Console

For those who prefer the Console, IronPDF can be added using the following command:

```shell
/Install-Package IronPdf
```

### Direct Installation in the .fsproj File

Alternatively, integrate IronPDF directly into your .fsproj file by inserting this `ItemGroup`:

```xml
<ItemGroup>
  <PackageReference Include="IronPdf" Version="*" />
</ItemGroup>
```

### Installation via DLL

If needed, the IronPDF DLL can also be manually downloaded and installed into your project or the Global Assembly Cache (GAC) from [here](https://ironpdf.com/packages/IronPdf.zip).

Include the following line at the beginning of your F# class file when using IronPDF:

```fsharp
open IronPdf
```

## Generating PDFs from HTML in F#

Start by importing the IronPDF namespace with `open`. Then, instantiate a `ChromePdfRenderer` and utilize its methods to convert HTML content to a PDF.

### Converting an HTML String to PDF in F#

```fsharp
open IronPdf

let htmlContent = "<p>Welcome to IronPDF</p>"
let pdfRenderer = ChromePdfRenderer()

let resultingPdf = htmlContent |> pdfRenderer.RenderHtmlAsPdf
resultingPdf.SaveAs("output.pdf") |> ignore
```

### Converting an HTML File to PDF in F#

```fsharp
open IronPdf

let filePath = "C:/path/to/your/html/file.html"
let pdfRenderer = ChromePdfRenderer()

let document = filePath |> pdfRenderer.RenderHtmlFileAsPdf
document.SaveAs("output.pdf") |> ignore
```

### Advanced PDF Generation with IronPDF in F#

Here is a sophisticated example of using a URL to create a PDF with customized styling and setup:

```fsharp
open IronPdf

let GenerateStyledPDF (url : string) =
    
    let options = ChromePdfRenderOptions(
        CssMediaType = Rendering.PdfCssMediaType.Screen,
        EnableJavaScript = true,
        PrintHtmlBackgrounds = true,
        InputEncoding = System.Text.Encoding.UTF8,
        MarginTop = 10.0,
        MarginBottom = 10.0,
        MarginLeft = 10.0,
        MarginRight = 10.0
    )
    
    let header = HtmlHeaderFooter()
    header.HtmlFragment <- "<img src='https://ironpdf.com/img/svgs/ironsoftware-logo-black.svg'"
    header.DrawDividerLine <- true
    
    options.HtmlHeader <- header
    
    let renderer = ChromePdfRenderer(RenderingOptions = options)
    
    let rawPdf = url |> ChromePdfRenderer().RenderUrlAsPdf
    
    rawPdf.AddHtmlHeaders header |> ignore
    
    rawPdf
   
let ConvertUrlToPdf (url : string) =
    let finalPdf = url |> GenerateStyledPDF
    finalPdf.SaveAs("final-output.pdf") |> ignore

IronPdf.License.LicenseKey <- "YOUR_LICENSE_KEY_HERE"
ConvertUrlToPdf "https://ironpdf.com/"
```

This guide covers the essentials of using IronPDF within the F# language to work with PDFs, demonstrating various ways to handle installations and PDF generation.