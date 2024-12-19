# Transforming Views into PDFs in ASP.NET Core MVC

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/>***


In ASP.NET framework, a View is crucial for generating HTML markup dynamically in web applications, following the pattern set forth by Model-View-Controller (MVC) which is prevalent in both ASP.NET MVC and ASP.NET Core MVC frameworks. These Views are pivotal in displaying data to users by dynamically rendering HTML.

The ASP.NET Core Web App MVC framework from Microsoft is specifically designed for creating robust web applications using the ASP.NET Core technology, incorporating:

- **Model**: Manages and represents data, taking care of interactions and communications with data sources.
- **View**: Primarily focuses on the user interface, rendering and displaying data.
- **Controller**: Responsible for managing user inputs, processing requests, and coordinating data flow between the Model and the View.

Using IronPDF, developers can seamlessly generate PDF documents from Views within an ASP.NET Core MVC project, streamlining the conversion process from web pages to portable document formats.

## Utilizing the IronPDF Extension

The `IronPdf.Extensions.Mvc.Core` package extends the capabilities of the main `IronPdf` library, both of which are essential for converting Views to PDF documents in an ASP.NET Core MVC framework.

```shell
Install-Package IronPdf.Extensions.Mvc.Core
```

![C# NuGet Library for PDF](https://ironpdf.com/img/nuget-logo.svg)

<div class="products-download-section">
    <div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
        <div class="product-info">
            <h3>Install with <span>NuGet</span></h3>
        </div>
        <div class="js-open-modal-ignore copy-nuget-section" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Click to copy">
            <pre class="install-script">Install-Package IronPdf.Extensions.Mvc.Core</pre>
            <div class="copy-button">
                <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
                <span class="far fa-copy"></span>
                </button>
            </div>
        </div>
        <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Mvc.Core/</div>
    </div>
</div>

## Converting Views into PDF Files

First, ensure you have an ASP.NET Core Web App MVC project ready for this operation.

### Integrate a Model Class

- In the "Models" folder, craft a new C# class named `Person`, representing individual data elements:

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

### Modify the Controller

Navigate to the "Controllers" folder and revise the "HomeController" by adding a `Persons` action:

This action uses `ChromePdfRenderer` for converting the "Persons.cshtml" View into a PDF, leveraging a range of rendering options such as custom text, page numbering, margins, and more.

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
                new Person { Name = "Bob", Title = "Mr.",