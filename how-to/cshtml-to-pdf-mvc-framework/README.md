# Transforming ASP.NET MVC Views into PDF Documents

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-framework/>***


A View in the ASP.NET framework is tasked with generating HTML markup within web applications. Operating within the Model-View-Controller (MVC) architecture, it is extensively utilized in ASP.NET MVC and ASP.NET Core MVC environments for dynamically displaying content to users.

---

---

Microsoft's ASP.NET Web Application (.NET Framework) MVC offers a robust framework following the Model-View-Controller (MVC) architecture, facilitating organized and streamlined web application development:

- **Model**: Manages the application's data, logic, and rules.
- **View**: Handles the presentation layer and renders user interfaces.
- **Controller**: Manages user inputs, request processing, and coordination between the Model and View.

Using IronPDF, converting Views into PDFs within an ASP.NET MVC project is straightforward, enhancing the functionality of ASP.NET MVC applications.

## Integration with IronPDF

Begin by integrating the **IronPdf.Extensions.Mvc.Framework package**—a supplemental package to the main **IronPdf** library specifically designed for this purpose:

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
</div>

## Converting Views to PDFs

### Define a Model Class

Move to the "Models" directory and create a new `Person` class in C# to represent data:

```csharp
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

### Update the Controller

In the "Controllers" folder, update the "HomeController" by adding a "Persons" action as depicted below:

```csharp
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
                new Person { Name = "Charlie", Title = "Mr.", Description="Software Engineer" }
            };

            if (HttpContext.Request.HttpMethod == "POST")
            {
                var viewPath = "~/Views/Home/Persons.cshtml";
                ChromePdfRenderer renderer = new ChromePdfRenderer();
                PdfDocument pdf = renderer.RenderView(this.HttpContext, viewPath, persons, new RenderingOptions());

                Response.Headers.Add("Content-Disposition", "inline");
                return File(pdf.BinaryData, "application/pdf");
            }
            return View(persons);
        }
    }
}
```

After obtaining the **PdfDocument** instance, you can manipulate the PDF by applying annotations, signatures, rotating pages, and splitting or merging PDF files as needed.

### Generate and Modify Views

Add a .cshtml file named "Persons" using the steps below, including a button to activate the "Persons" action:

```html
@using (Html.BeginForm("Persons", "Home", FormMethod.Post))
{
    <input type="submit" value="Print Person" />
}
```

### Enhance the Navigation Bar

```html
// Embed the "Person" link in the navigation bar
<nav>
    // Existing nav elements
    <ul>
        <li>@Html.ActionLink("Home", "Index", "Home")</li>
        <li>@Html.ActionLink("Persons", "Persons", "Home")</li>
        // Additional links
    </ul>
</nav>
```

#### Execute the Project

![Execute ASP.NET MVC Project](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/viewToPdfMVCProjectRun.gif)

## Acquire the Full ASP.NET MVC Project Code

[Download the MVC sample project for PDF conversion](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/ViewToPdfMVCSample.zip) to obtain a complete setup for PDF generation within an ASP.NET MVC application.