# Transforming Razor Views into PDFs Without a User Interface

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor-headlessly/>***


Headless rendering allows the conversion of web content into other formats without the need for a graphical user interface (GUI) or browser window. Although the [IronPdf.Extensions.Razor](https://www.nuget.org/packages/IronPdf.Extensions.Razor/) package is valuable, it lacks support for headless rendering. To fill this gap, we can use headless rendering techniques suited for other scenarios not covered by the IronPdf.Extensions.Razor package.

We will employ the [Razor.Templating.Core](https://www.nuget.org/packages/Razor.Templating.Core) package to convert cshtml (Razor Views) files into HTML and then use IronPDF to create PDF files from the HTML content.

*as-heading:2(Quickstart: Rapid Razor to PDF Conversion)*

Effortlessly convert Razor Views into PDFs using IronPDF's headless conversion technique. Implement the `IronPdf.HtmlToPdf.StaticRender.RenderHtmlAsPdf` method for fast and easy HTML to PDF conversion, leveraging the efficiency and power of IronPDF within your ASP.NET Core projects.

```cs
:title=Convert Razor views to PDF without a GUI!
var htmlContent = await RazorTemplateEngine.RenderAsync("Views/Template.cshtml", model); 
var pdfDocument = new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf(htmlContent).SaveAs("output.pdf");
```

Start by installing the **Razor.Templating.Core package** to transition Razor Views into HTML within your ASP.NET Core Web Application.

```shell
# Install the Razor.Templating.Core package via NuGet Package Manager

***Based on <https://ironpdf.com/how-to/cshtml-to-pdf-razor-headlessly/>***

Install-Package Razor.Templating.Core
```

## Converting Razor Views to PDF

You'll require an ASP.NET Core Web Application using the Model-View-Controller architecture to convert views into PDF format.

## Adding a View

- Right-click the "Home" folder, select "add" followed by "Add View."
- Generate a new Razor View and name it "Data.cshtml".

![Add view](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/add-view.webp)

### Modify Data.cshtml File

Incorporate the HTML code that will be converted to PDF:

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
        <td>Expert in web applications.</td>
    </tr>
    <tr>
        <td>Alice Smith</td>
        <td>Project Manager</td>
        <td>Expertise in agile project management.</td>
    </tr>
    <tr>
        <td>Michael Johnson</td>
        <td>Data Analyst</td>
        <td>Proficient in data interpretation and visualization.</td>
    </tr>
</table>
```

## Update Program.cs File

Modify "Program.cs" to include code that utilizes the `RenderAsync` method from the `Razor.Templating.Core` library to convert Razor Views to HTML. Then, instantiate the `ChromePdfRenderer` to convert the HTML to a PDF document.

```csharp
app.MapGet("/PrintPdf", async () =>
{
    // Your IronPDF license key
    IronPdf.License.LicenseKey = "IRONPDF-YOUR_LICENSE_KEY";
    
    // Enable comprehensive logging
    IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

    // HTML conversion from Razor view
    string htmlContent = await RazorTemplateEngine.RenderAsync("Views/Home/Data.cshtml");

    // Chrome PDF Renderer initialization
    ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
   
    // HTML to PDF conversion
    PdfDocument generatedPdf = pdfRenderer.RenderHtmlAsPdf(htmlContent, "./wwwroot");

    // Send the PDF as a response
    return Results.File(generatedPdf.BinaryData, "application/pdf", "convertedRazorView.pdf");
});
```

## Update Asset Links

In the "_Layout.cshtml" within the "Views/Shared" directory, modify the link paths by replacing "~/" with "./".

This adjustment is essential for compatibility with IronPDF.

## Execute the Project

Learn how to execute the project and generate a PDF document from a Razor View.

<img src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/viewToPdfMVCCoreProjectRun.gif" alt="Run ASP.NET Core MVC Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

#### Resulting PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/razorViewToPdf.pdf" width="100%" height="400px">
</iframe>

## Download the ASP.NET Core MVC Project

Download the full example code for this guide. It is provided in a zip file, which can be opened in Visual Studio to start an ASP.NET Core MVC project.

[Click here to download the project.](https://ironpdf.com/static-assets/pdf/how-to/cshtml-to-pdf-razor-headlessly/ViewToPdfMVCCoreHeadlesslySample.zip)