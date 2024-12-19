# Converting Razor Pages to PDFs in ASP.NET Core

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor/>***


Razor Pages, identified by the `.cshtml` extension, skillfully blend C# and HTML to produce dynamic web content. In ASP.NET Core, Razor Pages simplify code management, ideally suiting scenarios involving minimal data input or static content display.

ASP.NET Core itself is a robust, cross-platform framework used to create modern web applications. Using IronPDF, developers can efficiently convert Razor Pages into PDFs within ASP.NET Core Web Apps, streamlining document generation.

## IronPDF Extension for ASP.NET Core Web Apps

The `IronPdf.Extensions.Razor` is a valuable extension to the core `IronPdf` library, essential for converting Razor Pages into PDF files within ASP.NET Core Web Apps.

```shell
Install-Package IronPdf.Extensions.Razor
```

![C# NuGet Library for PDF](https://www.ironpdf.com/img/nuget-logo.svg)

For installation, NuGet provides a convenient management package:

```shell
Install-Package IronPdf.Extensions.Razor
```

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
For further details, visit [NuGet's Package Page](https://www.nuget.org/packages/IronPdf.Extensions.Razor/).

## PDF Rendering from Razor Pages

To begin, an ASP.NET Core Web App project is necessary for converting Razor Pages into PDF files.

### Establishing a Data Model

Create a new folder named "Models" within your project and add a class named `Person` to represent individual entries.

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

### Integrating a Razor Page

Add a new Razor Page named "Persons.cshtml" in the "Pages" directory. Here is an example of how to setup the page:

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

To transform this Razor Page into a PDF, use the `ChromePdfRenderer` with the `RenderRazorToPdf` method, enabling customization like adding page numbers, setting margins, and inserting headers and footers.

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
            PdfDocument pdf = renderer.RenderRazorToPdf(this);
            Response.Headers.Add("Content-Disposition", "inline");
            return File(pdf.BinaryData, "application/pdf", "razorPageToPdf.pdf");
        }
    }
}
```

The resulting PDF can be directly viewed in the browser, ensuring a smooth user experience.

### Navigation Integration

In your `_Layout.cshtml`, integrate a navigation link for easy access:

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

#### Running the Project to Generate PDFs

![Run the ASP.NET Core Web App](https://www.ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/razorPageProjectRun.gif)

## Project Files Download

Download the complete source code of the guide as a zipped ASP.NET Core Web App project from the following link:

[Download RazorPageSample.zip ASP.NET Core Web App Project](https://www.ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/RazorPageSample.zip)