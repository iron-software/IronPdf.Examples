# Converting Views to PDFs in ASP.NET Core MVC

A View in the ASP.NET framework serves as a building block for creating HTML markup in web apps. It forms a crucial part of the Model-View-Controller (MVC) architecture widely used in both ASP.NET MVC and ASP.NET Core MVC applications. The primary role of Views is to deliver data to the end-user by dynamically rendering HTML content.

ASP.NET Core Web App MVC is a framework offered by Microsoft to develop web applications using ASP.NET Core. It consists of three main components:

- **Model**: Handles data and business logic, manages interactions with data sources, and facilitates data exchanges.
- **View**: Manages the presentation layer, focusing on user interface by rendering data visually to the user.
- **Controller**: Manages user inputs, handles requests, communicates with the Model, and manages interactions between the Model and the View.

IronPdf greatly simplifies the task of generating PDF files directly from Views within an ASP.NET Core MVC project, enhancing the efficiency of PDF creation.

## Using IronPDF in ASP.NET Core

To begin using IronPdf to convert Views to PDFs, you first need to include the **IronPdf.Extensions.Mvc.Core** package alongside the main **IronPdf** library in your ASP.NET Core MVC project.

```shell
:InstallCmd Install-Package IronPdf.Extensions.Mvc.Core
```

### NuGet Installation Information

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

## Converting Views into PDFs

First, ensure you have an ASP.NET Core Web App (Model-View-Controller) structure. Here’s how to proceed:

### Define a Model Class

- Navigate to the "Models" folder.
- Create a C# class file named "Person," which will represent individual data entities. Use the following code sample:

```cs
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
### Update the Controller

Go to the "Controllers" folder and modify the "HomeController" by adding a "Persons" action as displayed below:

This operation uses the `RenderRazorViewToPdf` method from **ChromePdfRenderer**, which takes in a view path and a data model, to create a PDF document dynamically. The resultant PDF can have customized settings such as headers, footers, margins, and page numbers.

```cs
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
            var persons = new List<Person>
            {
                new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
                new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
                new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            };

            if (_httpContextAccessor.HttpContext.Request.Method == HttpMethod.Post.Method)
            {
                ChromePdfRenderer renderer = new ChromePdfRenderer();
                PdfDocument.pdf = renderer.RenderRazorViewToPdf(_viewRenderService, "Views/Home/Persons.cshtml", persons);

                Response.Headers.Add("Content-Disposition", "inline");
                return File(pdf.BinaryData, "application/pdf", "viewToPdfMVCCore.pdf");
            }
            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();