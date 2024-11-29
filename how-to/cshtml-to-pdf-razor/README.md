# Transforming Razor Pages to PDFs in ASP.NET Core Web App

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor/>***


Razor Pages, identified by the `.cshtml` extension, combine C# and HTML to deliver web content efficiently. They simplify the coding structure in ASP.NET Core, particularly for straightforward, read-centric, or minimal data entry web pages.

ASP.NET Core supports the creation of robust, cross-platform web applications.

Using IronPDF, the conversion of Razor Pages to PDFs within an ASP.NET Core Web App is straightforward, streamlining the document generation process.

## IronPDF Extension Package

The **IronPdf.Extensions.Razor** is an extension package that complements the principal **IronPdf** library. To facilitate the rendering of Razor Pages into PDFs within an ASP.NET Core Web App, both **IronPdf.Extensions.Razor** and **IronPdf** are necessary.

```shell
Install-Package IronPdf.Extensions.Razor
```

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

## PDF Conversion of Razor Pages

Start by establishing an ASP.NET Core Web App project to enable the conversion of Razor pages to PDF documents.

### Create a Model Class

- Start by creating a new folder in your project titled "Models."
- Inside this folder, introduce a standard C# class named "Person," which will be used to structure individual data records. Here’s the code snippet:

```cs
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

### Add a Razor Page

- Integrate a new, empty Razor Page into the "Pages" folder and name it "persons.cshtml."

- Alter the newly added "Persons.cshtml" file using the following code snippet, which is aimed at displaying data in the browser:

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
            <td>@person.Title</td
            <td>@person.Description</td>
        </tr>
    }
</table>

<form method="post">
    <button type="submit">Print</button>
</form>
```

In the implementation steps above, the **ChromePdfRenderer** class is instantiated. Calling the `RenderRazorToPdf` method with `this` as the argument translates the Razor Page to a PDF format.

Full capabilities of **RenderingOptions** are available, allowing the application of [page numbers](https://ironpdf.com/how-to/page-numbers/), setting custom margins, and implementing custom [text or HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/).

- Expand the "Persons.cshtml" file dropdown to access the "Persons.cshtml.cs" file.
- Update the "Persons.cshtml.cs" file with the following script which includes viewing the PDF in the browser, though downloading it may result in a corrupted file:

```cs
using IronPdf.Razor.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageSample.Models;

namespace RazorPageSample.Pages
{
    public class PersonsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<Person> persons { get; set; }

        public void OnGet()
        {
            persons = new List<Person>
            {
                new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
                new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
                new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            };

            ViewData["personList"] = persons;
        }
        public IActionResult OnPostAsync()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();

            // Render Razor Page to PDF document
            PdfDocument pdf = renderer.RenderRazorToPdf(this);

            Response.Headers.Add("Content-Disposition", "inline");

            // Output PDF in browser
            return File(pdf.BinaryData, "application/pdf", "razorPageToPdf.pdf");

            // Output PDF is directly visualized in the browser
            return File(pdf.BinaryData, "application/pdf");
        }
    }
}
```

The `RenderRazorToPdf` method generates a **PdfDocument** object that can be further adapted or edited. Available modifications include exporting as [PDFA](https://ironpdf.com/how-to/pdfa/) or [PDFUA](https://ironpdf.com/how-to/pdfua/), applying a [digital signature](https://ironpdf.com/how-to/signing/), or managing PDF documents by [merging or splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/). Additional operations such as rotating pages, adding [annotations](https://ironpdf.com/how-to/annotations/) or [bookmarks](https://ironpdf.com/how-to/bookmarks/), and [stamping custom watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf) are also possible.

### Modify the Navigation Bar

- Navigate to the Pages folder, then the Shared folder, and adjust the `_Layout.cshtml`. Add a navigation item titled "Person" following "Home". Ensure the `asp-page` attribute corresponds with the actual file name, as shown below:

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
                    </li
                </ul>
            </div>
        </div>
    </nav>
</header>
```

#### Execution of the Project

This demonstrates how to execute the project and generate a PDF document.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/razorPageProjectRun.gif" alt="Execute ASP.NET Core Web App Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## ASP.NET Core Web App Project Download

The complete code for this guide is available as a zipped file which you can download and run as an ASP.NET Core Web App project in Visual Studio.

[Download the RazorPageSample.zip ASP.NET Core Web App Project](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/RazorPageSample.zip)