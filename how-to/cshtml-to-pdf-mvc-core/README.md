# Converting Views to PDFs in ASP.NET Core MVC

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/>***


A View in ASP.NET is a critical component used to generate HTML markup within web applications, forming an integral part of the Model-View-Controller (MVC) architecture. In both ASP.NET MVC and ASP.NET Core MVC, Views are tasked with presenting data through dynamically rendered HTML.

## Quickstart: Converting CSHTML to PDF with Ease in ASP.NET Core

Easily convert your ASP.NET Core MVC Views into PDF documents using IronPDF. By deploying a simple line of code, you can convert your '.cshtml' files into professional-quality PDFs. This integration into your MVC applications streamlines the PDF creation process from dynamic HTML Views. Here's how to get started:

```cs
:title=Convert a Razor view to PDF instantly!
// using IronPdf.Extensions.Mvc.Core
new IronPdf.ChromePdfRenderer().RenderRazorViewToPdf(HttpContext, "Views/Home/Report.cshtml", model).SaveAs("report.pdf");
```

ASP.NET Core Web App MVC stands as Microsoft's framework for crafting web applications using ASP.NET Core. It breaks down into three primary components:

- **Model**: Manages data and business logic, handles data interactions, and interfaces with data sources.
- **View**: Handles the user interface, focussing on data display.
- **Controller**: Manages user input, coordinates with the Model, and orchestrates the data display through the View.

Utilizing IronPDF, you can seamlessly generate PDF files from Views in your ASP.NET Core MVC projects, simplifying the PDF creation process.

## Utilizing the IronPDF Extension Package

The `IronPdf.Extensions.Mvc.Core` package extends the capabilities of the primary `IronPdf` library, necessary for converting Views into PDFs in an ASP.NET Core MVC context.

```shell
:InstallCmd Install-Package IronPdf.Extensions.Mvc.Core
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
<div class="products-download-section">
    <div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
        <div class="product-image">
            <img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
        </div>
        <div class="product-info">
            <h3>Install via <span>NuGet</span></h3>
        </div>
        <div class="js-open-modal-ignore copy-nuget-section" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Click to copy">
            <div class="copy-nuget-row">
            <pre class="install-script">Install-Package IronPdf.Extensions.Mvc.Core</pre>
            <div class="copy-button">
                <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
                <span class="far fa-copy"></span>
                </button>
            </div>
        </div>
    </div>
    <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Mvc.Core/</div>
    </div>
</div>

## Transforming Views into PDF Documents

To begin converting Views into PDFs, you'll need an ASP.NET Core Web App MVC project.

## Creating a Model Class

- Head over to the "Models" folder.
- Create a new C# class file called "Person", representing the data model with the following code structure:

```csharp
namespace ViewToPdfMVCCoreSample.Models
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

## Modifying the Controller

Navigate to the "Controllers" folder and access the "HomeController". Make adjustments specifically to this controller and incorporate the "Persons" action as shown below:

Example changes to `HomeController`, utilizing `ChromePdfRenderer` for PDF rendering, alongside showcasing advanced features like adding HTML headers/footers, custom text, margins, and more:

```csharp
using IronPdf.Extensions.Mvc.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewToPdfMVCCoreSample.Models;

namespace ViewToPdfMVCCoreSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRazorViewRenderer _viewRenderService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        public HomeController(ILogger<HomeController> logger, IRazorViewRenderer viewRenderService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _viewRenderService = viewRenderService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Persons()
        {
            // Sample data
            var persons = new List<Person>
            {
                new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
                new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
                new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            };

            // Handle HTTP POST request
            if (_httpContextAccessor.HttpContext.Request.Method == HttpMethod.Post.Method)
            {
                ChromePdfRenderer renderer = new ChromePdfRenderer();

                // Convert Razor View to PDF
                PdfDocument pdf = renderer.RenderRazorViewToPdf(_viewRenderService, "Views/Home/Persons.cshtml", persons);

                Response.Headers.Add("Content-Disposition", "inline");

                // Output the PDF document
                return File(pdf.BinaryData, "application/pdf", "viewToPdfMVCCore.pdf");
            }

            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
```

Post `RenderRazorViewToPdf` use, a `PdfDocument` with opportunities for alterations like format conversions, signature adding, or document splitting/enhancing is available.

## Adding a View

- Right-click on the "Persons" action and opt to "Add View."

![Right-click on Persons action](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-core/right-click-on-Persons.webp)

- Choose "Razor View" from the scaffold options.

![Choose scaffold](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-core/select-scaffold.webp)

- Opt for the "List" template and utilize the "Person" model class.

![Selecting the template](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-core/add-view.webp)

This procedure will generate the "Persons.cshtml" file inside the "Views/Home" directory.

- For initiating the "Persons" function, include the subsequent HTML code:

```html
@using (Html.BeginForm("Persons", "Home", FormMethod.Post))
{
    <input type="submit" value="Print Person" />
}
```