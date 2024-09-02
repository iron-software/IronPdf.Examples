# IronPDF on Blazor Server App (HTML to PDF Tutorial)

With comprehensive support for .NET 6, including **Blazor** projects, IronPDF is a versatile library that can be integrated into Blazor applications to convert HTML to PDF. This tutorial will guide you through setting up IronPDF with a Blazor Server App using Visual Studio.

## Start a New Blazor Server Project

Begin by creating a new Blazor Server App project in Visual Studio:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-1.webp" alt="Blazor Create Project Image" class="img-responsive add-shadow">
    </div>
</div>

## Incorporating IronPDF in Your Blazor Project

Once your project is set up, install the [IronPDF library](https://www.nuget.org/packages/IronPdf) directly within your Blazor project in Visual Studio by adhering to these steps:

1.  Right-click `References` in the Solution Explorer, then select `Manage NuGet Packages`.
2.  In the NuGet package manager, search for `IronPdf`.
3.  Choose the most current version of IronPdf, ensure your project is checked, and proceed with the installation.

Alternatively, you can install it using the following command in the Package Manager Console:
```shell
Install-Package IronPdf
```

## Add a New Razor Component

After integrating IronPDF, create a new Razor Component titled "IronPdfComponent":

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-2.webp" alt="Blazor IronPDF Component Image" class="img-responsive add-shadow">
    </div>
</div>

Next, modify your component's code as shown below:

```html
@page "/IronPdf" @inject IJSRuntime JS
<h3>IronPdfComponent</h3>
<EditForm Model="@_InputMsgModel" id="inputText">
	<div>
		<InputTextArea @bind-Value="@_InputMsgModel.HTML" rows="20" />
	</div>
	<div>
		<button onclick="@SubmitHTML">Render HTML</button>
	</div>
</EditForm>
```

```cs
@code {
	InputHTMLModel _InputMsgModel = new InputHTMLModel();

	private async Task SubmitHTML()
	{
		IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
		var renderer = new IronPdf.ChromePdfRenderer();
		var pdfDoc = renderer.RenderHtmlAsPdf(_InputMsgModel.HTML);
		var filename = "iron.pdf";
		using var streamRef = new DotNetStreamReference(stream: pdfDoc.Stream);
		await JS.InvokeVoidAsync("SubmitHTML", filename, streamRef);
	}

	public class InputHTMLModel
	{
		public string HTML { get; set; } = "Enter your HTML here";
	}
}
```

For enabling PDF download from within your Blazor application, incorporate this JavaScript in your `_layout.cshtml`:

```html
<script>
	window.SubmitHTML = async (fileName, contentStreamReference) => {
		const arrayBuffer = await contentStreamReference.arrayBuffer();
		const blob = new Blob([arrayBuffer]);
		const url = URL.createObjectURL(blob);
		const link = document.createElement("a");
		link.href = url;
		link.download = fileName ?? "";
		link.click();
		link.remove();
		URL.revokeObjectURL(url);
	};
</script>
```

To include a navigational link to the new component, edit the `NavMenu.razor` file in the Shared folder and add:

```html
<div class="nav-item px-3">
	<NavLink class="nav-link" href="IronPdf">
		<span class="oi oi-list-rich" aria-hidden="true"></span> IronPdf
	</NavLink>
</div>
```

After configuring all components, run your application to view the results:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp" alt="Blazor IronPDF Run Page Image" class="img-responsive add-shadow">
    </div>
</div>