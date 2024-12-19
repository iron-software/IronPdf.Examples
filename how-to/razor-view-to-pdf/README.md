# IronPDF Razor Extension

***Based on <https://ironpdf.com/how-to/razor-view-to-pdf/>***


IronPDF serves as a versatile PDF management library tailored for both .NET and .NET Core developers. While it operates under a commercial model for production environments, it remains free for developmental use. This straightforward licensing arrangement frees developers from the complexities often associated with GNU / AGPL licenses, allowing them to concentrate more fully on their projects.

IronPDF empowers developers using .NET and .NET Core to create, merge, split, modify, and extract content from PDF files using languages like C#, F#, and VB.NET. Additionally, it supports PDF creation from HTML, ASPX, CSS, JS, and image materials.

Utilizing comprehensive PDF manipulation capabilities, IronPDF converts HTML to PDF seamlessly. How does this functionality come to life? It leverages existing HTML and HTML5 assets for document design and layout.

The IronPDF C# Razor-to-PDF sample project is accessible for download at [IronPDF Razor View to PDF download](https://ironpdf.com/downloads/csharp-razor-view-to-pdf.zip).


## Key Features of IronPDF for .NET & .NET Core

IronPDF introduces an array of impressive features for .NET applications:
<ul>
    <li>Generate PDF documents from HTML, images, and ASPX files with the .NET PDF library</li>
    <li>Read PDF text within .NET and .NET Core programs</li>
    <li>Extract images and data from PDF documents</li>
    <li>Merge and split PDF files</li>
    <li>Edit and alter PDF documents</li>
</ul>

## Advantages of IronPDF

<ul>
    <li>Installing IronPDF is straightforward</li>
    <li>The licensing for the IronPDF .NET library is quick and hassle-free</li>
    <li>Performance-wise, IronPDF excels beyond many other .NET and .NET Core PDF libraries</li>
</ul>

**IronPDF is the go-to solution for your PDF needs.**

---

## How to Install IronPDF

Installing IronPDF in your .NET or .NET Core projects is simple. Here are quick ways to do it:

You can use the NuGet package manager with the command line prompt:

```shell
/Install-Package IronPdf
```

Or, configure it directly from Visual Studio by navigating to "Manage NuGet Packages" and searching for IronPDF, as depicted below:

<div class="content-img-align-center">
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" target="_blank">
            <img src="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" alt="Figure 1 - IronPDF NuGet Package" class="img-responsive add-shadow">
        </a>
	</div>
</div>
**Figure 1** - *IronPDF NuGet Package*

Upon successful installation, your project will have PDF functionalities.

With IronPDF, you can now generate PDF files using ASP.NET MVC. Below are a few examples:

To serve a PDF file in MVC, you could use a method like this:

```cs
public FileResult Generate_PDF_FromHTML_Or_MVC(long id) {
  
  using var objPDF = Renderer.RenderHtmlAsPdf("<h1>IronPDF and MVC Example</h1>"); //Create a PDF Document 
  var objLength = objPDF.BinaryData.Length; //return a PDF document from a view
  Response.AppendHeader("Content-Length", objLength.ToString());
  Response.AppendHeader("Content-Disposition", "inline; filename=PDFDocument_" + id + ".pdf");

  return File(objPDF.BinaryData, "application/pdf;");
}
```
In another scenario, to directly serve an existing PDF:

```cs
Response.Clear();
Response.ContentType = "application/pdf";
Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");
Response.BinaryWrite(System.IO.File.ReadAllBytes("PdfName.pdf"));
Response.Flush();
Response.End();
```

---

Let's now dive into creating a sample ASP.NET using MVC and .NET Core in Visual Studio.