# Converting Razor Views to PDFs Headlessly

The concept of 'headless rendering' refers to drawing web content without a visible user interface, such as a GUI or browser window. Although helpful, the [`IronPdf.Extensions.Razor`](https://www.nuget.org/packages/IronPdf.Extensions.Razor/) lacks capabilities for headless rendering. This gap is filled by using headless rendering for cases that the IronPdf.Extensions.Razor package doesn't cover.

To perform the conversion from cshtml (Razor Views) to html, we will employ the [`Razor.Templating.Core`](https://www.nuget.org/packages/Razor.Templating.Core) package, and then use IronPDF to produce the final PDFs.

This guide is inspired by a YouTube video, which can be viewed here:

<iframe width="560" height="315" src="https://www.youtube.com/embed/XYdcdVWsWos?si=H8T0pLh6oglm_KvW" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

### Installation of Razor.Templating.Core Package

To begin, install the **Razor.Templating.Core package** in your ASP.NET Core Web Application to convert Razor Views into HTML documents.

```shell
:InstallCmd Install-Package Razor.Templating.Core
```


## Convert Razor Views to PDFs

First, ensure you have an ASP.NET Core Web App set up with a Model-View-Controller architecture to transform Views into PDF documents.

## Adding a View

- Navigate to the "Home" folder in your project, right-click, select "add" then "Add View."
- Create an empty Razor View named "Data.cshtml".

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/add-view.webp)

### Editing the Data.cshtml File

Include the HTML content that you wish to convert to PDF:

```html
<table class="table">
    <tr>
        <th>Name</th>
        <th>Title</th>
        <th>Description</th>
    </tr>
    <tr>
        <td>John Doe</td>
        <td>Software Engineer</td>
        <td>Experienced software engineer with expertise in web development.</td>
    </tr>
    <tr>
        <td>Alice Smith</td>
        <td>Project Manager</td>
        <td>Experienced project manager specializing in Agile methodologies.</td>
    </tr>
    <tr>
        <td>Michael Johnson</td>
        <td>Data Analyst</td>
        <td>Data analyst adept in statistical analysis and creating visual representations of complex data.</td>
    </tr>
</table>
```

## Updating the Program.cs File

Edit "Program.cs" by incorporating the following snippet. This code first uses the `RenderAsync` method of Razor.Templating.Core to convert a Razor View into HTML. Then it creates an instance of **ChromePdfRenderer** and sends the HTML string to the `RenderHtmlAsPdf` method for PDF creation. Utilize **RenderingOptions** for customizing PDFs by adding HTML headers, footers through [`text, headers, and footers`](https://ironpdf.com/how-to/headers-and-footers/) or setting custom margins and adding [`page numbers`](https://ironpdf.com/how-to/page-numbers/).

```cs
app.MapGet("/PrintPdf", async () =>
{
    IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

    string html = await RazorTemplateEngine.RenderAsync("Views/Home/Data.cshtml");

    ChromePdfRenderer renderer = new ChromePdfRenderer();
    PdfDocument pdf = renderer.RenderHtmlAsPdf(html, "./wwwroot");

    return Results.File(pdf.BinaryData, "application/pdf", "razorViewToPdf.pdf");
});
```

## Adjusting Asset Links

In the "_Layout.cshtml" located within "Views/Shared", change any "~/" in link tags to "./".

This step ensures compatibility with IronPDF.

## Running the Project

Executing the project will be your next step, allowing the generation of a PDF document.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/viewToPdfMVCCoreProjectRun.gif" alt="Execute ASP.NET Core MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

### Viewing the Generated PDF

Preview the generated PDF here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/razorViewToPdf.pdf" width="100%" height="400px">
</iframe> 

## Download the Complete ASP.NET Core MVC Project

The entire project is available for download as a zipped file, which you can open and run as an ASP.NET Core Web App (MVC) in Visual Studio.

[Download the project here.](https://ironpdf.com/static-assets/pdf/how-to/ccshtml-to-pdf-razor-headlessly/ViewToPdfMVCCoreHeadlesslySample.zip)