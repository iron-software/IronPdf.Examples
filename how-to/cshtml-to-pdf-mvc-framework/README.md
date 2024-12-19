# Converting Views to PDFs in ASP.NET MVC

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-framework/>***


In the ASP.NET framework, a View is a crucial component for generating HTML markup within web applications, operating as part of the Model-View-Controller (MVC) architecture. This architecture is widely utilized in both ASP.NET MVC and ASP.NET Core MVC projects, with the View primarily tasked with dynamically rendering HTML content, thus facilitating data presentation to the user.

* * *

ASP.NET Web Application (.NET Framework) MVC offers a robust web application framework developed by Microsoft that utilizes a structured MVC architectural pattern. This pattern assists in organizing and simplifying the development process:

- **Model**: Manages data, business logic, and ensures data integrity.
- **View**: Handles user interface presentation and data rendering.
- **Controller**: Manages user input, processes requests, and coordinates interactions between the Model and View.

IronPDF greatly streamlines the conversion of Views into PDF files within ASP.NET MVC projects, making it straightforward and efficient to generate PDFs directly from MVC.

## Using IronPDF Extension Package

**IronPdf.Extensions.Mvc.Framework** is an enhancement package extending the capabilities of the basic **IronPdf** package. To perform conversions from Views to PDFs in an ASP.NET MVC environment, both packages are essential. Install the package using the Package Manager Console:

```shell
PM > Install-Package IronPdf.Extensions.Mvc.Framework
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
            <pre class="install-script">Install-Package IronPdf.Extensions.Mvc.Framework</pre>
            <div class="copy-button">
                <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
                <span class="far fa-copy"></span>
                </button>
            </div>
        </div>
    </div>
    <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Mvc.Framework/</div>
    </div>
</div>

## Converting Views into PDFs

Start by setting up an ASP.NET Web Application (.NET Framework) MVC project.

## Define a Model Class

- In the "Models" directory, create a new C# class file named "Person," which will act as a model for individual data entries. Here’s a sample code:

```cs
namespace ViewToPdfMVCSample.Models
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

## Update the Controller

Proceed to the "Controllers" folder and edit the "HomeController" file to include the "Persons" action as follows:

**ChromePdfRenderer** enables the conversion of Views to PDF using the `RenderView` method that requires an `HttpContext`, specifies a path to the "Persons.cshtml" file, and utilizes a List to hold necessary data. During rendering, various `RenderingOptions` can be applied to customize margins, add [custom text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), and include [page numbers](https://ironpdf.com/how-to/page-numbers/) in the resulting PDF.

Initiate the PDF download with the command: `File(pdf.BinaryData, "application/pdf", "viewToPdfMVC.pdf")`.

```cs
using IronPdf;
using System.Collections.Generic;
using System.Web.Mvc;
using ViewToPdfMVCSample.MODELS;

namespace ViewToPdfMVCSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Person
        public ActionResult Persons()
        {
            var persons = new List<Person>
            {
                new Person { Id = 1, Name = "Alice", Title = "Mrs.", Description = "Senior Engineer" },
                new Person { Id = 2, Name = "Bob", Title = "Mr.", Description = "Project Manager" },
                new Person { Id = 3, Name = "Charlie", Title = "Mr.", Description = "Developer" }
            };

            if (HttpContext.Request.HttpMethod == "POST")
            {
                var viewPath = "~/Views/Home/Persons.cshtml";
                ChromePdfRenderer renderer = new ChromePdfRenderer();
                PdfDocument pdf = renderer.RenderView(this.HttpContext, viewPath, persons);

                // Inline viewing of the PDF
                Response.Headers.Add("Content-Disposition", "inline");
                return File(pdf.BinaryData, "application/pdf");
            }
            return View(persons);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn more about this application.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch through our contact page.";
            return View();
        }
    }
}
```

Further enhancements and custom modifications to the **PdfDocument** object obtained through `RenderView` include converting the PDF to [PDFA](https://ironpdf.com/how-to/pdfa/) or [PDFUA](https://ironpdf.com/how-to/pdfua/) standards, applying [digital signatures](https://ironpdf.com/how-to/signing/), and performing [PDF merging or splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/). Additional features include page rotation, inserting [annotations](https://ironpdf.com/how-to/annotations/) or [bookmarks](https://ironpdf.com/how-to/bookmarks/), and applying unique [watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf).

## Incorporating a View

1. Right-click on the "Persons" action and choose "Add View."

   ![Right-click on Persons action](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/right-click-on-Persons.webp)

2. Select "MVC 5 View" and choose the "List" template with "Person" model class. 

   ![Select scaffold-option](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/select-scaffold.webp)

3. Add a button in your "Persons.cshtml" to activate the "Persons" action:

```html
@using (Html.BeginForm("Persons", "Home", FormMethod.Post))
{
    <input type="submit" value="Print Person" />
}
```

## Update Top Navigation Bar

- In "_Layout.cshtml" located within the "Views/Shared" directory, add a "Person" link following the "Home" link:

```html
<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
        <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
            <ul class="navbar-nav flex-grow-1">
                <li>@Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                <li>@Html.ActionLink("Persons", "Persons", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                <li>@Html.ActionLink("About", "About", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                <li>@Html.ActionLink("Contact", "Contact", "Home", new { area = "" }, new { @class "nav-link" })</li>
            </ul>
        </div>
    </div>
</nav>
```

#### Project Execution

This comprehensive tutorial guides you through running the ASP.NET MVC project to generate a PDF.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/viewToPdfMVCProjectRun.gif" alt="Running an ASP.NET MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## Downloading the ASP.NET MVC Project

For a complete walkthrough, download the zipped ASP.NET Web Application (.NET Framework) MVC project code.

[Download the complete MVC sample project](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/ViewToPdfMVCSample.zip)