# Converting Razor Views to PDFs without a GUI

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor-headlessly/>***


In the realm of web content production, 'headless rendering' denotes the act of generating website content without using a graphical user interface (GUI) or opening a browser. Although [IronPdf.Extensions.Razor](https://www.nuget.org/packages/IronPdf.Extensions.Razor/) is incredibly helpful, it lacks the feature to render content headlessly. This is where headless rendering comes in, filling the capability void left by the IronPdf.Extensions.Razor package.

To handle this, we'll employ the [Razor.Templating.Core](https://www.nuget.org/packages/Razor.Templating.Core) package to transform cshtml, or Razor Views, into HTML. Subsequently, we will use IronPDF to create PDF files from this HTML.

The guidance in this write-up is complimented by an instructional YouTube video.

First, install the **Razor.Templating.Core package** in your ASP.NET Core Web App to convert Razor Views into HTML documents.

```shell
Install-Package Razor.Templating.Core
```

## Creating PDFs from Razor Views

To start, ensure your project is set up as an ASP.NET Core Web App with a Model-View-Controller architecture.

## Adding a New View

- Navigate to the "Home" folder, right-click, select "add" followed by "Add View".
- Create a new Razor View and label it "Data.cshtml".

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/add-view.webp)

### Modifying the Data.cshtml File

Below is the HTML content for conversion to PDF:

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
        <td>Specializes in web solutions.</td>
    </tr>
    <tr>
        <td>Alice Smith</td>
        <td>Project Manager</td>
        <td>Expert in leading projects with agile practices.</td>
    </tr>
    <tr>
        <td>Michael Johnson</td>
        <td>Data Analyst</td>
        <td>Expert in statistical methods and data interpretation.</td>
    </tr>
</table>
```

## Update the Program.cs File

Add the code snippet below to your "Program.cs" file. This example demonstrates the use of the `RenderAsync` method from the Razor.Templating.Core library for HTML conversion. It then employs the **ChromePdfRenderer** class to transform the HTML into a PDF, using the `RenderHtmlAsPdf` method. Adjust the rendering settings using **RenderingOptions** to include advanced features such as customizable [headers and footers](https://ironpdf.com/how-to/headers-and-footers/), defined margins, and [page numbers](https://ironpdf.com/how-to/page-numbers/).

```cs
app.MapGet("/PrintPdf", async () =>
{
    IronPdf.License.LicenseKey = "Replace with your license key";
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

    string html = await RazorTemplateEngine.RenderAsync("Views/Home/Data.cshtml");

    ChromePdfRenderer renderer = new ChromePdfRenderer();
    PdfDocument pdf = renderer.RenderHtmlAsPdf(html, "./wwwroot");

    return Results.File(pdf.BinaryData, "application/pdf", "razorViewToPdf.pdf");
});
```

## Modify Asset Path Syntax

In the "Views/Shared/_Layout.cshtml" file, replace "~/" with "./". This syntax change ensures compatibility with IronPDF's handling of assets.

## Execute the Project

Follow these steps to run your project and generate a PDF file.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/viewToPdfMVCCoreProjectRun.gif" alt="Execute ASP.NET Core MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

#### View the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/razorViewToPdf.pdf" width="100%" height="400px">
</iframe> 

## Download the Full ASP.NET Core MVC Project

Download the fully functional project code, packaged as a ZIP file, ready for use in Visual Studio as an ASP.NET Core MVC application.

[Download the ASP.NET Core MVC Project Code](https://ironpdf.com/static-assets/pdf/how-to/ccshtml-to-pdf-razor-headlessly/ViewToPdfMVCCoreHeadlesslySample.zip)