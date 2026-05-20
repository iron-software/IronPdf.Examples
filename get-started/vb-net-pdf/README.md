# VB.NET PDF Creation (Code Example Tutorial)

***Based on <https://ironpdf.com/get-started/vb-net-pdf/>***


This comprehensive tutorial will walk you through the creation and modification of PDF files using VB.NET. This approach is applicable to various environments including **ASP.NET web applications**, **console applications**, **Windows Services**, and **desktop software**. You’ll be guided in developing PDF projects using VB.NET aimed at .NET Framework 4.6.2 or .NET Core 2. Prepare your Visual Basic .NET development setup, preferably Microsoft Visual Studio Community, to get started.

For guidance on using IronPDF with **C#**, visit [this resource](https://ironpdf.com/docs/).

For tutorials on employing IronPDF with **F#**, explore [this manual](https://ironpdf.com/get-started/fsharp-pdf-library-html-to-pdf/).

---

## Introduction

### Steps to Produce PDF Files Using VB.NET Library

1. [Acquire the VB.NET PDF Library](https://nuget.org/packages/IronPdf/)
2. Initiate a PDF document using VB.NET Library
3. Implement style customizations in your PDF
4. Decide on methods to inject dynamic content
5. Manage your PDF documents through the VB.NET Library

## VB.NET Examples for Generating and Modifying PDFs with IronPDF

Easily convert HTML to PDF in VB.NET, apply CSS, leverage dynamic data, and edit your documents seamlessly. The creation process is straightforward and compatible with multiple .NET environments such as .NET Framework 4.6.2 through .NET Core 3.1 up to .NET 8. Avoid the hassle of proprietary formats and cumbersome APIs.

This tutorial includes detailed documentation to guide you meticulously through each part of the process using the [developer-favored IronPDF software](https://ironpdf.com), free for development purposes. You'll find VB.NET code examples tailored to specific use cases enhancing your familiarity with the environment. This VB.NET PDF library offers extensive capabilities for every scenario, whether in ASP.NET, console, or desktop scenarios.

### Advantages of Using IronPDF:
- Direct ticket support from our .NET PDF Library specialists
- Compatibility with various document types including HTML, ASPX forms, MVC views, and images
- Fast setup through Microsoft Visual Studio
- Complimentary development and affordable production license options starting at `$liteLicense`

---

## Step 1

### 1. Free Download of VB .NET PDF Library from IronPDF

!!!--LIBRARY_START_TRIAL_BLOCK--!!!
#### Installation via NuGet

Right-click on your project within Visual Studio’s Solution Explorer and choose "Manage NuGet Packages...". Search for `IronPdf` and proceed to install the most recent edition. Acknowledge any prompts that appear.

This is compatible with any C# .NET Framework from version 4.6.2 upwards, as well as .NET Core 2 and greater. It is perfectly suitable for VB.NET projects as well.

```shell
Install-Package IronPdf
```

[Get IronPDF from NuGet](https://www.nuget.org/packages/IronPdf)

#### Manual Installation via DLL

Optionally, download and implement the IronPDF DLL manually into your project or the Global Assembly Cache (GAC) from [IronPDF Downloads](https://ironpdf.com/packages/IronPdf.zip).

Include this at the beginning of any **VB** class file that utilizes IronPDF:

```vbnet
Imports IronPdf
```

---

## Tutorials on Usage

### 2. Generating a PDF Using VB.NET

Creating your first PDF document in **Visual Basic ASP.NET** is straightforward with IronPDF. Unlike other libraries that rely on proprietary APIs like ***iTextSharp***, IronPDF utilizes a high-fidelity rendering engine based on Google Chromium to convert HTML content straight to PDF.

Here’s how to quickly create a PDF in VB.NET:

```vbnet
Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
        document.SaveAs("MyFirst.pdf")
    Sub End
End Module
```

This basic code snippet will generate a PDF document containing precisely your specified content.

To enhance this code, include this line to open the PDF using the system's default viewer:

```vbnet
Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer()
        Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
        document.SaveAs("MyFirst.pdf")
        System.Diagnostics.Process.Start("MyFirst.pdf")
    Sub End
End Module
```

Alternatively, convert any existing webpage into a PDF using the powerful `RenderUrlAsPdf` method offered by IronPDF.

```vbnet
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

---

### 3. Styling Your VB.NET PDF

For styling your PDF content, VB.NET allows comprehensive use of CSS, JavaScript, and images. You can link to local resources, utilize remote or CDN-hosted assets like Google Fonts, or even [embed images and other resources directly into your HTML using DataURIs](https://ironpdf.com/how-to/datauris/).

For high-quality design, consider a two-step approach:

1. Initially, craft and perfect your HTML layout. This might involve design teams and dividing tasks.
2. Convert your HTML to a PDF using VB.NET and IronPDF.

#### VB.NET Code to Convert an HTML Document to PDF:

This method simulates opening an HTML document as a regular file using the ***file:// protocol***.

```vbnet
Dim Renderer As New IronPdf.ChromePdfRenderer()
Renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Landscape 
Renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print 
Dim PDF As IronPdf.PdfDocument = Renderer.RenderUrlAsPdf("file://path-to-your-html-file.html")
PDF.SaveAs("styled-sample.pdf")
```

---

### 4. Creating PDFs with Dynamic Content: Two Techniques

Historically, PDF templating has posed a significant challenge. However, HTML excels in managing Dynamically Generated Data, making it an ideal choice for creating specialized documents.

#### 4.1. Technique 1: PDF Generation in ASP.NET Using VB.NET Web Forms

Within any .NET Web Form environment, including Razor, generate a PDF document using the following VB.NET code in your Page_Load subroutine.

```vbnet
Imports IronPdf

Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
    Dim pdfOptions = New IronPdf.ChromePdfRenderOptions()
    IronPdf.AspxToPdf.RenderThisPageAsPDF(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", pdfOptions)
Sub End
```

#### 4.2. Technique 2: HTML to PDF Conversion Using String Templating

Generate customized PDF documents by creating an HTML string tailored to your content.

```vbnet
Imports IronPdf

Module Module1
    Sub Main()
        Dim renderer = New ChromePdfRenderer(ctx)