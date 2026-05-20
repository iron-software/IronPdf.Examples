# IronPDF in a Blazor Server Environment: HTML to PDF Conversion Guide

***Based on <https://ironpdf.com/how-to/blazor-tutorial/>***


IronPDF is fully compatible with .NET 6 and supports frameworks such as **Blazor**. If you're using Visual Studio, you can easily include IronPDF in your Blazor Server App projects. The following guide illustrates how to use IronPDF to convert HTML into high-quality PDF documents:

## Quickstart: Generate PDFs Smoothly in Blazor Server

Kick off your development with IronPDF in Blazor Server applications. This guide helps you convert HTML content to PDFs effortlessly. Transform Blazor components into polished PDF documents in just a few lines of code. This is especially useful for developers aiming to add PDF capabilities to their Blazor projects with ease.

```cs
:title=Streamline PDF Creation with IronPDF in Blazor
IronPdf.HtmlToPdf.RenderHtmlAsPdf(htmlContent).SaveAs(outputPath);
```

## Steps to Start a New Blazor Server Project

Begin by creating a new project and choosing Blazor Server App as the project type.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-1.webp" alt="Blazor Create Project Image" class="img-responsive add-shadow">
    </div>
</div>

## Integrating IronPDF into Your Blazor Project

Once your project is set up, follow these steps to incorporate the [IronPDF library from NuGet](https://www.nuget.org/packages/IronPdf) within Visual Studio:

1. In the Solution Explorer window in Visual Studio, right-click `References` and select `Manage NuGet Packages`.
2. Choose Browse and search for `IronPdf`.
3. Select the most recent version of the package, mark the checkbox for your project, and click on install.

Alternatively, the .NET CLI can also be used for installation:

```shell
/Install-Package IronPdf
```

## Create a New Razor Component

With IronPDF installed, start by creating a new Razor Component. For this tutorial, we will call it "IronPdfComponent":

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-2.webp" alt="Blazor IronPDF Component Image" class="img-responsive add-shadow">
    </div>
</div>

Next, update your code as shown below:

```html
@page "/IronPdf"
@inject IJSRuntime JS

<h3>IronPdfComponent</h3>

<EditForm Model="@_InputMsgModel" id="inputText">
  <div>
    <InputTextArea @bind-Value="@_InputMsgModel.HTML" rows="20" />
  </div>
  <div>
    <button type="button" @onclick="@ConvertHtmlToPdf">Render HTML</button>
  </div>
</EditForm>
```

```csharp
@code {

    // Data model for user input
    private InputHTMLModel _InputMsgModel = new InputHTMLModel();

    private async Task ConvertHtmlToPdf()
    {
        // Apply your IronPDF license key
        IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";

        // Instantiate a new PDF renderer to convert HTML to PDF
        var renderer = new IronPdf.ChromePdfRenderer();

        // Convert the HTML to a PDF document
        var document = renderer.RenderHtmlAsPdf(_InputMsgModel.HTML);

        var filename = "iron.pdf";

        // Stream reference for the PDF content
        using var streamReference = new DotNetStreamReference(stream: document.Stream);

        // Use JS to download the PDF within the browser
        await JS.InvokeVoidAsync("ConvertHtmlToPdf", filename, streamReference);
    }

    public class InputHTMLModel
    {
        public string HTML { get; set; } = "My new message";
    }
}
```

Include this JavaScript within `_layout.cshtml` to enable the download functionality of PDFs created by IronPDF in your Blazor application:

```js
<script>
    window.ConvertHtmlToPdf = async (filename, streamReference) => {
        const buffer = await streamReference.arrayBuffer();
        const blob = new Blob([buffer]);
        const url = URL.createObjectURL(blob);

        const downloadLink = document.createElement("a");
        downloadLink.href = url;
        downloadLink.download = filename ?? "download.pdf";
        
        downloadLink.click();

        downloadLink.remove();
        URL.revokeObjectURL(url);
    };
</script>
```

Modify the `NavMenu.razor` file in the Shared folder to add a navigation link to the new Razor component. Use the code below:

```html
<div class="nav-item px-3">
    <NavLink class="nav-link" href="IronPdf">
        <span class="oi oi-list-rich" aria-hidden="true"></span> IronPdf
    </NavLink>
</div>
```

After implementing these steps, you can run your solution. Here's what the application will look like:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp" alt="Blazor IronPDF Run Page Image" class="img-responsive add-shadow">
    </div>
</div>