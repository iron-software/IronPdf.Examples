# Transforming Razor Components into PDFs using Blazor Server

***Based on <https://ironpdf.com/how-to/razor-to-pdf-blazor-server/>***


Razor components are versatile user interface building blocks containing C# and Razor syntax, commonly used for crafting pages, dialogs, or complex forms as reusable UI elements.

Blazor Server is a robust web framework that helps in crafting rich interactive web interfaces with C# instead of JavaScript, hosting the component logic server-side.

IronPDF presents an effective solution for dynamically creating PDFs from Razor components within a Blazor Server environment, simplifying the process of PDF generation.

## Quick Start Guide: Razor-to-PDF Conversion

IronPDF simplifies the conversion of Razor components into PDF files in Blazor Server applications. By using a few lines of code with the `RenderRazorComponentToPdf` method, you can effortlessly transform your UI components into high-quality PDF documents. This guide will help you integrate the conversion process into your project smoothly, ideal for developers looking for a quick and hassle-free implementation. This approach not only supports rapid deployment but also offers customization options to enhance your PDF outputs.

```cs
:title=Quickly transform a Blazor Razor component into a PDF
// Install-Package IronPdf.Extensions.Blazor
var pdfDocument = new IronPdf.ChromePdfRenderer()
    .RenderRazorComponentToPdf<MyComponent>(new Dictionary<string,object> { { "persons", personsList } })
    .SaveAs("output.pdf");
```

## IronPDF Extension Package

To render PDFs from Razor components in Blazor Server, you must install the **IronPdf.Extensions.Blazor** package along with the primary **IronPdf** library.

```sh
:InstallCmd Install-Package IronPdf.Extensions.Blazor
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
    </div>
</div>


## Converting Razor Components to PDF

A Blazor Server App is essential for this conversion.

### Add a Data Model

Create a standard C# class named **PersonInfo** for managing personal data. Use the code below:

```csharp
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

### Integrate Razor Component

By utilizing the `RenderRazorComponentToPdf` from the **ChromePdfRenderer** class, you can convert Razor components to PDFs. The method returns a **PdfDocument** object, permitting further modifications or exports of the PDF.

Such modifications include converting to [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/), merging or splitting [PDF documents](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating pages, and adding [annotations](https://ironpdf.com/how-to/annotations/) or [bookmarks](https://ironpdf.com/how-to/bookmarks/). It is also possible to [add custom watermarks](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#add-a-watermark-to-a-pdf) to your documents.

Create a new Razor component `Person.razor` and populate it with the following code, which includes functioning page elements like a PDF print button:

```razor
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
            new PersonInfo { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" },
        };
    }

    private async void PrintToPdf()
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        renderer.RenderingOptions.TextFooter = new TextHeaderFooter()
        {
            LeftText = "{date} - {time}",
            DrawDividerLine = true,
            RightText = "Page {page} of {total-pages}",
            Font = IronSoftware.Drawing.FontTypes.Arial,
            FontSize = 11
        };

        Parameters.Add("persons", persons);
        PdfDocument pdf = renderer.RenderRazorComponentToPdf<Person>(Parameters);
        File.WriteAllBytes("output.pdf", pdf.BinaryData);
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

### Customize Navigation

Add a navigation link to the "Person" component within the left-side menu by updating `NavMenu.razor`:

```razor
<div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
    <nav class="flex-column">
        <div class="nav-item px-3">
            <NavLink class="nav-link" href="Person">
                <span class="oi oi-list-rich" aria-hidden="true"></span> Person
            </NavLink>
        </div>
    </nav>
</div>
```

### Launch the Project

To visualize the process of creating a PDF in your Blazor Server project, follow the demonstration below:

<img src="https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/blazorServerProjectRun.gif" alt="Execute Blazor Server Project" class="img-responsive add-shadow" style="margin-bottom: 30px;"/>

## Acquire the Complete Blazor Server App

The entire project code is accessible for download, packaged as a ZIP file, ready to be explored in Visual Studio as a Blazor Server App.

[Download the Blazor Sample Project for Razor-to-PDF Conversion](https://ironpdf.com/static-assets/pdf/how-to/razor-to-pdf-blazor-server/BlazorSample.zip)

Explore additional capabilities by visiting our detailed guide on [Converting PDFs](https://ironpdf.com/tutorials/convert-pdf/).