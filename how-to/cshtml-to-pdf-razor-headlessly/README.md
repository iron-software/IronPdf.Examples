# How to Convert Razor Views to PDFs Without a GUI

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor-headlessly/>***


In the world of web development, 'headless rendering' is a method where web content is processed without a visible graphical user interface (GUI) or browser window. Although the [IronPdf.Extensions.Razor](https://www.nuget.org/packages/IronPdf.Extensions.Razor/) library is quite useful, it lacks the capability to perform headless rendering. This function can fill the gaps that the IronPdf.Extensions.Razor library doesn't cover.

To transform Razor Views (.cshtml) into HTML, we will employ the [Razor.Templating.Core](https://www.nuget.org/packages/Razor.Templating.Core) package and then use IronPDF to convert the HTML into PDFs.

The process detailed in this article is inspired by a YouTube video.

<h3>Initializing IronPDF</h3>

---

### Implement the Razor.Templating.Core Package

Begin by installing the **Razor.Templating.Core package** in your ASP.NET Core Web App to convert Razor Views to HTML documents.

```shell
:InstallCmd Install-Package Razor.Templating.Core
```

## Processing Razor Views to PDF

An ASP.NET Core Web App with a Model-View-Controller architecture is required to convert Views into PDF documents.

## Include a View

- Access the "Home" folder by right-clicking, then select "add" followed by "Add View."
- Craft an empty Razor View and title it "Data.cshtml".

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/add-view.webp)

### Modify the Data.cshtml File

Place the following HTML content into the file to render it to PDF later:

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
        <td>Expert in web development with extensive experience.</td>
    </tr>
    <tr>
        <td>Alice Smith</td>
        <td>Project Manager</td>
        <td>Adept in leading projects with a focus on agile practices.</td>
    </tr>
    <tr>
        <td>Michael Johnson</td>
        <td>Data Analyst</td>
        <td>Proficient in using statistical tools and data interpretation methods.</td>
    </tr>
</table>
```

## Update Program.cs File

Add the following code inside the "Program.cs" file. It employs the `RenderAsync` method from the Razor.Templating.Core library to convert Razor Views to HTML. Following that, it creates an instance of the **ChromePdfRenderer** class and sends the generated HTML to the `RenderHtmlAsPdf` method. Numerous options, such as inserting custom [text, including HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), setting up margins, and implementing [page numbers](https://ironpdf.com/how-to/page-numbers/), are available through **RenderingOptions**.

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

## Adjust Asset Links

In your project, navigate to the "Views" folder, then to the "Shared" folder, and open the "_Layout.cshtml" file. Modify the links by changing "~/" to "./".

This adjustment ensures compatibility with IronPDF.

## Execute the Project

Here's how to run the project and generate a PDF document from it.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/viewToPdfMVCCoreProjectRun.gif" alt="Execute ASP.NET Core MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

#### Display the PDF Output

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/razorViewToPdf.pdf" width="100%" height="400px">
</iframe> 

## Download the ASP.NET Core MVC Project

Access the complete code for this guide, available as a zipped file. You can use it in Visual Studio as an ASP.NET Core Web App (Model-View-Controller) project.

[Download the ASP.NET Core MVC Project Code](https://ironpdf.com/static-assets/pdf/how-to/ccshtml-to-pdf-razor-headlessly/ViewToPdfMVCCoreHeadlesslySample.zip)