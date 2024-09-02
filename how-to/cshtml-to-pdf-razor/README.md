# Converting Razor Pages to PDFs in ASP.NET Core Web Applications

A Razor Page, identifiable by its `.cshtml` extension, integrates C# and HTML to render web content. In ASP.NET Core, these pages provide a more streamlined structure for coding web apps, perfect for simply displaying or collecting data.

An ASP.NET Core Web App leverages ASP.NET Core, a versatile framework for developing contemporary web applications.

IronPDF offers a streamlined approach to generating PDF files directly from Razor Pages in any ASP.NET Core Web App.

***

***

## IronPDF Razor Extension Package

The **IronPdf.Extensions.Razor** package extends the capabilities of the core **IronPdf** library. Both packages are essential for converting Razor Pages into PDFs within ASP.NET Core Web Apps.

```shell
:InstallCmd Install-Package IronPdf.Extensions.Razor
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

## From Razor Pages to PDFs

Ensure you have an ASP.NET Core Web App ready for transforming Razor pages into PDFs.

### Set Up a Model Class

- Create a new folder named "Models" within your project.
- Within "Models", add a standard C# class named "Person" to model the data:

```cs
namespace RazorPageSample.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
       .public string Description { get; set; }
    }
}
```

### Implement a Razor Page

Add a new Razor Page called "persons.cshtml" to the "Pages" directory and format it as below to display data using a table in a browser:

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
    @foreach (var person in ViewData ["personList"] as List<Person>)
    {
        <tr>
            <td>@person.Name</td>
            <td>@person.Title</td>
            <td>@person.Description</td>
        </tr>
    }
</table>

<form method="post">
    <button type="submit">print</button>
</form>
```

Subsequently, incorporate the following on the code-behind page `Persons.cshtml.cs` to render this Razor Page as a PDF using the **ChromePdfRenderer**:

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
            persons = new List<Person> {
            new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
            new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
            new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            };

            ViewData["personList"] = persons;
        }
        public IActionResult OnPostAsync()
        {
            var renderer = new ChromePdfRenderer();

            // Convert Razor Page to PDF 
            PdfDocument pdf = renderer.RenderRazorToPdf(this);
            
            // Stream PDF in browser
            Response.Headers.Add("Content-Disposition", "inline");
            return File(pdf.BinaryData, "application/pdf", "razorPageToPdf.pdf");
        }
    }
}
```

### Navigation Update

For ease of navigation within the application:

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

#### Running and Testing the App

To execute the project and observe the PDF generation:

![Executables for ASP.NET Core Web Apps](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/razorPageProjectRun.gif)

## Download the Complete ASP.NET Core Web App Project

The complete source code for this tutorial is available for download which can be executed directly in Visual Studio.

[Download the project here.](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor/RazorPageSample.zip)