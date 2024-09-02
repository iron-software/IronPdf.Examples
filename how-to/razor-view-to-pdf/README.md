# IronPDF Razor Extension Overview
IronPDF serves as a robust PDF library tailor-made for both .NET and .NET Core platforms. Although it principally operates as a free-to-use library for development purposes, a license is required for its commercial use. This straightforward licensing arrangement spares developers from having to navigate the complexities typically associated with GNU/AGPL licenses, enabling them to concentrate on their development work.

With IronPDF, developers working with .NET and .NET Core can seamlessly create, manipulate, and manage PDFs using C#, F#, and VB.NET. This includes generating PDFs from HTML, ASPX, CSS, JS, and image files. The library leverages HTML for PDF generation and editing, using existing HTML and HTML5 assets to handle most layout and design tasks.

## Features of IronPDF for .NET & .NET Core Applications
IronPDF introduces a slew of impressive features:
- Ability to [generate PDFs](https://ironpdf.com/blog/using-ironpdf/csharp-generate-pdf-tutorial/) from HTML, images, and ASPX files.
- Capability to read and extract text and images from PDFs.
- Functions to merge, split, and manipulate PDF documents.

## Advantages of Using IronPDF
- Straightforward installation process.
- Simple licensing, ensuring ease of use in commercial applications.
- Superior performance and functionality compared to many other PDF libraries available for .NET and .NET Core.

**IronPDF is the ideal solution for your PDF needs.**

---

## How to Install IronPDF

Installing the IronPDF library is an effortless process, achievable via the following methods:

1. Through the NuGet package manager by executing:

```shell
/Install-Package IronPdf
```

2. Alternatively, using Visual Studio's NuGet package manager by navigating through **Project** → **Manage NuGet Packages**, and searching for `IronPDF`. The package installation can be visualized as shown here:

<div class="content-img-align-center">
	<div class="center-image-wrapper">
		<a rel="nofollow" href="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" target="_blank">
            <img src="https://ironpdf.com/img/faq/render-razor-pdf/render-razor-figure-1.png" alt="Figure 1 - IronPDF NuGet Package" class="img-responsive add-shadow">
        </a>
	</div>
</div>
**Figure 1** - *IronPDF NuGet Package*

This initiates installation of the PDF extension for your project.

Using IronPDF, it's possible to effortlessly return PDF files via ASP.NET MVC. Below are some illustrative coding examples:

### Returning a Generated PDF from HTML or MVC View
```cs
public FileResult Generate_PDF_FromHTML_Or_MVC(long id) {
  
  using var pdfRenderer = Renderer.RenderHtmlAsPdf("<h1>IronPDF and MVC Example</h1>");
  var pdfLength = pdfRenderer.BinaryData.Length;
  
  Response.AppendHeader("Content-Length", pdfLength.ToString());
  Response.AppendHeader("Content-Disposition", "inline; filename=PDFDocument_" + id + ".pdf");

  return File(pdfRenderer.BinaryData, "application/pdf;");
}
```

### Serving an Existing PDF
```cs
Response.Clear();
Response.ContentType = "application/pdf";
Response.AddHeader("Content-Disposition", "attachment; filename=\"FileName.pdf\"");
Response.BinaryWrite(System.IO.File.ReadAllBytes("PdfName.pdf"));
Response.Flush();
Response.End();
```

---

Let's walk through a typical example in ASP.NET using MVC and .NET Core. Start by launching Visual Studio and creating a new ASP.NET Core web application.

## Step-by-Step Guide

### 1. Creating a New ASP.NET Core Web Project

![Create New ASP.NET Core Project](https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/create-asp.net-core-project.gif "Create New ASP.NET Core Project")

### 2. Setting Up the MVC Model

- Create a new folder named "Models".
![Add Folder](https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/add-folder.webp "Add Folder")
- Right-click on the Models folder and add a new class.
![Add Class](https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/add-class.webp "Add Class")
- Name the class `ExampleModel` and populate it with properties:

```cs
namespace WebApplication4.Models
{
    public class ExampleModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
```

### 3. Adding the MVC Controller

- Create a new folder named "Controllers".
- Right-click on the Controllers folder and add a new "MVC controller - empty".
![Add Controller Class](https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/add-controller-class.webp "Add Controller Class")
- Implement an action method using the previously defined model:

```cs
namespace WebApplication4.Models
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult ExampleView(ExampleModel model)
        {
            var html = this.RenderViewAsync("_Example", model);
            using var pdfDoc = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf(html.Result);
            return File(pdfDoc.Stream.ToArray(), "application/pdf");
        }
    }
}
```

### 4. Modifying the Index.cshtml

Customize the `Index.cshtml` to include form elements associated with the property/vnd.api

### 5. Adding a Razor Page

Create and configure a new Razor page in the Shared folder to interact with the controller.

### 6. Implementing a PDF Controller

Develop a class to handle the view rendering and interaction with `HomeController` for PDF creation.

### 7. Configuring Program.cs

Adjust the navigation logic within your application to redirect correctly post-action execution.

### 8. Demonstration of Workflow

Showcase the integration and PDF generation in action, illustrating how the user input leads to dynamic PDF creation.

![Demonstration](https://ironpdf.com/static-assets/pdf/how-to/razor-view-to-pdf/demonstration.gif "Create ASP.NET Core Project")

---

This guide encapsulates a comprehensive walkthrough of setting up a PDF generation pipeline using the IronPDF library in an ASP.NET MVC application scenario, illustrating practical implementations and configurations throughout the setup.