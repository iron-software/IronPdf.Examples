# How to Convert Razor to PDF in Blazor Server

Razor components are integral UI elements like pages, dialogs, or forms that are crafted using both C# and Razor syntax, enabling them to be reusable across different UIs.

Blazor Server is a web framework that lets developers create interactive web interfaces using C# rather than JavaScript, with component logic processed server-side.

IronPDF is a powerful tool within the Blazor Server environment, allowing for the easy generation of PDF documents from Razor components, making the process of creating PDFs simple and streamlined.

## IronPDF Extension Package

The **IronPdf.Extensions.Blazor package** augments the capabilities of the primary **IronPdf** library. Both the IronPdf.Extensions.Blazor and IronPdf packages must be included to enable the transformation of Razor components into PDF files within a Blazor Server application.

```shell
PM > Install-Package IronPdf.Extensions.Blazor
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

## Render Razor Components to PDFs

For your Blazor Server App project to convert Razor components into PDF documents, follow these steps:

### Add a Model Class

Create a standard C# class called **PersonInfo** to store personal information. Use the following code sample:

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

### Add a Razor Component

Convert Razor components to PDFs using the `RenderRazorComponentToPdf` method available in the **ChromePdfRenderer** class. This method returns a **PdfDocument** instance, permitting further adjustments or exporting it directly.

These returned documents can be further tailored, including conversion to [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/) standards, merging, splitting, rotating pages, adding [annotations](https://ironpdf.com/how-to/annotations/) or [bookmarks](https://ironpdf.com/how-to/bookmarks/), and stamping [custom watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf).

Define a Razor component named **Person**, implementing the following code:
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
            new PersonInfo { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
            new PersonInfo { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
            new PersonInfo { Name = "Charlie", Title = "Mr.", Description="Software Engineer" }
        };
    }
    private async void PrintToPdf()
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Set text footer options
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
        PdfDocument pdf = renderer.RenderRazorComponentToPDF<Person>(Parameters);

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

<button class="btn btn-primary" @onclick="PrintToPdf">Print to Pdf</button>
```

### Add a Section to the Left Menu

- Access the "Shared folder" and edit NavMenu.razor.
- Introduce a section to launch our Razor component, Person, as a new menu option.

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
            NavLink>
        </div>
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="fetchdata">
                <span class="oi oi-list-rich" aria-hidden="true"></span> Fetch data
            </NavLink>
        </div>
    </nav>
</div>
```

#### Run the Project

This section will guide you through executing the project to generate a PDF document.

<img src="https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/blazorServerProjectRun.gif" alt="Execute Blazor Server Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## Download Blazor Server App Project

The complete code for this guide is available as a downloadable zipped file, ready to be used in Visual Studio as a Blazor Server App project.

[Click here to download the project.](https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/BlazorSample.zip)