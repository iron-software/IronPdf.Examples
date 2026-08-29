# VB.NET PDF Creation (Code Example Tutorial)

> Full guide: [VB.NET PDF Creation (Code Example Tutorial)](https://ironpdf.com/get-started/vb-net-pdf/?utm_source=github)

This comprehensive tutorial will walk you through the creation and modification of PDF files using VB.NET. This approach is applicable to various environments including **ASP.NET web applications**, **console applications**, **Windows Services**, and **desktop software**. You’ll be guided in developing PDF projects using VB.NET aimed at .NET Framework 4.6.2 or .NET Core 2. Prepare your Visual Basic .NET development setup, preferably Microsoft Visual Studio Community, to get started.

For guidance on using IronPDF with **C#**, visit [this resource](https://ironpdf.com/docs/?utm_source=github).

For tutorials on employing IronPDF with **F#**, explore [this manual](https://ironpdf.com/get-started/fsharp-pdf-library-html-to-pdf/?utm_source=github).

---

## Introduction

### Steps to Produce PDF Files Using VB.NET Library

1. [Acquire the VB.NET PDF Library](https://nuget.org/packages/IronPdf/)
2. Initiate a PDF document using VB.NET Library
3. Implement style customizations in your PDF
4. Decide on methods to inject dynamic content
5. Manage your PDF documents through the VB.NET Library

## VB.NET Examples for Generating and Modifying PDFs with IronPDF

Convert HTML to PDF from VB.NET, style it with CSS, fill it from dynamic data, and edit the result. It runs on .NET Framework 4.6.2, .NET Core 3.1 and every version through .NET 8, and it works in HTML rather than a proprietary document format.

This tutorial includes detailed documentation to guide you meticulously through each part of the process using the [developer-favored IronPDF software](https://ironpdf.com?utm_source=github), free for development purposes. You'll find VB.NET code examples tailored to specific use cases enhancing your familiarity with the environment. This VB.NET PDF library offers extensive capabilities for every scenario, whether in ASP.NET, console, or desktop scenarios.

### Advantages of Using IronPDF:
- Direct ticket support from our .NET PDF Library specialists
- Compatibility with various document types including HTML, ASPX forms, MVC views, and images
- Fast setup through Microsoft Visual Studio
- Complimentary development and affordable production license options starting at `$liteLicense`

---

## Step 1

### 1. Free Download of VB .NET PDF Library from IronPDF

#### Installation via NuGet

Right-click on your project within Visual Studio’s Solution Explorer and choose "Manage NuGet Packages...". Search for `IronPdf` and proceed to install the most recent edition. Acknowledge any prompts that appear.

This is compatible with any C# .NET Framework from version 4.6.2 upwards, as well as .NET Core 2 and greater. It is perfectly suitable for VB.NET projects as well.

```shell
Install-Package IronPdf
```

[Get IronPDF from NuGet](https://www.nuget.org/packages/IronPdf)

#### Manual Installation via DLL

Optionally, download and implement the IronPDF DLL manually into your project or the Global Assembly Cache (GAC) from [IronPDF Downloads](https://ironpdf.com/packages/IronPdf.zip?utm_source=github).

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

For styling your PDF content, VB.NET allows comprehensive use of CSS, JavaScript, and images. You can link to local resources, utilize remote or CDN-hosted assets like Google Fonts, or even [embed images and other resources directly into your HTML using DataURIs](https://ironpdf.com/how-to/datauris/?utm_source=github).

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

' RenderThisPageAsPdf writes the ASP.NET page it is called from, so this
' only does anything inside a Web Forms request.
Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
    Dim PdfOptions = New IronPdf.ChromePdfRenderOptions()
    IronPdf.AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", PdfOptions)
End Sub
```

#### 4.2. Technique 2: HTML to PDF Conversion Using String Templating

Generate customized PDF documents by creating an HTML string tailored to your content.

```vbnet
Imports IronPdf

Dim renderer = New ChromePdfRenderer()
Dim Html = "Hello {0}"
Html = String.Format(Html, "World")
Dim document = renderer.RenderHtmlAsPdf(Html)
document.SaveAs("HtmlTemplate.pdf")
Process.Start(New ProcessStartInfo("HtmlTemplate.pdf") With {.UseShellExecute = True})
```

## 5. Editing PDF Files with VB.NET

IronPDF can also edit, encrypt, watermark, or extract the text back out of a
document it has produced.

#### 5.1. Merging Several PDF Files into One

```vbnet
Imports IronPdf

Dim pdfs = New List(Of PdfDocument)
pdfs.Add(PdfDocument.FromFile("A.pdf"))
pdfs.Add(PdfDocument.FromFile("B.pdf"))
pdfs.Add(PdfDocument.FromFile("C.pdf"))
Dim mergedPdf As PdfDocument = PdfDocument.Merge(pdfs)
mergedPdf.SaveAs("merged.pdf")
mergedPdf.Dispose()
For Each pdf As PdfDocument In pdfs
    pdf.Dispose()
Next
```

#### 5.2. Adding a Cover Page

```vbnet
Imports IronPdf

' The page has a renderer and a pdf open by this point.
Dim renderer = New ChromePdfRenderer()
Dim pdf = renderer.RenderHtmlAsPdf("<p>Body</p>")

pdf.PrependPdf(renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"))
```

#### 5.3. Removing the Last Page

```vbnet
Imports IronPdf

' The page has a pdf open by this point.
Dim pdf = PdfDocument.FromFile("report.pdf")

pdf.RemovePage(pdf.PageCount - 1)
```

#### 5.4. Encrypting a PDF

```vbnet
Imports IronPdf

' The page has a pdf open by this point.
Dim pdf = PdfDocument.FromFile("report.pdf")

' Save with a strong encryption password.
pdf.Password = "my.secure.password"
pdf.SaveAs("secured.pdf")
```

#### 5.5. Stamping HTML Content Onto a Page

```vbnet
Imports IronPdf

Dim renderer = New ChromePdfRenderer()
Dim pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf")
Dim stamp = New Editing.HtmlStamper()
stamp.Html = "<h2>Completed</h2>"
stamp.Opacity = 50
stamp.Rotation = -45
stamp.VerticalAlignment = Editing.VerticalAlignment.Top
stamp.VerticalOffset = New Editing.Length(10)
pdf.ApplyStamp(stamp)
pdf.SaveAs("Stamped.pdf")
```

> The guide stamps with `HtmlStamp`. `ApplyStamp` takes a `Stamper`, and
> the HTML one is `IronPdf.Editing.HtmlStamper`.

#### 5.6. Adding a Page Break

The simplest way is with HTML and CSS:

```html
<div style='page-break-after: always;'>&nbsp;</div>
```

## 6. Further Reading

- The [VB.NET and C# API reference](https://ironpdf.com/object-reference/api/?utm_source=github)
- [Converting ASPX to PDF](https://ironpdf.com/how-to/aspx-to-pdf/?utm_source=github)
- [Rendering HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/?utm_source=github)

## Conclusion

This tutorial covered six routes from VB.NET to a PDF:

- An HTML string rendered directly to a PDF
- A PDF whose content is defined by an HTML string built in code
- An existing URL rendered as a PDF
- An HTML file rendered as a PDF
- HTML templating in VB.NET, rendered to a PDF per set of values
- An ASP.NET page with live data, converted from ASPX to PDF

Each one goes through IronPDF, which turns HTML into a PDF document from inside
a .NET project.
