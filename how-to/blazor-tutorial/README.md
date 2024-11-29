# IronPDF Integration in Blazor Server Apps (HTML to PDF Guide)

***Based on <https://ironpdf.com/how-to/blazor-tutorial/>***


IronPDF is compatible with .NET 6 and supports frameworks like **Blazor**. In this tutorial, we will integrate IronPDF into a Blazor Server App using Visual Studio as demonstrated below.

## Set Up a Blazor Server Project

Begin by creating a new Blazor Server App project.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-1.webp" alt="Blazor Create Project Image" class="img-responsive add-shadow">
    </div>
</div>

## Add IronPDF to Your Blazor Server Project

Once your project is set up, proceed with these steps to integrate the [IronPDF library from NuGet](https://www.nuget.org/packages/IronPdf):

1.  In Visual Studio, open the Solution Explorer, right-click on `References`, and select `Manage NuGet Packages`.
2.  Use the Browse tab, search for `IronPdf`.
3.  Choose the most recent version of IronPdf, select your project’s checkbox, and click install.

Alternatively, you can use the Package Manager Console command:

```shell
Install-Package IronPdf
```

## Create a New Razor Component

After installing IronPDF, create a new Razor Component named "IronPdfComponent":

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-2.webp" alt="Blazor IronPDF Component Image" class="img-responsive add-shadow">
    </div>
</div>

Next, modify the component code as shown:

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
		var pdfDocument = renderer.RenderHtmlAsPdf(_InputMsgModel.HTML);
		var documentName = "iron.pdf";
		using var streamRef = new DotNetStreamReference(stream: pdfDocument.Stream);
		await JS.InvokeVoidAsync("SubmitHTML", documentName, streamRef);
	}

	public class InputHTMLModel
	{
		public string HTML { get; set; } = "My new message";
	}
}
```

## Enable PDF Download in Blazor App

Add this JavaScript in `_layout.cshtml` for allowing PDF downloads in the Blazor App:

```html
<script>
	window.SubmitHTML = async (fileName, contentStreamReference) => {
		const arrayBuffer = await contentStreamReference.arrayBuffer();
		const blob = new Blob([arrayBuffer]);
		const url = URL.createObjectURL(blob);
		const anchor = document.createElement("a");
		anchor.href = url;
		anchor.download = fileName ?? "";
		anchor.click();
		anchor.remove();
		URL.revokeObjectURL(url);
	};
</script>
```

## Update Navigation Menu

Update the `NavMenu.razor` file in the Shared folder to include a navigation link to your new Razor component:

```html
<div class="nav-item px-3">
	<NavLink class="nav-link" href="IronPdf">
		<span class="oi oi-list-rich" aria-hidden="true"></span> IronPdf
	</NavLink>
</div>
```

After implementing these steps, you can run your Blazor server application, and it should display as follows:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp" alt="Blazor IronPDF Run Page Image" class="img-responsive add-shadow">
    </div>
</div>