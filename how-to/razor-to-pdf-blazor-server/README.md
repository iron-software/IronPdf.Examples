# Convert Razor Components to PDF in Blazor Server Applications

***Based on <https://ironpdf.com/how-to/razor-to-pdf-blazor-server/>***


A Razor component forms the building blocks of user interfaces in a Blazor Server application, using Razor syntax and C#. These components can include pages, dialogues, or forms, and are notably reusable.

Blazor Server, a web framework from Microsoft, enables developers to craft interactive web UIs primarily using C#. Unlike traditional approaches that rely on JavaScript, Blazor handles the component logic server-side.

IronPDF steps into this architecture by allowing developers to produce PDF documents from Razor components within a Blazor Server environment. This functionality simplifies the process of converting web UIs, like forms or reports, into PDF format.

## IronPDF Extensions for Blazor

To enable PDF rendering from Razor components, the **IronPdf.Extensions.Blazor** extension package is essential along with the main **IronPdf** library. By installing both packages, developers can fully integrate PDF generation capabilities into their Blazor Server applications.

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

## Generating PDFs from Razor Components

To convert Razor components into PDFs within a Blazor Server App, follow these steps:

### Model Creation

Create a model class named **PersonInfo** to store individual records. This class might look like:

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

### Develop a Razor Component

To process the conversion of a Razor component into a PDF file, use the `RenderRazorComponentToPdf` method available through the **ChromePdfRenderer** class. This approach returns a **PdfDocument** object that you can either directly export or manipulate further. For instance, the PDF can be enhanced by adding bookmarks, annotations, or even watermarks, and more?

Construct a Razor component called **Person** and implement the PDF rendering functionality as follows:

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
            new PersonInfo { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
        };
    }
    private async void PrintToPdf()
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Apply text footer
        renderer.RenderingOptions.TextFooter = new TextHeaderFooter()
            {
                LeftText = "{date} - {time}",
                DrawDividerLine = true,
                RightText = "Page {page} of {total-pages}",
                Font = IronSoftware.Drawing.FontTypes.Arial,
                FontSize = 11
            };

        Parameters.Add("persons", persons);

        // Render razor component to PDF
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

<button class="btn btn-primary" @onclick="PrintToPdf">Print to Pdf</button>
```

### Modify the Navigation Menu

Expand your navigation menu to include the new **Person** component by editing the `NavMenu.razor`:

```html
<div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
    <nav class="flex-column">
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
                <span class="oi oi-home" aria-hidden="true"></span> Home
            </NavLink>