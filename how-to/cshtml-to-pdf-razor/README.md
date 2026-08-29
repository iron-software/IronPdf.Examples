# Transforming Razor Pages into PDFs within an ASP.NET Core Web Application

> Full guide: [Transforming Razor Pages into PDFs within an ASP.NET Core Web Application](https://ironpdf.com/how-to/cshtml-to-pdf-razor/)


Razor Pages, which bear the `.cshtml` file extension, integrate C# with HTML to dynamically produce web content. In ASP.NET Core, Razor Pages keep web app code compact, which suits pages built around data entry or display.

An ASP.NET Core Web Application is built on ASP.NET Core, Microsoft's framework for modern web applications.

IronPDF converts Razor Pages into PDF documents inside any ASP.NET Core Web App project.

## Quick Guide: Convert Razor Pages to PDF

IronPDF turns Razor Pages into PDF documents inside an ASP.NET Core application. The `RenderRazorToPdf` method converts CSHTML files to PDFs; the steps are below.

```cs
// Ensure you have installed the necessary IronPdf package
var pdf = new IronPdf.ChromePdfRenderer().RenderRazorToPdf("Views/Home/Index.cshtml");
```

## IronPDF Extension Packages

The **IronPdf.Extensions.Razor** package enhances the main **IronPdf** library. Both the IronPdf.Extensions.Razor and IronPdf packages are essential for converting Razor Pages to PDFs in an ASP.NET Core Web App.

```shell
# Installation command for IronPdf.Extensions.Razor package via NuGet Package Manager

Install-Package IronPdf.Extensions.Razor
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
<div class="products-download-section">
    <div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
        <div class="product-image">
            <img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
        </div>
        <div class="product-info">
            <h3>Install with <span>NuGet</span></h3>
        </div>
        <div class="js-open-modal-ignore copy-nuget-section" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Click to copy">
            <div class="copy-nuget-row">
            <pre class="install-script">Install-Package IronPdf.Extensions.Razor</pre>
            <div class="copy-button">
                <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
                <span class="far fa-copy"></span>
                </button>
            </div>
        </div>
    </div>
    <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Razor/</div>
    </div>
</div>

## Converting Razor Pages into PDFs

To begin transforming Razor Pages into PDF files, you need an ASP.NET Core Web App project.

### Establishing a Model Class

- Initiate a new folder within your project titled "Models."
- Insert a standard C# class file named "Person" within this folder, which will act as a data model. Here's an example:

```csharp
namespace RazorPageSample.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
```

### Integrating a Razor Page

Create and incorporate a new Razor Page called "persons.cshtml" in the "Pages" folder.

Modify this freshly added page with the code sample below meant for displaying data:

```html
@page
@using RazorPageSample.Models;
@model RazorPageSample.Pages.PersonsModel
@{
}

<table class="table">
    <tr>
        <th>Name</th>
        <th>Title</th>
        <th>Description</th>
    </tr>
    @foreach (var person in ViewData["personList"] as List<Person>)
    {
        <tr>
            <td>@person.Name</td>
            <td>@person.Title</td>
            <td>@person.Description</td>
        </tr>
    }
</table>

<form method="post">
    <button type="submit">Print</button>
</form>
```

The subsequent code snippet handles the instantiation of the **ChromePdfRenderer** class and uses `RenderRazorToPdf` for document conversion.

The **RenderingOptions** provide multiple customization features, including adding [page numbers](https://ironpdf.com/how-to/page-numbers/), setting special margins, and including custom [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/).



```csharp
using IronPdf.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageSample.Models;

namespace RazorPageSample.Pages
{
    public class PersonsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<Person> Persons { get; set; }
        
        // Fetch data on GET request
        public void OnGet()
        {
            Persons = new List<Person>
            {
                new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
                new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
                new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            };

            ViewData["personList"] = Persons;
        }

        // Convert Razor page to PDF on POST request
        public IActionResult OnPost()
        {
            Persons = new List<Person>
            {
                new Person { Name = "Alice", Title = "Mrs.", Description "Software Engineer" },
                new Person { Name = "Bob", Title = "Mr.", Description "Software Engineer" },
                new Person { Name = "Charlie", Title = "Mr.", Description "Software Engineer" }
            };

            ViewData["personList"] = Persons;

            ChromePdfRenderer renderer = new ChromePdfRenderer();

            // Generate PDF from Razor Page
            PdfDocument pdf = renderer.RenderRazorToPdf(this);

            // Serve the PDF with appropriate headers for inline display
            Response.Headers.Add("Content-Disposition", "inline");
            return File(pdf.BinaryData, "application/pdf", "razorPageToPdf.pdf");

            // To display the PDF in a browser window, uncomment the following line
            // return File(pdf.BinaryData, "application/pdf");
        }
    }
}
```

### Enhancing Top Navigation Bar

Update your top navigation bar to include a link to the "Person" page by altering the _Layout.cshtml file within the Pages -> Shared directory. Ensure the `asp-page` attribute accurately reflects our Razor Page.

```html
<header>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
        <div class="container">
            <a class="navbar-brand" asp-area="" asp-page="/Index">RazorPageSample</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li class="nav-item">
                        <a class="nav-link text-dark" asp-area="" asp-page="/Index">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-dark" asp-area="" asp-page="/Persons">Person</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link text-dark" asp-area="" asp-page="/Privacy">Privacy</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</header>
```

#### Launching the Project

Get ready to preview how your project builds and generates a comprehensive PDF document.

![Execute the ASP.NET Core Web App Project](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/razorPageProjectRun.gif)

## Downloading the Complete ASP.NET Core Web App Project

Ensure you obtain the complete set of source files for this guide by downloading them. This comes as a zip file which can be opened in Visual Studio to view the ASP.NET Core Web App project.

[Download the complete RazorPageSample.zip ASP.NET Core Web App Project](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/RazorPageSample.zip)