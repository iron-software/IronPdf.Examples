# F# PDF Library (Complete Tutorial)

***Based on <https://ironpdf.com/how-to/fsharp-pdf-library-html-to-pdf/>***


This comprehensive guide shows you the process of creating and editing PDF documents in F# with IronPDF. Ensure you have Visual Studio installed and an F# project ready.

To explore IronPDF usage with **C#**, visit [this detailed guide](https://ironpdf.com/docs/).

For guidance on IronPDF with **VB.NET**, refer to [this resource](https://ironpdf.com/how-to/vb-net-pdf/).

## Setting Up the F# PDF Library

### Via NuGet Package Manager

In Visual Studio, go to your project in the Solution Explorer, right-click, and choose "Manage NuGet Packages...". Search for IronPDF, select it, and proceed to install the latest version. Confirm any prompts that appear. This method is compatible with any .NET project.

### Via NuGet Package Manager Console

Alternatively, you can install IronPDF using the package manager console with the following command:
```shell
/Install-Package IronPdf
```

### Directly in the .fsproj File

You can also integrate IronPDF by adding the next `ItemGroup` to your .fsproj file:
```xml
<ItemGroup>
  <PackageReference Include="IronPdf" Version="*" />
</ItemGroup>
```

### Via DLL

Or, download and manually integrate the IronPDF DLL into your project or the Global Assembly Cache (GAC) from [here](https://ironpdf.com/packages/IronPdf.zip).

Include this statement at the beginning of any **.fs** file where you're using IronPDF:
```fsharp
open IronPdf
```

## Generating a PDF from HTML in F#

Start by importing the `IronPdf` namespace with `open`. Then, instantiate a `ChromePdfRenderer` and utilize its `RenderHtmlAsPdf` method with an HTML string, or use the `RenderHtmlFileAsPdf` if you're working with an existing HTML file.

### Convert HTML String to PDF in F#

```fsharp
open IronPdf

let html = "<p>Hello World</p>"
let renderer = ChromePdfRenderer()

let pdfDocument = html |> renderer.RenderHtmlAsPdf
pdfDocument.SaveAs("document.pdf") |> ignore
```

### Convert HTML File to PDF in F#

```fsharp
open IronPdf

let filePath = "C:/designs/html/layout.html"
let renderer = ChromePdfRenderer()

let pdfDocument = filePath |> renderer.RenderHtmlFileAsPdf
pdfDocument.SaveAs("document.pdf") |> ignore
```

### Advanced PDF Generation in F# Using IronPDF

Below is an elaborate example demonstrating how to generate a styled PDF from a URL, using specific settings and templates:

```fsharp
open IronPdf

let CreateCompanyStandardDocument (url : string) =
    
    // Configure Render Options
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
    
    // Define a Header Template
    let companyHeader = HtmlHeaderFooter()
    companyHeader.HtmlFragment <- "<img src='https://ironpdf.com/img/svgs/ironsoftware-logo-black.svg' />"
    companyHeader.DrawDividerLine <- true
    
    // Include the header in Render Options
    renderOptions.HtmlHeader <- companyHeader
    
    // Initialize Renderer with Options
    let renderer = ChromePdfRenderer(RenderingOptions = renderOptions)
    
    // Produce
    let basic_html_pdf = url |> renderer.RenderUrlAsPdf
    
    // Add Headers and finalize PDF
    basic_html_pdf.AddHtmlHeaders(companyHeader) |> ignore
    
    // Done
    basic_html_pdf
   
let CreatePdfFromUrl (url : string) =
    let pdf = url |> CreateCompanyStandardDocument
    pdf.SaveAs("document.pdf") |> ignore

IronPdf.License.LicenseKey <- "YOUR_LICENSE_KEY_HERE"
CreatePdfFromUrl("https://ironpdf.com/")
```