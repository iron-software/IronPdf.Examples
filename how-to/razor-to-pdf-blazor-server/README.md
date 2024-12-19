# Transforming Razor Components into PDFs in Blazor Server

***Based on <https://ironpdf.com/how-to/razor-to-pdf-blazor-server/>***


A Razor component, utilized in constructing user interfaces like pages and forms, combines C# with Razor syntax for reusability within Blazor Server apps.

Blazor Server is a framework enabling the creation of dynamic web UIs using C# rather than JavaScript, operating component logic server-side.

Using IronPDF, developers can easily convert these Razor components within a Blazor Server application into PDF documents, streamlining the process of PDF generation in such projects.

## Utilizing IronPDF Extensions in Blazor

The **IronPdf.Extensions.Blazor package** complements the main **IronPdf** library, and both are necessary for converting Razor components into PDF format within a Blazor Server application.

```shell
PM > Install-Package IronPdf.Extensions.Blazor
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
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
                <pre class="install-script">Install-Package IronPdf.Extensions.Blazor</pre>
                <div class="copy-button">
                    <button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
                        <span class="far fa-copy"></span>
                    </button>
                </div>
            </div>
        </div>
        <div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Blazor/</div>
    </div>
</div>


## Generating PDFs from Razor Components

To turn Razor components into PDF documents in a Blazor Server App, you’ll need to start with a project setup.

### Implement a Model Class

Create a basic C# class named **PersonInfo** for storing personal data. Here's the class definition:

```cs
namespace BlazorSample.Data
{
    public class PersonInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
```

### Construct a Razor Component

Integrate the `RenderRazorComponentToPdf` method by initializing the **ChromePdfRenderer** class to transform Razor components into PDF files. This method Outputs a **PdfDocument** which can be modified or exported.

This PdfDocument can be enhanced further, for instance, transformed into [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/) standards, or you can [merge or split](https://ironpdf.com/how-to/merge-or-split-pdfs/) the document, rotate pages, and add [annotations](https://ironpdf.com/how-to/annotations/) or [bookmarks](https://ironpdf.com/how-to/bookmarks/). Incorporate [custom watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf) to your PDFs for added personalization.

Create a Razor component named **Person** and input the following code:
```cs
@page "/Person"
@using BlazorSample.Data;
@using IronPdf;
@using IronPdf.Extensions.Blazor;
<h3>Person</h3>

@code {
    [Parameter]
    public IEnumerable<PersonInfo> persons { get; set; }
    public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

    protected override async Task OnInitializedAsync()
    {
        persons = new List<PersonInfo>
        {
            new PersonInfo { Name = "Alice", Title = "Mrs.", Description = "Software Developer" },
            new PersonInfo { Name = "Bob", Title = "Mr.", Description="Hardware Engineer" },
            new PersonInfo { Name = "Charlie", Title = "Mr.", Description="Network Specialist" }
        };
    }
    private async void PrintToPdf()
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Apply a text footer
        renderer.RenderingOptions.TextFooter = new TextHeaderFooter()
            {
                LeftText = "{date} - {time}",
                DrawDividerLine = true,
                RightText = "Page {page} of {total-pages}",
                Font = IronSoftware.Drawing.FontTypes.Arial,
                FontSize = 11
            };

        Parameters.Add("persons", persons);

        // Convert the Razor component to a PDF
        PdfDocument pdf = renderer.RenderRazorComponentToPdf<Person>(Parameters);

        File.WriteAllBytes("razorComponentToPdf.pdf", pdf.BinaryData);
    }
}

<table class="table">
    <tr>
        <th>Name</th>
        <th>Title</th>
        <th>Description</th>
    </tr>
    @foreach (var person in persons)
    {
        <tr>
            <td>@person.Name</td>
            <td>@person.Title</td>
            <td>@person.Description</td>
        </tr>
    }
</table>

<button class="btn btn-primary" @onclick="PrintToPdf">Print to PDF</button>
```

Harness full control over PDF generation, applying [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), placing [page numbers](https://ironpdf.com/how-to/page-numbers/), and customizing the layout according to your specifications.

### Include a Navigation Section

Add a new section in the "Shared folder" within NavMenu.razor to link to your Razor component, making it accessible as a navigation option.

```html
<div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
    <nav class="flex-column">
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
                <span class="oi oi-home" aria-hidden="true"></span> Home
            </NavLink>
        </div>
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="Person">
                <span class="oi oi-list-rich" aria-hidden="true"></span> Person
            </NavLink>
        </div>
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="counter">
                <span class="oi oi-plus" aria-hidden="true"></span> Counter
            </NavLink>
        </div>
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="fetchdata">
                <span class="oi oi-list-rich" aria-hidden="true"></span> Fetch data
            NavLink>
        </div>
    </nav>
</div>
```

#### Execute the Project

This step will guide you through running the project to generate your desired PDF.

<img src="https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/blazorServerProjectRun.gif" alt="Execute Blazor Server Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## Obtain the Complete Blazor Server App Project

Download the fully prepared code for this guide. It is provided as a zipped file, ready to be opened in Visual Studio as a Blazor Server App project.

[Download the Blazor Sample Project for Razor to PDF Conversion](https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/BlazorSample.zip)