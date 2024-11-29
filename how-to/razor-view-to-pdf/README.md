# IronPDF Razor Extension

***Based on <https://ironpdf.com/how-to/razor-view-to-pdf/>***


IronPDF is a robust PDF manipulation library designed for .NET and .NET Core developers. It primarily operates as a commercial C# PDF library, offering free use during development with a licensing requirement for commercial deployment. This straightforward licensing model eliminates the complexity associated with GNU / AGPL licenses, allowing developers to concentrate on their project development.

IronPDF empowers developers using .NET and .NET Core to effortlessly generate, edit, merge, split, and extract content from PDF documents using C#, F#, and VB.NET. It supports creating PDFs from various sources including HTML, ASPX, CSS, JS, and images.

IronPDF's functionality extends to turning HTML into fully formatted PDFs with ease. It takes full advantage of existing HTML and HTML5 assets to style and layout documents.

You can grab the C# Razor-to-PDF example project by visiting the [IronPDF Razor View to PDF download](https://ironpdf.com/downloads/csharp-razor-view-to-pdf.zip).

## IronPDF Features for .NET & .NET Core Applications

IronPDF boasts a variety of impressive features:
<ul>
    <li>Creating PDFs from HTML, images, and ASPX using the .NET PDF library</li>
    <li>Text extraction capabilities for PDF documents</li>
    <li>Data and image extraction from PDF files</li>
    <li>Functionalities to merge and split PDF files</li>
    <li>Advanced manipulation of PDF documents</li>
</ul>

## IronPDF Advantages

<ul>
    <li>Simplified installation process for IronPDF</li>
    <li>Streamlined licensing options</li>
    <li>Superior performance compared to other .NET and .NET Core PDF libraries</li>
</ul>

**IronPDF is the go-to solution for your PDF needs.**

<hr class="separator">

## Installing the IronPDF PDF library

It's straightforward to install the IronPDF library in .NET or .NET Core applications:

Using NuGet package manager, simply type the following command:

```shell
Install-Package IronPdf
```

Alternatively, in Visual Studio, navigate to "Manage NuGet Packages" via the project menu and search for IronPDF, as demonstrated below:

[//]: # 'image wrapper to make margin bigger - still has link'

<div class="content-img-align-center">
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" target="_blank">
            <img src="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" alt="Figure 1 - IronPDF NuGet Package" class="img-responsive add-shadow">
        </a>
	</div>
</div>

**Figure 1** - *IronPDF NuGet Package Installation Illustrated*

This process installs the PDF extension efficiently.

IronPDF can also be integrated with ASP.NET MVC to return a PDF file. Here are some code samples to provide a clearer picture:

Example of a method in your controller:

```cs
public FileResult Generate_PDF_FromHTML_Or_MVC(long id) {
  
  using var objPDF = Renderer.RenderHtmlAsPdf("<h1>IronPDF and MVC Example</h1>"); //Create a PDF Document 
  var objLength = objPDF.BinaryData.Length; // Return PDF document size
  Response.AppendHeader("Content-Length", objLength.ToString());
  Response.AppendHeader("Content-Disposition", "inline; filename=PDFDocument_" + id + ".pdf");

  return File(objPDF.BinaryData, "application/pdf;");
}
```

Here's how you might serve an already existing PDF in ASP.NET:

```cs
Response.Clear();
Response.ContentType = "application/pdf";
Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");
Response.BinaryWrite(System.IO.File.ReadAllBytes("PdfName.pdf"));
Response.Flush();
Response.End();
```

<hr>

Now, let’s proceed with an example in ASP.NET using MVC and .NET Core. Launch Visual Studio and initiate a new ASP.NET Core web application.

## 1. Create a New ASP.NET Core Web Project in Visual Studio

<img src="https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/create-asp.net-core-project.gif" alt="Create ASP.NET Core Project" class="img-responsive add-shadow" style="margin-bottom: 30px;">