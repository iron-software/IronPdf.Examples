# Transforming ASP.NET MVC Views into PDF Documents

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-mvc-framework/>***


In the realm of ASP.NET applications, a View is integral for generating dynamic HTML content. It plays a crucial role in the Model-View-Controller (MVC) architecture employed by both ASP.NET MVC and ASP.NET Core MVC frameworks. Essentially, Views are in charge of delivering data through HTML to the browser.

ASP.NET Web Application (.NET Framework) MVC is a Microsoft-provided framework that adheres to the Model-View-Controller architectural pattern. This facilitates a structured approach to developing robust web applications:

- **Model:** Manages all data-related logic.
- **View:** Handles the presentation of user interfaces.
- **Controller:** Manages user inputs, coordinates responses, and mediates the interactions between the Model and the View.

IronPDF offers a streamlined solution to convert Views into PDF files within an ASP.NET MVC application, thus enhancing the functionality of ASP.NET MVC with straightforward and effective PDF generation capabilities.

### Quickstart: Seamless Conversion of ASP.NET MVC Views to PDF

Transform your ASP.NET MVC Views into professional-quality PDFs with ease using IronPDF. A minimal amount of code is enough to bring this capability into your application, accommodating developers at any skill level. Start by incorporating IronPDF into your ASP.NET Core projects to generate PDFs from Views seamlessly.

```cs
:title=Instant PDF Generation with IronPDF
// Install-Package IronPdf.Extensions.Razor
var chromePdf = new IronPdf.ChromePdfRenderer();
var pdf = chromePdf.RenderRazorToPdf(ControllerContext);
```

## IronPDF Extension Package Overview

The **IronPdf.Extensions.Mvc.Framework package** enhances the core functionalities of the **IronPdf** library, enabling the rendering of Views to PDFs in ASP.NET MVC environments. Installation of both these packages is necessary for this functionality.

```shell
:InstallCmd Install-Package IronPdf.Extensions.Mvc.Framework
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
<div class="products-download-section">
    <div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
        <div class="product-image">
            <img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
        </div>
        <div class="product-info">
            <h3>Install using <span>NuGet</span></h3>
        </div>
        <div class="js-open-modal-ignore copy-nuget-section" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Click to copy NuGet command">
            <div class="copy-nuget-row">
            <pre class="install-script">Install-Package IronPdf.Extensions.Mvc.Framework</pre>
            <div class="copy-button">
                <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy NuGet Install Command" title="">
                <span class="far fa-copy"></span>
                </button>
            </div>
        </div>
    </div>
    <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Mvc.Framework/</div>
    </div>
</div>

## Converting Views to PDFs

For transforming Views to PDF documents, start with an ASP.NET Web Application (.NET Framework) MVC project.

### Add a Model Class

- In the "Models" directory, add a C# class file named "Person," which will represent an individual's data as shown:

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

### Modify the Controller

Go to the "Controllers" directory and edit the "HomeController." Below is an extraction of what you should consider:

Within the code, the **ChromePdfRenderer** class is instantiated. For rendering, you require an HttpContext, a pathway to the "Persons.cshtml" file, and a dataset. When rendering the View, the **RenderingOptions** facilitate customization such as adding margins, custom text, HTML headers and footers, and page numbers.

The PDF document can be served directly for download using: <code>File(pdf.BinaryData, "application/pdf", "viewToPdfMVC.pdf")</code>.

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
                new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
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

        ...
    }
}
```

Next, you can enhance your **PdfDocument** by converting it to various formats, signing it digitally, or splitting/merging as necessary. The library also allows for page rotations, annotations, bookmarks, and applying unique watermarks. 

### Add a View

- Right-click on "Persons" action to add a View.

![Right-click on Persons action](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/right-click-on-Persons.webp)

- Opt for "MVC 5 View" as your new item template.

![Select scaffold](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/select-scaffold.webp)

- Choose "List" template and select "Person" as the model.

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/add-view.webp)

This results in the creation of a "Persons.cshtml" file inside "Home" within the "Views" directory. To trigger the "Persons" action, use:

```html
@using (Html.BeginForm("Persons", "Home", FormMethod.Post))
{
    <input type="submit" value="Print Person" />
}
```

### Enhance the Navigation Bar

- In your "Shared" directory under "Views," locate and edit "_Layout.cshtml" to incorporate the "Person" link after "Home," ensuring alignment with our file's naming consistency.

```html
<nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
    <div class="container">
        @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
        ...
        <ul class="navbar-nav flex-grow-1">
            <li>@Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" })</li>
            <li>@Html.ActionLink("Persons", "Persons", "Home", new { area = "" }, new { @class="nav-link" })</li>
            ...
        </ul>
    </div>
</nav>
```

#### Project Execution Insights

Discover how to execute the project and observe the PDF generation in action.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/viewToPdfMVCProjectRun.gif" alt="Executing ASP.NET MVC Project" style="margin-bottom: 30px;"/>

#### Showcasing the Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/Persons.pdf" width="100%" height="400px">
</iframe>

## Download the Complete ASP.NET MVC Project

Acquire the full solution for this guide, provided as a ZIP file, by following the link below. Once downloaded, it is readily openable as an ASP.NET Web Application (.NET Framework) MVC project within Visual Studio.

[Download the complete sample project here](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-mvc-framework/ViewToPdfMVCSample.zip)