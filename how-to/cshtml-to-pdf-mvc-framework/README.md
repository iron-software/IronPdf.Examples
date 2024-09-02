# Converting ASP.NET MVC Views to PDF Documents

In the ASP.NET framework, a View is integral to generating HTML markup dynamically in web applications. It's part of the Model-View-Controller (MVC) architecture widely adopted in both ASP.NET MVC and ASP.NET Core MVC projects. Essentially, Views function to display data to users by dynamically rendering HTML content.

***

***

The ASP.NET Web Application (.NET Framework) MVC offers a well-structured web application framework by Microsoft. It employs the Model-View-Controller (MVC) pattern, which helps organize and simplify web application development processes:

- **Model**: Manages data, business logic, and maintains data integrity.
- **View**: Handles the presentation of the user interface and rendering of data.
- **Controller**: Manages user input, processes requests, and facilitates interaction between the Model and View.

IronPDF provides a straightforward approach to PDF creation from Views in an ASP.NET MVC project, simplifying the PDF generation process.

## IronPDF Extension Package

To enable PDF rendering from Views, install the **IronPdf.Extensions.Mvc.Framework package** along with the base **IronPdf** package in your ASP.NET MVC project:

```shell
PM > Install-Package IronPdf.Extensions.Mvc.Framework
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

## Rendering PDFs from Views

Start by setting up an ASP.NET Web Application (.NET Framework) MVC project.

## Add a Model Class

- Access the "Models" folder.
- Create a new C# file named "Person.cs" to represent individual data:

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

Go to the "Controllers" folder and open the "HomeController.cs". Add a "Persons" action using the following guide:

The **ChromePdfRenderer** class is instantiated, and the `RenderView` method requires an HttpContext, a path to the "Persons.cshtml" View, and a list with the required data. When rendering, you can tweak the **RenderingOptions** for margins, page numbers("https://IRONPDF.com/how-to/page-numbers/"), and headers/footers("https://IRONPDF.com/how-to/headers-and-footers/").

The rendered PDF can be sent for download using: <code>File(pdf.BinaryData, "application/pdf", "viewToPdfMVC.pdf")</code>.

```cs
using IronPdf;
using System.Collections.Generic;
using System.Web.Mvc;
using ViewToPdfMVCSample.Models;

namespace ViewToPdfMVCSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person
        public ActionResult Persons()
        {
            var persons = new List<Person>
            {
            new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
            new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
            new Person { Name = "Charlie", Title "Mr.", Description: "Software Engineer" }
            };

            if (HttpContext.Request.HttpMethod == "POST")
            {
                var viewPath = "~/Views/Home/Persons.cshtml";

                ChromePdfRenderer renderer = new ChromePdfRenderer();

                PdfDocument pdf = renderer.RenderView(this.HttpContext, viewPath, persons);

                Response.Headers.Add("Content-Disposition", "inline");

                return File(pdf.BinaryData, "application/pdf");
            }
            return View(persons);
        }
    }
}
```

Enhance created PDFs by converting them to different standards like [PDFA]("https://IRONPDF.com/how-to/pdfa/") or adding [digital signatures]("https://IRONPDF.com/how-to/signing/"), annotations, and [bookmarks]("https://IRONPDF.com/how-to/bookmarks/").

## Include a View

- Right-click on "Persons" action and select "Add View":

![Right-click on Persons action](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/right-click-on-Persons.webp)

- Select "MVC 5 View" when scaffolding:

![Select scaffold](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/select-scaffold.webp)

- Opt for a "List" template and assign it to "Person":

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/add-view.webp)

The resulting file, "Persons.cshtml", can connect to a "Persons" action through the following button code:

```html
@using (Html.BeginForm("Persons", "Home", FormMethod.Post))
{
    <input type="submit" value="Print Person" />
}
```

## Enhance the Top Navigation Bar

- In "Views -> Shared -> _Layout.cshtml", add a "Person" item after "Home":

```html
<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
        <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between"><ul class="navbar-nav flex-grow-1">
                <li>@Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" })</li>
                <li>@Html.ActionLink("Persons", "Persons", "Home", new { area = "" }, new { @class "nav-link" })</li>
                <li>@Html.ActionLink("About", "About", "Home", new { area = "" }, new { @class: "nav-link" })</li>
                <li>@Html.ActionLink("Contact", "Contact", "Home", new { area "" }, new { @class "nav-link" })</li>
            </ul>
        </div>
    </div>
</nav>
```

#### Launching the Project

This setup demonstrates how to execute the project to generate a PDF.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/viewToPdfMVCProjectRun.gif" alt="Execute ASP.NET MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## Download Complete ASP.NET MVC Project

For comprehensive code and project structure, download the zipped file available for Visual Studio:

[Download the project here.](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/ViewToPdfMVCSample.zip)