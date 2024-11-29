# Transforming Views to PDFs in ASP.NET Core MVC

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/>***


A "View" is an essential component of the ASP.NET framework, tasked with producing HTML markup in web applications. As part of the Model-View-Controller (MVC) architecture, it plays a critical role in ASP.NET MVC and ASP.NET Core MVC applications by dynamically rendering HTML to display data.

ASP.NET Core Web App MVC (Model-View-Controller), a solution provided by Microsoft, enables developers to build web applications with ASP.NET Core. The framework consists of three core components:

 - **Model:** Manages data and business logic, interacts with data sources, and communicates data.
 - **View:** Handles the presentation of the user interface, concentrates on data display, and provides information rendering.
 - **Controller:** Processes user input, manages responses to requests, and facilitates interactions between the View and the Model.

IronPDF streamlines the generation of PDFs from Views within an ASP.NET Core MVC project, offering a straightforward approach to creating PDF files.

## IronPDF Extensions for MVC

The **IronPdf.Extensions.Mvc.Core** package enhances the capabilities of the primary **IronPdf** library. Both the IronPdf and IronPdf.Extensions.Mvc.Core packages are necessary for converting Views into PDF documents in ASP.NET Core MVC environments.

```shell
Install-Package IronPdf.Extensions.Mvc.Core
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

## Convert Views to PDFs

Begin by setting up an ASP.NET Core Web App (Model-View-Controller) project to transform Views into PDF files.

### Add a Model Class

- Go to the "Models" directory
- Create a new C# class file named "Person" to serve as a data model. Use the code below as a template:

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

Navigate to the "Controllers" folder and open the "HomeController" file. Adjustments will be made specifically to the HomeController, adding the "Persons" action. Refer to the following code for details:

This code initializes the **ChromePdfRenderer** class, passes an IRazorViewRenderer, specifies the path to "Persons.cshtml," and provides the List containing necessary data to the `RenderRazorViewToPdf` method. Utilize **RenderingOptions** to explore various features such as adding custom [text, including HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/) in the produced PDF, customizing margins, and incorporating [page numbers](https://ironpdf.com/how-to/page-numbers/).

View the PDF document directly in the browser using <code>File(pdf.BinaryData, "application/pdf")</code>, though downloading it after viewing may result in a corrupted file.

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

                // Render View to PDF
                PdfDocument pdf = renderer.RenderRazorViewToPdf(_viewRenderService, "Views/Home/Persons.cshtml", persons);

                Response.Headers.Add("Content-Disposition", "inline");

                // Output the PDF
                return File(pdf.BinaryData, "application/pdf", "viewToPdfMVCCore.pdf");
            }
            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();