# Utilizing IronPDF in a Blazor Server Application (Converting HTML to PDF Guide)

***Based on <https://ironpdf.com/how-to/blazor-tutorial/>***


IronPDF is compatible with .NET 6 and caters to several project types including **Blazor**. To integrate IronPDF within your Blazor Server App project in Visual Studio, follow the steps outlined below:

## Start a New Blazor Server Project

Initiate a new project and select Blazor Server App as the project type.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-1.webp" alt="Blazor Create Project Image" class="img-responsive add-shadow">
    </div>
</div>

## Setting Up IronPDF in Your Blazor Project

Once you've set up your project, continue by integrating the [IronPDF library available on NuGet](https://www.nuget.org/packages/IronPdf):

1. In Visual Studio's Solution Explorer, right-click on `References` and choose `Manage NuGet Packages`.
2. Click on the Browse tab and input `IronPdf`.
3. Choose the latest IronPdf package version, tick the checkbox next to your project, and then press the install button.

Alternatively, you can use the command line:
```shell
/Install-Package IronPdf
```

## Create a New Razor Component

With IronPDF successfully integrated, proceed to add a new Razor Component to your project, named "IronPdfComponent":

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-2.webp" alt="Blazor IronPDF Component Image" class="img-responsive add-shadow">
    </div>
</div>

Next, modify the existing code as shown below:

```html
@page "/IronPdf" @inject IJSRuntime JS
<h3>IronPdfComponent</h3>
<EditForm Model="@_InputMsgModel" id="inputText">
	<div>
		<InputTextArea @bind-Value="@_InputMsgModel.HTML" rows="20"/>
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
		var fileName = "iron.pdf";
		using var streamRef = new DotNetStreamReference(stream: pdfDocument.Stream);
		await JS.InvokeVoidAsync("SubmitHTML", fileName, streamRef);
	}

	public class InputHTMLModel
	{
		public string HTML { get; set; } = "My new message";
	}
}
```

Add this snippet to `_layout.cshtml` to enable PDF download functionality through IronPDF in your Blazor Application:

```html
<script>
	window.SubmitHTML = async (fileName, contentStreamReference) => {
		const arrayBuffer = await contentStreamReference.arrayBuffer();
		const blob = new Blob([arrayBuffer]);
		const url = URL.createObjectURL(blob);
		const anchorElement = document.createElement("a");
		anchorElement.href = url;
		anchorElement.download = fileName ?? "";
		anchorElement.click();
		anchorElement.remove();
		URL.revokeObjectURL(url);
	};
</script>
```

Update the NavMenu.razor file in the Shared folder to include a navigation tab linked to your new Razor component. Incorporate the following code:

```html
<div class="nav-item px-3">
	<NavLink class="nav-link" href="IronPdf">
		<span class="oi oi-list-rich" aria-hidden="true"></span> IronPdf
	</NavLink>
</div>
```

Once these modifications are implemented, run your project. You should then observe the following output:

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/tutorials/blazor-tutorial/blazor-tutorial-3.webp" alt="Blazor IronPDF Run Page Image" class="img-responsive add-shadow">
    </div>
</div>