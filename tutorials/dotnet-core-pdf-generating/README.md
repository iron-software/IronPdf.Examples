# HTML to PDF Conversion in .NET Core with IronPDF

## .NET Core PDF Creation

Generating PDF files within .NET Core applications can sometimes prove challenging. Whether it involves producing PDFs from ASP.NET MVC, converting HTML content or entire web pages into PDF documents, these tasks require robust solutions. Luckily, this guide uses IronPDF to simplify these processes, offering step-by-step instructions suited for your PDF-related needs in .NET.

**IronPDF provides tools for debugging your HTML using Chrome to ensure your PDFs are precise and pixel-perfect. A guide for setting this up is available [here](https://ironsoftware.com/how-to/pixel-perfect-html-to-pdf/).**

<hr class="separator">

<h4 class="tutorial-segment-title">Overview</h4>

By the end of this tutorial, you will have learned to:

- Transform various sources such as URLs, HTML content, and MVC views into PDF documents
- Utilize advanced functionalities for different PDF output settings
- Deploy projects across both Linux and Windows environments
- Manipulate PDF documents by adding headers, footers, merging documents, and incorporating stamps
- Utilize Docker

This extensive guide will equip you with the abilities to handle a variety of .NET Core HTML to PDF conversions for diverse project requirements.

<hr class="separator">

The content you're after has been revised for clarity and educational effectiveness, ensuring you grasp the full capabilities of IronPDF in handling HTML to PDF conversions within the .NET Core framework.

## Generating PDFs with .NET Core

Generating PDF files in .NET Core can often be complex. Managing PDF operations within ASP.NET MVC projects, or transforming MVC views, HTML documents, and web pages into PDF format presents various challenges. This guide leverages the IronPDF library to address these issues, offering a step-by-step approach tailored for your PDF development needs in .NET.

**Additionally, IronPDF facilitates HTML debugging using Chrome to ensure pixel-perfect PDFs. Discover how to configure this by visiting <a href="https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/">this tutorial</a>.**

<hr class="separator">

<h4 class="tutorial-segment-title">Overview</h4>

After completing this tutorial, you will have gained the ability to:

- Transform content from different inputs, including URLs, HTML content, and MVC views into PDF format.
- Utilize advanced configuration settings to customize the output of your PDFs.
- Deploy your application on both Linux and Windows operating systems.
- Manipulate PDF documents by adding headers and footers, merging documents, and applying stamps.
- Leverage Docker to enhance your project deployment and management.

These versatile .NET Core capabilities for converting HTML to PDF are designed to support a variety of project requirements.

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Free Installation of the IronPDF Library

IronPDF is versatile and can be integrated into various types of .NET projects, including Windows applications, ASP.NET MVC, and .NET Core applications.

There are two methods to incorporate the IronPDF library into your project: through the Visual Studio IDE using the NuGet Package Manager, or via the command line with a package management console.

<h3>Install using NuGet</h3>

To integrate the IronPDF library into our project via NuGet, we have the option to proceed either through the visual NuGet Package Manager within Visual Studio or by utilizing the Package Manager Console with commands.

<p class="list-decimal">1.1.1 Using NuGet Package Manager</p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/1.png" target="_blank">
<span class="no-link-style">1- Right click on project name -> Select Manage NuGet Package</span>
<img src="/img/tutorials/dot-net-core/1.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/2.png" target="_blank">
<span class="no-link-style">2- From browser tab -> search for IronPdf -> Install</span>
<img src="/img/tutorials/dot-net-core/2.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/3.png" target="_blank">
<span class="no-link-style">3- Click Ok</span>
<img src="/img/tutorials/dot-net-core/3.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/4.png" target="_blank">
<span class="no-link-style">4- Done!</span>
<img src="/img/tutorials/dot-net-core/4.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<p class="list-decimal">1.1.2 Using NuGet Package Console manager</p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/5.png" target="_blank">
<span class="no-link-style">1- From Tools -> NuGet Package Manager -> Package Manager Console</span>
<img src="/img/tutorials/dot-net-core/5.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/6.png" target="_blank">
<span class="no-link-style">2- Run command -> Install-Package IronPdf</span>
<img src="/img/tutorials/dot-net-core/6.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">
<h4 class="tutorial-segment-title">How To Tutorials</h4>

## 2. Transform a Website into a PDF Document

**Example: ConvertUrlToPdf Console Application**

Follow these steps to initiate a new Asp.NET MVC Project:

<p class="list-decimal">
</p>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/7.png" target="_blank">
<span class="no-link-style">1- Start by opening Visual Studio</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/7.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/8.png" target="_blank">
<span class="no-link-style">2- Click on 'Create new project'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/8.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/9.png" target="_blank">
<span class="no-link-style">3- Select 'Console App (.NET Core)'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/9.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/10.png" target="_blank">
<span class="no-link-style">4- Name your application “ConvertUrlToPdf” and click 'Create'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/10.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/11.png" target="_blank">
<span class="no-link-style">5- Your console application is now set up</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/11.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/12.png" target="_blank">
<span class="no-link-style">6- Add IronPdf to the project by clicking 'Install'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/12.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/13.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/13.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<p class="list-decimal">
  <span class="list-description">7- Begin coding your PDF transformation by targeting a main page to convert, such as the Wikipedia homepage</span>
</p>

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
pdf.SaveAs("wiki.pdf");
```

<p class="list-decimal">
</p>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/14.png" target="_blank">
<span class="no-link-style">8- Execute the project and locate the newly created file 'wiki.pdf'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/14.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<b>Sample: ConvertUrlToPdf console application</b>
<br>
<br>

Here is the revised section with the marked relative URL paths resolved to `ironpdf.com`:

-----
### Steps to Create a New ASP.NET MVC Project

Follow the below steps to initiate a new ASP.NET MVC project:

1. **Open Visual Studio**: Start by launching the Visual Studio IDE.
   
   ![Open Visual Studio](https://ironpdf.com/img/tutorials/dot-net-core/7.png)

2. **Create New Project**: From the dashboard, select the option to create a new project.
   
   ![Create New Project](https://ironpdf.com/img/tutorials/dot-net-core/8.png)

3. **Select Project Type**: Choose "Console App (.NET Core)" from the list of project types.
   
   ![Select Project Type](https://ironpdf.com/img/tutorials/dot-net-core/9.png)

4. **Name Your Project**: Label your project "ConvertUrlToPdf" and click on the 'create' button.
   
   ![Name Your Project](https://ironpdf.com/img/tutorials/dot-net-core/10.png)

5. **Project Setup Complete**: Your new console application is now set up.
   
   ![Project Setup Complete](https://ironpdf.com/img/tutorials/dot-net-core/11.png)

6. **Install IronPdf**: Next, add the IronPdf library by clicking 'install' in the NuGet package manager.
   
   ![Install IronPdf](https://ironpdf.com/img/tutorials/dot-net-core/12.png)

7. **Implement Code**: Start adding your code. Begin with initializing the IronPdf renderer to convert web pages to PDF.

   ```cs
   IronPdf.License.LicenseKey = "YourLicenseKey";
   ChromePdfRenderer renderer = new ChromePdfRenderer();
   PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
   pdf.SaveAs("wiki.pdf");
   ```

8. **Run & Verify**: Execute your project and verify whether the `wiki.pdf` has been created correctly.

   ![Run & Verify](https://ironpdf.com/img/tutorials/dot-net-core/14.png)

By following these steps, you can efficiently set up a new ASP.NET MVC project and implement the IronPdf library to create a PDF from a web URL.

<p class="list-decimal">
  <br>
  <span class="list-description"></span>
</p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/7.png" target="_blank">
<span class="no-link-style">1- Open Visual Studio</span>
<img src="/img/tutorials/dot-net-core/7.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/8.png" target="_blank">
<span class="no-link-style">2- Choose Create new project</span>
<img src="/img/tutorials/dot-net-core/8.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/9.png" target="_blank">
<span class="no-link-style">3- Choose Console App (.NET Core)</span>
<img src="/img/tutorials/dot-net-core/9.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/10.png" target="_blank">
<span class="no-link-style">4- Give our sample name “ConvertUrlToPdf” and click create</span>
<img src="/img/tutorials/dot-net-core/10.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/11.png" target="_blank">
<span class="no-link-style">5- Now we have a console application created</span>
<img src="/img/tutorials/dot-net-core/11.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/12.png" target="_blank">
<span class="no-link-style">6- Add IronPdf => click install</span>
<img src="/img/tutorials/dot-net-core/12.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/13.png" target="_blank">
<img src="/img/tutorials/dot-net-core/13.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<p class="list-decimal">
  <span class="list-description">7- Add our first few lines that render a Wikipedia website main page to PDF</span>
</p>

Here's the paraphrased section of the code with improved comments and slight adjustments to the code structure for better understanding:

```cs
// Set the license key for IronPdf to unlock all features
IronPdf.License.LicenseKey = "YourLicenseKey";

// Create an instance of the ChromePdfRenderer class
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Convert the HTML content of the Wikipedia main page to a PDF
PdfDocument document = pdfRenderer.RenderUrlAsPdf("https://www.wikipedia.org/");

// Save the newly created PDF document to a file named "wiki.pdf"
document.SaveAs("wiki.pdf");
```

<p class="list-decimal"></p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/14.png" target="_blank">
<span class="no-link-style">8- Run and check created file wiki.pdf</span>
<img src="/img/tutorials/dot-net-core/14.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## 3. Transforming .NET Core HTML into PDF

<p class="list-decimal">
<b>Example: ConvertHTMLToPdf Console Application</b>
<br>
<br>
  <span class="list-description">
    Here are two methods for converting HTML content into a PDF:<br>
    <span class="list-description">
      1- Directly encode HTML strings and then render them.<br>
      2- Save the HTML content to a file and then pass its path to IronPDF for rendering.<br>
    </span>
    <br>
    Below is the code snippet that illustrates rendering of HTML string into PDF.
  </span>
</p>

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
pdf.SaveAs("RenderedHtml.pdf");
```

<p class="list-decimal">
  <span class="list-description">Here's how the resultant PDF will appear.</span>
</p>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/15.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/15.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<p class="list-decimal">
<b>Sample: ConvertHTMLToPdf Console application</b>
<br>
<br>
  <span class="list-description">

Below are two methods for converting HTML to PDF:

1. Convert from a string containing HTML:
   
   ```cs
   IronPdf.License.LicenseKey = "YourLicenseKey";
   var pdfRenderer = new IronPdf.ChromePdfRenderer();
   var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
   pdfDocument.SaveAs("HtmlFromString.pdf");
   ```

2. Convert from an HTML file by specifying the path:

   ```cs
   PdfDocument pdfFromHtml = pdfRenderer.RenderHtmlFileAsPdf("path/to/yourHtmlFile.html");
   pdfFromHtml.SaveAs("HtmlFromFile.pdf");
   ```

The results of these conversions will be PDF files generated from the specified HTML content.

<span class="list-description">

Here's the paraphrased section with resolved URLs:

-----
1. Compose HTML content directly in a string and utilize it for rendering.
   
2. Save HTML content to a file and then provide the file's path to IronPDF for processing.

</span>
    <br>

Below is how the sample code for rendering an HTML string appears:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
pdf.SaveAs("HtmlString.pdf");
```

</span>
</p>

Here's a rewritten version of the provided C# code snippet, with enhanced comments for better understanding:

```cs
// Initialize the IronPDF License with your unique license key
IronPdf.License.LicenseKey = "YourLicenseKey";

// Create a PDF Renderer using the Chrome rendering engine
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF document by rendering an HTML string
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF</h1>");

// Save the generated PDF to a file named 'HtmlString.pdf'
pdf.SaveAs("HtmlString.pdf");
```

This revised version includes clearer and more descriptive comments that explain what each line of code accomplishes within the context of the IronPDF library usage.

<p class="list-decimal">
  <span class="list-description">And the resulting PDF will look like this.</span>
</p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/15.png" target="_blank">
<img src="/img/tutorials/dot-net-core/15.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## 4. Convert MVC View to PDF

**Example Project: TicketsApps .NET Core MVC Application**

To illustrate the practical application of IronPDF, let’s execute a detailed exercise by creating a mock-up online ticket booking system, with a feature to export the generated ticket as a PDF document.

We'll breeze through the following steps to build our MVC application:

- [Set Up the Project](#anchor-create-project)
- [Establish a Client Object Model](#anchor-add-client-model)
- [Develop Client Services](#anchor-add-client-services)
- [Design the Ticket Booking Interface](#anchor-design-ticket-booking-page)
- [Validate and Record Booking Data](#anchor-validate-and-save-the-booking-information)
- [Export the Booking as a PDF Ticket](#anchor-download-pdf-ticket)

### Initiating a New Project

1. Select the "ASP.NET Core Web App (Model-View-Controller)" as your project type.

<img src="/img/tutorials/dot-net-core/16.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

## 4. Convert MVC View to PDF

**Sample: TicketsApps .NET Core MVC Application**

For our practical application, we will develop a web-based ticketing system. Start by opening the site, navigating to the 'book ticket' section, entering the necessary details, and then seamlessly downloading your ticket as a PDF.

To accomplish this, follow these steps:

- [Create Project](#anchor-create-project)
- [Create client object model](#anchor-add-client-model)
- [Create client services (add, view)](#anchor-add-client-services)
- [Design Ticket Booking Page](#anchor-design-ticket-booking-page)
- [Validate and Save The Booking Information](#anchor-validate-and-save-the-booking-information)
- [Download PDF ticket](#anchor-download-pdf-ticket)

### Create Project

1. Select "ASP.NET Core Web App (Model-View-Controller)" as the project type.

![Project Type](https://ironpdf.com/img/tutorials/dot-net-core/16.webp)

2. Assign the name "TicketsApps" to your project.

![Name Your Project](https://ironpdf.com/img/tutorials/dot-net-core/17.webp)

3. Choose to use .NET 8 and enable Linux Docker. Modify the Dockerfile by replacing "USER app" with "USER root" to ensure the library has the appropriate permissions.

![Enable Docker and Set Permissions](https://ironpdf.com/img/tutorials/dot-net-core/18.webp)

4. Your project setup is now complete.

![Setup Complete](https://ironpdf.com/img/tutorials/dot-net-core/19.webp)

<img src="/img/tutorials/dot-net-core/17.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

3. Procede by deploying .NET 8 and enabling Linux Docker. Modify the Dockerfile by replacing `"USER app"` with `"USER root"`. This adjustment assures that the library is allocated the necessary permissions.

<img src="/img/tutorials/dot-net-core/18.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

4. The project setup is now complete.

<img src="/img/tutorials/dot-net-core/19.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Adding a Client Model

1. Open your project in the IDE and right-click on the "Models" folder. From the context menu, select "Add" followed by "Class".

<img src="/img/tutorials/dot-net-core/20.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

2. Assign the name "ClientModel" to your model and then proceed by clicking on 'add'.

<img src="/img/tutorials/dot-net-core/21.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

```cs
3. Enhance the `ClientModel` class by defining the attributes 'name', 'phone', and 'email'. Ensure each of these fields is mandatory by appending the 'Required' attribute to them, as illustrated below:
```

Here's the paraphrased section with relative URL paths resolved:

```cs
public class CustomerModel
{
    [Required]
    public string Name { get; set; } // Name is mandatory

    [Required]
    public string Phone { get; set; } // Phone number is mandatory

    [Required]
    public string Email { get; set; } // Email address is mandatory
}
```

### Setting Up Client Services

1. Begin by creating a new folder and label it as "services."

2. Inside this folder, define a new class called `ClientServices`.

3. Within this class, introduce a static instance of `ClientModel` which will act as a repository.

4. Implement two methods in this class: the first method should store client data in the repository, and the second should fetch this data when needed.

Below is a paraphrased version of the specified code section, ensuring your understanding of implementing basic client services within a .NET Core application remains clear:

```cs
public class ClientRepository
{
    private static ClientModel _storedClientModel;
    
    // Method to store client information
    public static void StoreClient(ClientModel client)
    {
        _storedClientModel = client;
    }

    // Method to retrieve stored client information
    public static ClientModel RetrieveClient()
    {
        return _storedClientModel;
    }
}
``` 

This code snippet serves the same purpose as the original, providing a simplistic way to store and retrieve client data using a static member within a class.

### Designing the Ticket Booking Page

1. In the Solution Explorer, right-click on the "Controllers" folder and select the option to add a new controller.

<img src="/img/tutorials/dot-net-core/22.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

2. Assign the name "BookTicketController" to it.
```

<img src="/img/tutorials/dot-net-core/23.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

3. Right-click on the `index` function (also known as an action) and select "Add View."

<img src="/img/tutorials/dot-net-core/24.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

4. Creating the "Index" View

Next, you will need to establish a View known as "index." To do this:

1. From the Solution Explorer, right-click on the "Controllers" directory and choose to add a controller.
   
   ![Add Controller](https://ironpdf.com/img/tutorials/dot-net-core/23.webp "Add Controller")

2. Assign the name "BookTicketController" to the new controller.
   
   ![Name Controller](https://ironpdf.com/img/tutorials/dot-net-core/24.webp "Name Controller")

3. Right-click on the `Index` action method, or the method you designate for this purpose, and select "Add View."
   
   ![Add View](https://ironpdf.com/img/tutorials/dot-net-core/25.webp "Add View")

4. Specify "index" as the name for your new View.
   
   ![Name View](https://ironpdf.com/img/tutorials/dot-net-core/26.webp "Name View")

By following these steps, your application's architecture will now include a new "index" View, ready for further configuration and use in your project.
```

<img src="/img/tutorials/dot-net-core/25.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

```cs
@model IronPdfMVCHelloWorld.Models.ClientModel
@{
  ViewBag.Title = "Ticket Reservation";
}
<h2>Booking Page</h2>
@using (Html.BeginForm())
{
  <div class="form-horizontal">
    @Html.ValidationSummary(true, "", new { @class = "text-danger" })
    <div class="form-group">
      @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } })
        @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" })
      </div>
    </div>
    <div class="form-group">
      @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } })
        @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" })
      </div>
    </div>
    <div class="form-group">
      @Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } })
        @Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" })
      </div>
    </div>
    <div class="form-group">
      <div class="col-md-offset-2 col-md-10">
        <button type="submit" class="btn btn-primary">Submit</button>
      </div>
    </div>
  </div>
}
```
This HTML code snippet updates an ASP.NET MVC form for booking, aligning form controls and incorporating data validation to improve user interaction and system reliability.

```cs
@model IronPdfMVCHelloWorld.Models.ClientModel
@{
  ViewBag.Title = "Ticket Reservation";
}
<h2>Main Page</h2>
@using (Html.BeginForm())
{
  <div class="form-horizontal">
    @Html.ValidationSummary(true, "", new { @class = "text-errors" })
    <div class="form-group">
      @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-input" } })
        @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-errors" })
      </div>
    </div>
    <div class="form-group">
      @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-input" } })
        @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-errors" })
      </div>
    </div>
    <div class="form-group">
      @Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" })
      <div class="col-md-10">
        @Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-input" } })
        @Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-errors" })
      </div>
    </div>
    <div class="form-group">
      <div class="col-md-10 align-right">
        <button type="submit" class="button small">
          <i class="icon plus-circle"></i>
          <span>Confirm</span>
        </button>
      </div>
    </div>
  </div>
}
```

```html
6. Include a navigation link to direct visitors to the newly created booking page. This adjustment involves modifying the layout found at (Views -> Shared -> \_Layout.cshtml). Insert this code snippet:
```html
<li class="nav-item">
    <a
        class="nav-link text-dark"
        asp-area=""
        asp-controller="BookTicket"
        asp-action="Index"
    >Book Ticket</a>
</li>
```

```html
<li class="nav-item">
  <a
    class="nav-link text-dark"
    asp-area=""
    asp-controller="BookTicket"
    asp-action="Index"
  >Reserve Your Ticket</a>
</li>
```

Here is the paraphrased section with updated links and images resolved to the Iron Software domain:

-----
7. The final display should appear as follows.

<img src="https://ironpdf.com/img/tutorials/dot-net-core/27.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

<img src="/img/tutorials/dot-net-core/26.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

8. Proceed to the "Book Ticket" page. Here's how it should appear:
```

![Book Ticket Page](https://ironpdf.com/img/tutorials/dot-net-core/27.webp)

<img src="/img/tutorials/dot-net-core/27.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Confirm and Store Booking Details

1. Incorporate an additional index action marked with the attribute `[HttpPost]`. This notifies the MVC framework that this action is intended for data submission. The system will verify the provided model; if it passes validation, users will be rerouted to the TicketView page. Conversely, if validation fails, error messages will be displayed on the user interface to inform the visitor.

Here is a paraphrased version of the specified section of the article, with relative URL paths resolved to `ironpdf.com`:

```cs
[HttpPost]
public ActionResult Index(ClientModel model)
{
    // Check if the model state is valid
    if (ModelState.IsValid)
    {
        // Add the client using the ClientServices method
        ClientServices.AddClient(model);
        // Redirect to the TicketView action if the model is valid
        return RedirectToAction("TicketView");
    }
    // Return the original view with the model to display any validation errors
    return View(model);
}
```

In this example, you'll see how error messages are displayed when the model validation fails during a form submission. If the data inputs do not meet the validation criteria set in your model, the MVC framework will generate error messages which are shown to the user. These messages provide instant feedback, helping to ensure that the correct data is collected. You can observe an example of these error messages in the image provided below:

[Link to image with example error messages](https://ironpdf.com/img/tutorials/dot-net-core/28.webp)

<img src="/img/tutorials/dot-net-core/28.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

## Ticket Model Creation

In the "Models" directory, add a new class as shown below:

```cs
public class TicketModel : ClientModel
{
    [Required]
    public int TicketNumber { get; set; }
    [Required]
    public DateTime TicketDate { get; set; }
}
```

This code snippet defines a new `TicketModel` class, which extends from the `ClientModel`. Here, additional attributes essential for managing ticket details, namely `TicketNumber` and `TicketDate`, are incorporated, ensuring they are mandatory with the `[Required]` attribute. This structure helps in maintaining clear and valid ticket data in the system.

```cs
public class TicketModel : ClientModel
{
    // Contains the number assigned to a ticket
    public int TicketNumber { get; set; }
    
    // Stores the date associated with the ticket
    public DateTime TicketDate { get; set; }
}
```

### 3. Set up the TicketView

This step involves setting up the `TicketView` to showcase the ticket details. It includes a partially embedded view specifically crafted to show the ticket information that will subsequently be utilized for printing the ticket.

Here is the paraphrased version of the provided section from the article:

```cs
public ActionResult TicketView()
{
    // Instantiate random number generator
    Random numberGenerator = new Random();
    
    // Retrieve the client details
    ClientModel clientDetails = ClientServices.GetClient();

    // Create a new ticket instance
    TicketModel newTicket = new TicketModel()
    {
        // Generate a random ticket number
        TicketNumber = numberGenerator.Next(100000, 999999),
        // Set the ticket date to current date and time
        TicketDate = DateTime.Now,
        // Assign client details
        Email = clientDetails.Email,
        Name = clientDetails.Name,
        Phone = clientDetails.Phone
    };

    // Pass the new ticket information to the view
    return View(newTicket);
}
```

This version integrates descriptive variable names and comments to enhance code readability, maintaining the functionality and structure of the original code snippet.

```html
4. Right-click on the TicketView method, select "Add View", and designate the view as "TicketView". Incorporate the code below:
```

```html
@model TicketsApps.Models.TicketModel
@{
    ViewData["Title"] = "View Ticket";
}
@Html.Partial("_TicketPdf", Model)
@using (Html.BeginForm())
{
    @Html.HiddenFor(model => model.Email)
    @Html.HiddenFor(model => model.Name)
    @Html.HiddenFor(model => model.Phone)
    @Html.HiddenFor(model => model.TicketDate)
    @Html.HiddenFor(model => model.TicketNumber)

    <div class="form-group">
        <div class="col-md-10 offset-md-2">
            <button type="submit" class="btn btn-small">
                <i class="fa fa-download"></i>
                <span> Save PDF </span>
            </button>
        </div>
    </div>
}
```

```html
5. Right-click on the BookTicket file, proceed to add a new View and label it as "\_TicketPdf". Insert the code below:
```

Here's a paraphrased version of the provided HTML section with relative URL paths resolved to `ironpdf.com`:

```html
@model TicketsApps.Models.TicketModel
@{ Layout = null; }
<link href="https://ironpdf.com/css/ticket.css" rel="stylesheet">
<div class="ticket">
    <div class="stub">
        <div class="top">
            <span class="admit">VIP</span>
            <span class="line"></span>
            <span class="num">
                @Model.TicketNumber<span> Ticket</span>
            </span>
        </div>
        <div class="number">1</div>
        <div class="invite">Room Number</div>
    </div>
    <div class="check">
        <div class="big">
            Your<br/>
            Ticket
        </div>
        <div class="number">VIP</div>
        <div class="details">
            <section>
                <div class="title">Date</div>
                <div>@Model.TicketDate.ToShortDateString()</div>
            </section>
            <section>
                <div class="title">Issued By</div>
                <div>Admin</div>
            </section>
            <section>
                <div class="title">Invite Number</div>
                <div>@Model.TicketNumber</div>
            </section>
        </div>
    </div>
</div>
```

Changes made:
- Updated the layout directive to be on its own line for clarity.
- Changed "info" class to "details" for more descriptive naming.
- Modified the relative path for the CSS file to point to the absolute URL hosted on `ironpdf.com`.

6. Incorporate the "[ticket.css](https://ironpdf.com/img/tutorials/dot-net-core/ticket.css)" stylesheet into the "wwwroot/css" directory of your project.

7. Integrate IronPDF into your project and accept the licensing terms.

<img src="/img/tutorials/dot-net-core/31.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

```cs
// Add the post method for TicketView to manage the download functionality
[HttpPost]
public ActionResult TicketView(TicketModel model)
{
    // License configuration for IronPDF
    IronPdf.License.LicenseKey = "YourLicenseKey";
    
    // Set up temporary folder path for processing
    IronPdf.Installation.TempFolderPath = $@"{Directory.GetParent}/irontemp/";
    
    // Automatic configuration for dependencies in Linux and Docker environments
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

    // Render the ticket view to HTML string
    var htmlContent = this.RenderViewAsync("_TicketPdf", model);

    // Initialize Chrome PDF renderer
    var pdfRenderer = new IronPdf.ChromePdfRenderer();

    // Generate PDF from the HTML content with the specified CSS
    using var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent.Result, @"wwwroot/css");
    
    // Return the PDF document as a file response to download
    return File(pdfDocument.Stream.ToArray(), "application/pdf");
}
```

Here's the paraphrased section of the article with resolved relative URL paths:

```cs
[HttpPost]
public ActionResult DisplayTicketAsPdf(TicketModel ticketDetails)
{
    IronPdf.License.LicenseKey = "YourLicenseKey"; // Set your license key
    IronPdf.Installation.TempFolderPath = $@"{Directory.GetParent(Environment.CurrentDirectory)}/irontemp/"; // Set temporary path for operations
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true; // Automatically configure dependencies for Linux and Docker environments
    var htmlContent = this.RenderViewAsync("_TicketPdf", ticketDetails); // Convert the _TicketPdf view into HTML
    ChromePdfRenderer pdfRenderer = new ChromePdfRenderer(); // Instantiate PDF renderer
    using PdfDocument pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent.Result, @"wwwroot/css"); // Convert HTML to PDF with styling
    return File(pdfDocument.Stream.ToArray(), "application/pdf"); // Return the generated PDF as a file download
}
```

This revised version aligns with the original functionality but uses slightly different variable names and comments to explain each step clearer.

Here is the paraphrased section:

---

9. Develop a controller within the "Controller" directory and designate it as "ControllerExtensions". This controller is responsible for converting the partial view into a string format. Implement the extension using the code provided below:

```cs
using System.IO;
using System.Threading.Tasks;

// Static class for extending Controller functionalities
public static class ControllerExtensions
{
    // Asynchronous method to render a view into a string
    public static async Task<string> RenderViewAsync<TModel>(this Controller controller, string viewName, TModel model, bool partial = false)
    {
        // Default to the action name if no view name is provided
        if (string.IsNullOrEmpty(viewName))
        {
            viewName = controller.ControllerContext.ActionDescriptor.ActionName;
        }

        // Assign the model to ViewData for use in the view
        controller.ViewData.Model = model;

        // StringWriter to capture the rendering output
        using (var writer = new StringWriter())
        {
            // Get the view engine from the services and cast it
            IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;

            // Find the view in the application and check for success
            ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, !partial);
            if (!viewResult.Success)
            {
                return $"Unable to find a view with the name {viewName}";
            }

            // Set up the ViewContext and render the view into the writer
            ViewContext viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, writer, new HtmlHelperOptions());
            await viewResult.View.RenderAsync(viewContext);

            // Return the rendered view as a string
            return writer.GetStringBuilder().ToString();
        }
    }
}
```

---
10. Execute the application and input your ticket details before clicking on the 'Save' button.
---

<img src="/img/tutorials/dot-net-core/32.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Viewing the Created Ticket

After successfully filling out and saving the ticket information, you can view the generated ticket as follows:

```html
<img src="https://www.ironpdf.com/img/tutorials/dot-net-core/33.webp" alt="Generated Ticket" class="img-responsive add-shadow img-margin" style="max-width:100%;">
```

<img src="/img/tutorials/dot-net-core/33.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### PDF Ticket Download

To obtain your ticket in PDF format, simply click the 'Download PDF' button. This will generate a PDF document containing your ticket details.

For those interested in the code used in this guide, you can acquire the full source code packaged in a ZIP file. Once downloaded, it's ready to be explored using Visual Studio. [Download the complete project here](https://ironpdf.com/img/tutorials/dot-net-core/TicketsApps.zip).

<hr class="separator">

## 5. .NET PDF Render Options Chart

Explore a range of advanced settings available for configuring PDF rendering preferences including margin adjustments, paper orientation, and paper sizes among other aspects.

Here's a detailed table showcasing various configuration options available:

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Class</th>
          <th colspan="2" style="font-family:'Gotham-Light'">ChromePdfRenderer</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Description</th>
          <th colspan="2" style="font-family:'Gotham-Light'">Configure PDF print outputs, including paper size, DPI, plus headers and footers settings</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Properties / functions</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Description</th>
      </tr>
      <tr>
          <td>CustomCookies</td>
          <td>Dictionary&lt;string, string&gt;</td>
          <td>Set temporary custom cookies for HTML rendering; cookies do not persist beyond individual render sessions and require reassignment for each session.</td>
      </tr>
      <tr>
          <td>PaperFit</td>
          <td>VirtualPaperLayoutManager</td>
          <td>Customize how content fits on the digital paper within your PDF, with options for scaling and layout style including Default Chrome Behavior, Zoomed, and Responsive CSS Layouts.</td>
      </tr>
      <tr>
          <td>UseMarginsOnHeaderAndFooter</td>
          <td>UseMargins</td>
          <td>Option to apply document margin settings to headers and footers during rendering.</td>
      </tr>
      <tr>
          <td>CreatePdfFormsFromHtml</td>
          <td>bool</td>
          <td>Converts HTML form elements to interactive PDF forms. Set to true by default.</td>
      </tr>
      <tr>
          <td>CssMediaType</td>
          <td>PdfCssMediaType</td>
          <td>Allow Media="screen" CSS styles and style sheets to be applied, defaulting to PdfCssMediaType.Screen.</td>
      </tr>
      <tr>
          <td>CustomCssUrl</td>
          <td>string</td>
          <td>Link a custom CSS style-sheet, either from a local file path or URL, applicable only when rendering from HTML.</td>
      </tr>
      <tr>
          <td>EnableJavaScript</td>
          <td>bool</td>
          <td>Activate JavaScript execution before page rendering, beneficial for pages with Ajax or JavaScript-driven content. Default is false.</td>
      </tr>
      <tr>
          <td>EnableMathematicalLaTex</td>
          <td>bool</td>
          <td>Permits the PDF to render Mathematical LaTeX commands and expressions.</td>
      </tr>
      <tr>
          <td>Javascript</td>
          <td>string</td>
          <td>Execute custom JavaScript code after the HTML loads but before converting to PDF.</td>
      </tr>
      <tr>
          <td>JavascriptMessageListener</td>
          <td>StringDelegate</td>
          <td>Defines a callback function triggered by browser JavaScript console messages during the rendering process.</td>
      </tr>
      <tr>
          <td>FirstPageNumber</td>
          <td>int</td>
          <td>Start numbering pages from a specified number; defaults to 1.</td>
      </tr>
      <tr>
          <td>TableOfContents</td>
          <td>TableOfContentsTypes</td>
          <td>Automatically generates a clickable table of contents based on HTML elements defined with an id "ironpdf-toc".</td>
      </tr>
      <tr>
          <td>GrayScale</td>
          <td>bool</td>
          <td>Generates the document in grayscale to reduce file size and simplify printing. Defaults to false.</td>
      </tr>
        <tr>
        <td>TextHeader</td>
        <td rowspan="2">ITextHeaderFooter</td>
        <td rowspan="2">Customize text-based headers and footers for each page, with mail-merge fields for dynamic data such as URLs, date, and title.</td>
      </tr>
      <tr>
        <td>TextFooter</td>
      </tr>
      <tr>
          <td>HtmlHeader</td>
          <td rowspan="2">HtmlHeaderFooter</td>
          <td rowspan="2">Set complex HTML content as headers for every PDF page, allowing richer formatting and visualization.</td>
      </tr>
      <tr>
          <td>HtmlFooter</td>
      </tr>
      <tr>
          <td>InputEncoding</td>
          <td>Encoding</td>
          <td>Specify the text encoding used, such as UTF-8 or other character encodings. Default is Encoding.UTF8.</td>
      </tr>
      <tr>
          <td>MarginTop</td>
          <td>double</td>
          <td>Configure the top margin of the PDF in millimeters. Set to zero for edge-to-edge printing. Default is 25 mm.</td>
      </tr>
      <tr>
          <td>MarginRight</td>
          <td>double</td>
          <td>Set the right margin of the PDF document in millimeters. Defaults to 25 mm, can be zeroed for specific formatting needs.</td>
      </tr>
      <tr>
          <td>MarginBottom</td>
          <td>double</td>
          <td>Define the bottom margin in millimeters. This can also be set to zero for border-less printing applications. Default is 25 mm.</td>
      </tr>
      <tr>
          <td>MarginLeft</td>
          <td>double</td>
          <td>Adjust the left margin in millimeters. Default setting is 25 mm, but can be reduced to zero for border-less layouts.</td>
      </tr>
      <tr>
        <td>PaperOrientation</td>
        <td>PdfPaperOrientation</td>
        <td>Select the orientation of the PDF paper between Portrait and Landscape. Default is Portrait.</td>
      </tr>
      <tr>
        <td>PaperSize</td>
        <td>PdfPaperSize</td>
        <td>Choose from standard preset paper sizes to suit various document types.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinCentimeters</td>
        <td rowspan="4">double</td>
        <td>Determine the paper size in centimeters to cater to specific page dimensions.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeInInches</td>
        <td>Define paper size using inch measurements.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinMilimeters</td>
        <td>Adjust the paper size in millimeters for precise formatting requirements.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinPixelsOrPoints</td>
        <td>Customize the paper size in pixels or points, useful for digital-specific formats.</td>
      </tr>
      <tr>
        <td>PrintHtmlBackgrounds</td>
        <td>Boolean</td>
        <td>Whether to print background colors and images from the HTML content. Default is set to true.</td>
      </tr>
      <tr>
        <td>RequestContext</td>
        <td>RequestContexts</td>
        <td>Define the request context for the render, managing the isolation of specific resources like cookies.</td>
      </tr>
      <tr>
        <td>Timeout</td>
        <td>Integer</td>
        <td>Set a timeout for the render process, in seconds. Default is 60 seconds.</td>
      </tr>
      <tr>
        <td>Title</td>
        <td>String</td>
        <td>Assign a name and title metadata to the PDF, useful for organizing documents and setting user-friendly names.</td>
      </tr>
      <tr>
        <td>ForcePaperSize</td>
        <td>Boolean</td>
        <td>Ensures specified paper sizes are adhered to strictly by adjusting the page size post-render if necessary, correcting small discrepancies.</td>
      </tr>
      <tr>
        <td>WaitFor</td>
        <td>WaitFor</td>
        <td>Configurable conditions that the renderer should wait for before completing the rendering process. Default setting waits for no specific events.</td>
      </tr>
    </tbody>
  </table>
</div>

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Class</th>
          <th colspan="2" style="font-family:'Gotham-Light'">ChromePdfRenderer</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Description</th>
          <th colspan="2" style="font-family:'Gotham-Light'">Used to define PDF print out options, like paper size, DPI, headers and footers</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Properties / functions</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Description</th>
      </tr>
      <tr>
          <td>CustomCookies</td>
          <td>Dictionary&lt;string, string&gt;</td>
          <td>Custom cookies for the HTML render. Cookies do not persist between renders and must be set each time.</td>
      </tr>
      <tr>
          <td>PaperFit</td>
          <td>VirtualPaperLayoutManager</td>
          <td>A manager for setting up virtual paper layouts, controlling how content will be laid out on PDF "paper" pages. Includes options for Default Chrome Behavior, Zoomed, Responsive CSS3 Layouts, Scale-To-Page &amp; Continuous Feed style PDF page setups.</td>
      </tr>
      <tr>
          <td>UseMarginsOnHeaderAndFooter</td>
          <td>UseMargins</td>
          <td>Use margin values from the main document when rendering headers and footers.</td>
      </tr>
      <tr>
          <td>CreatePdfFormsFromHtml</td>
          <td>bool</td>
          <td>Turns all HTML form elements into editable PDF forms. Default value is true.</td>
      </tr>
      <tr>
          <td>CssMediaType</td>
          <td>PdfCssMediaType</td>
          <td>Enables Media="screen" CSS Styles and StyleSheets. Default value is PdfCssMediaType.Screen.</td>
      </tr>
      <tr>
          <td>CustomCssUrl</td>
          <td>string</td>
          <td>Allows a custom CSS style-sheet to be applied to HTML before rendering. May be a local file path or a remote URL. Only applicable when rendering HTML to PDF.</td>
      </tr>
      <tr>
          <td>EnableJavaScript</td>
          <td>bool</td>
          <td>Enables JavaScript and JSON to be executed before the page is rendered. Ideal for printing from Ajax / Angular Applications. Default value is false.</td>
      </tr>
      <tr>
          <td>EnableMathematicalLaTex</td>
          <td>bool</td>
          <td>Enables rendering of Mathematical LaTeX Elements.</td>
      </tr>
      <tr>
          <td>Javascript</td>
          <td>string</td>
          <td>A custom JavaScript string to be executed after all HTML has loaded but before PDF rendering.</td>
      </tr>
      <tr>
          <td>JavascriptMessageListener</td>
          <td>StringDelegate</td>
          <td>A method callback to be invoked whenever a browser JavaScript console message becomes available.</td>
      </tr>
      <tr>
          <td>FirstPageNumber</td>
          <td>int</td>
          <td>First page number to be used in PDF Headers and Footers. Default value is 1.</td>
      </tr>
      <tr>
          <td>TableOfContents</td>
          <td>TableOfContentsTypes</td>
          <td>Generates a table of contents at the location in the HTML document where an element is found with id "ironpdf-toc".</td>
      </tr>
      <tr>
          <td>GrayScale</td>
          <td>bool</td>
          <td>Outputs a black-and-white PDF. Default value is false.</td>
      </tr>
        <tr>
        <td>TextHeader</td>
        <td rowspan="2">ITextHeaderFooter</td>
        <td rowspan="2">Sets the footer content for every PDF page as text, supporting 'mail-merge' and automatically turning URLs into hyperlinks.</td>
      </tr>
      <tr>
        <td>TextFooter</td>
      </tr>
      <tr>
          <td>HtmlHeader</td>
          <td rowspan="2">HtmlHeaderFooter</td>
          <td rowspan="2">Sets the header content for every PDF page as HTML. Supports 'mail-merge'.</td>
      </tr>
      <tr>
          <td>HtmlFooter</td>
      </tr>
      <tr>
          <td>InputEncoding</td>
          <td>Encoding</td>
          <td>The input character encoding as a string. Default value is Encoding.UTF8.</td>
      </tr>
      <tr>
          <td>MarginTop</td>
          <td>double</td>
          <td>Top PDF "paper" margin in millimeters. Set to zero for border-less and commercial printing applications. Default value is 25.</td>
      </tr>    
      <tr>
          <td>MarginRight</td>
          <td>double</td>
          <td>Right PDF "paper" margin in millimeters. Set to zero for border-less and commercial printing applications. Default value is 25.</td>
      </tr>
      <tr>
          <td>MarginBottom</td>
          <td>double</td>
          <td>Bottom PDF "paper" margin in millimeters. Set to zero for border-less and commercial printing applications. Default value is 25.</td>
      </tr>
      <tr>
          <td>MarginLeft</td>
          <td>double</td>
          <td>Left PDF "paper" margin in millimeters. Set to zero for border-less and commercial printing applications. Default value is 25.</td>
      </tr>
      <tr>
        <td>PaperOrientation</td>
        <td>PdfPaperOrientation</td>
        <td>The PDF paper orientation, such as Portrait or Landscape. Default value is Portrait.</td>
      </tr>
      <tr>
        <td>PaperSize</td>
        <td>PdfPaperSize</td>
        <td>Sets the paper size</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinCentimeters</td>
        <td rowspan="4">double</td>
        <td>Sets the paper size in centimeters.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeInInches</td>
        <td>Sets the paper size in inches.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinMilimeters</td>
        <td>Sets the paper size in millimeters.</td>
      </tr>
      <tr>
        <td>SetCustomPaperSizeinPixelsOrPoints</td>
        <td>Sets the paper size in screen pixels or printer points.</td>
      </tr>
      <tr>
        <td>PrintHtmlBackgrounds</td>
        <td>Boolean</td>
        <td>Indicates whether to print background-colors and images from HTML. Default value is true.</td>
      </tr>
      <tr>
        <td>RequestContext</td>
        <td>RequestContexts</td>
        <td>Request context for this render, determining isolation of certain resources such as cookies.</td>
      </tr>
      <tr>
        <td>Timeout</td>
        <td>Integer</td>
        <td>Render timeout in seconds. Default value is 60.</td>
      </tr>
      <tr>
        <td>Title</td>
        <td>String</td>
        <td>PDF Document Name and Title metadata, useful for mail-merge and automatic file naming in the IronPdf MVC and Razor extensions.</td>
      </tr>
      <tr>
        <td>ForcePaperSize</td>
        <td>Boolean</td>
        <td>Force page sizes to be exactly what is specified via IronPdf.ChromePdfRenderOptions.PaperSize by resizing the page after generating a PDF from HTML. Helps correct small errors in page size when rendering HTML to PDF.</td>
      </tr>
      <tr>
        <td>WaitFor</td>
        <td>WaitFor</td>
        <td>A wrapper object that holds configuration for wait-for mechanism for users to wait for certain events before rendering. By default, it will wait for nothing.</td>
      </tr>
    </tbody>
  </table>
</div>

<hr class="separator">

## .NET PDF Header and Footer Configuration Options

The following chart details the configuration options available for adding headers and footers in .NET PDFs using IronPDF:

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Component</th>
          <th colspan="2" style="font-family:'Gotham-Light'">TextHeaderFooter</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Overview</th>
          <th colspan="2" style="font-family:'Gotham-Light'">Defines the text display options for headers and footers in PDF documents</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Attributes / Methods</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Usage</th>
      </tr>
      <tr>
          <td>CenterText</td>
          <td rowspan="3">string</td>
          <td rowspan="3">Positions the text centrally, or to the left or right of the PDF header or footer. Supports metadata placeholders such as {page}, {total-pages}, {url}, {date}, {time}, {html-title}, and {pdf-title}.</td>
      </tr>
      <tr>
          <td>LeftText</td>
      </tr>
      <tr>
          <td>RightText</td>
      </tr>
      <tr>
          <td>DrawDividerLine</td>
          <td>Boolean</td>
          <td>Includes a horizontal line separator between the header/footer and the main content across every page.</td>
      </tr>
      <tr>
          <td>DrawDividerLineColor</td>
          <td>Color</td>
          <td>Specifies the color of the divider line used by IronPdf.TextHeaderFooter.DrawDividerLine.</td>
      </tr>
      <tr>
          <td>Font</td>
          <td>PdfFont</td>
          <td>Determines the font family for the PDF document content. Helvetica is set by default.</td>
      </tr>
      <tr>
          <td>FontSize</td>
          <td>Double</td>
          <td>Controls the size of the font used in points.</td>
      </tr>
    </tbody>
  </table>
</div>

This table encapsulates key settings that can be adjusted to customize the headers and footers in your PDF documents when using IronPDF. Each option allows for a detailed customization of the text layout and style, ensuring your PDFs maintain a professional and coherent appearance across all pages.

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Class</th>
          <th colspan="2" style="font-family:'Gotham-Light'">TextHeaderFooter</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Description</th>
          <th colspan="2" style="font-family:'Gotham-Light'">Used to define text header and footer display options</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Properties \ functions</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Description</th>
      </tr>
      <tr>
          <td>CenterText</td>
          <td rowspan="3">string</td>
          <td rowspan="3">Set the text in centered/left/right of PDF header or footer. Can also merge metadata using strings placeholders: {page}, {total-pages}, {url}, {date}, {time}, {html-title}, {pdf-title}</td>
      </tr>
      <tr>
          <td>LeftText</td>
      </tr>
      <tr>
          <td>RightText</td>
      </tr>
      <tr>
          <td>DrawDividerLine</td>
          <td>Boolean</td>
          <td>Adds a horizontal line divider between the header/footer and the page content on every page of the PDF document.</td>
      </tr>
      <tr>
        <td>DrawDividerLineColor</td>
        <td>Color</td>
        <td>The color of the divider line specified for IronPdf.TextHeaderFooter.DrawDividerLine.</td>
      </tr>
      <tr>
          <td>Font</td>
          <td>PdfFont</td>
          <td>Font family used for the PDF document. Default is IronSoftware.Drawing.FontTypes.Helvetica.</td>
      </tr>
      <tr>
          <td>FontSize</td>
          <td>Double</td>
          <td>Font size in pixels.</td>
      </tr>
    </tbody>
  </table>
</div>

<hr class="separator">

## 7. Configure PDF Rendering Settings

Here, we'll explore how to set up the PDF rendering options to fine-tune the output of your PDF documents.

Here's the paraphrased section of the article, with URL paths accurately resolved against ironsoftware.com:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey"; // Set your license key
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer(); // Create a PDF renderer

// Configure the rendering options 
pdfRenderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.A4; // Set paper size to A4
pdfRenderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait; // Set paper orientation to portrait

// Generate PDF from HTML and save it
pdfRenderer.RenderHtmlFileAsPdf(@"testFile.html").SaveAs("GeneratedFile.pdf"); // Render and save the PDF
```

<hr class="separator">

## 8. Docker Integration with .NET Core Applications

Docker provides a comprehensive platform-as-a-service solution that leverages OS-level virtualization to deliver software in packages referred to as containers. These containers are isolated from each other, each bundling its own software, libraries, and configuration files, and can communicate via well-defined channels.

To deepen your understanding, check out this essential guide to [Docker and ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images). Moreover, further exploration on [.NET with Docker](https://docs.microsoft.com/en-us/dotnet/core/docker/introduction) and insights on [crafting containers for .NET Core applications](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container) are available to enhance your learning.

### Starting with Docker

To initiate your journey with Docker, visit the Docker website to [download and install Docker](https://www.docker.com/).

![Download Docker](https://ironpdf.com/img/tutorials/dot-net-core/40.png)

Begin by clicking 'Get Started'.

![Install Docker](https://ironpdf.com/img/tutorials/dot-net-core/41.png)

Proceed by selecting the download for Mac or Windows according to your operating system.

![Select Operating System](https://ironpdf.com/img/tutorials/dot-net-core/42.png)

Register for a free account and then log in.

![Login to Docker](https://ironpdf.com/img/tutorials/dot-net-core/43.png)

Download the appropriate version for Windows.

![Docker for Windows](https://ironpdf.com/img/tutorials/dot-net-core/44.png)

Follow through with the installation process.

![Installation Process](https://ironpdf.com/img/tutorials/dot-net-core/45.png)

A system restart may be necessary. Once your machine restarts, log back into Docker.

![Restart and Login](https://ironpdf.com/img/tutorials/dot-net-core/46.png)

You can test Docker installation by running the "hello-world" command in your command prompt or PowerShell:

```
Docker run hello-world
```

![Run Hello World](https://ironpdf.com/img/tutorials/dot-net-core/47.png)

Understanding Docker commands is crucial; here are a few to get you started:
- `Docker images` — List all available images on this machine
- `Docker ps` — List all running containers
- `Docker ps -a` — List all containers

### Embracing Linux Containers

Interact and manage your containers more effectively using proven strategies and best practices.

![Linux Integration](https://ironpdf.com/img/tutorials/dot-net-core/38.png)
![Effective Container Management](https://ironpdf.com/img/tutorials/dot-net-core/39.png)

This introduction to Docker within .NET Core applications should serve as a solid foundation as you venture into the world of containerization, laying the groundwork for enhanced development practices and application deployment.

### 8.1. Understanding Docker

Docker is a collection of platform-as-a-service products that utilize OS-level virtualization to distribute software in self-contained units known as containers. These containers are self-sufficient, each containing their own software, libraries, and configuration files. They are isolated from each other but can interact seamlessly through well-defined channels.

For more insights on integrating Docker with ASP.NET Core applications, you can visit this guide on [building .NET Docker images](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images).

We will proceed to practical applications with Docker, however, for a thorough introduction to Docker in the context of .NET, explore this [introductory guide to .NET and Docker](https://docs.microsoft.com/en-us/dotnet/core/docker/introduction). Moreover, to delve deeper into creating containers for .NET Core apps, refer to [this detailed documentation](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container).

Now, let’s dive into Docker and start crafting our containers.

### 8.2. Docker Installation Process

For Docker installation, you can visit the Docker website at [this link](https://www.docker.com/) to get started with the installation process.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/40.png" target="_blank">
<img src="/img/tutorials/dot-net-core/40.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Click to begin.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/41.png" target="_blank">
<img src="/img/tutorials/dot-net-core/41.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Click to download for both Mac and Windows systems.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/42.png" target="_blank">
<img src="/img/tutorials/dot-net-core/42.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Register for a complimentary account, followed by logging in.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/43.png" target="_blank">
<img src="/img/tutorials/dot-net-core/43.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

\[Download Docker for Windows\]\(https://ironsoftware.com/img/tutorials/dot-net-core/44.png\)

Initiate the installation of Docker.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/44.png" target="_blank">
<img src="/img/tutorials/dot-net-core/44.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

### Begin Docker Installation Process

Get started by setting up Docker on your system. This involves downloading the software from the Docker website, which is straightforward and user-friendly.

1. Access Docker's official site by navigating to [Install Docker](https://www.docker.com/).

   ![Navigate to Docker Website](https://ironpdf.com/img/tutorials/dot-net-core/40.png)

2. Opt to download the version compatible with your system, either for Mac or Windows.

   ![Choose system version](https://ironpdf.com/img/tutorials/dot-net-core/41.png)

3. After downloading, proceed by installing Docker. During the installation, you may need to sign up for a free account or log in if you already have one.

   ![Download and Install](https://ironpdf.com/img/tutorials/dot-net-core/42.png)

4. Upon completing the installation, a system restart might be required. Once your machine is up and running again, log into Docker to finalize the setup.

   ![Installation completion and restart](https://ironpdf.com/img/tutorials/dot-net-core/43.png)

5. With Docker installed, verify the installation by running the Docker "hello world" script either through the Windows command line or PowerShell:

   ```bash
   Docker run hello-world
   ```

   ![Run hello world](https://ironpdf.com/img/tutorials/dot-net-core/44.png)

After these steps, Docker will be successfully installed on your system, and you can start using it to containerize and manage your applications effectively.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/45.png" target="_blank">
<img src="/img/tutorials/dot-net-core/45.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Following the installation, your system will need to be restarted. Once rebooted, proceed to log in to Docker.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/46.png" target="_blank">
<img src="/img/tutorials/dot-net-core/46.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

You can initiate the Docker "hello world" example by launching either the Windows Command Prompt or PowerShell and entering the following command:

```bash
Docker run hello-world
```

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/47.png" target="_blank">
<img src="/img/tutorials/dot-net-core/47.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Here's a summary of the essential Docker commands you need to know:

- `Docker images` => Lists all Docker images currently installed on this system.
- `Docker ps` => Displays all containers that are currently running.
- `Docker ps -a` => Shows all containers, including those that are stopped.

### 8.3. Deploying on a Linux Container

<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/38.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/38.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/39.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/39.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/38.png" target="_blank">
<img src="/img/tutorials/dot-net-core/38.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/39.png" target="_blank">
<img src="/img/tutorials/dot-net-core/39.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## Handling Existing PDF Files in .NET Core

Working with existing PDF documents can be intricate, but leveraging IronPDF simplifies these processes, including operations on encrypted files. Below are steps on how to work with existing PDF documents using the IronPDF library.

### 9.1 Loading PDFs

Load either unencrypted or encrypted PDF files with ease using IronPDF:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

// Loading a standard PDF
PdfDocument standardPdf = PdfDocument.FromFile("sample.pdf");

// Loading a secure PDF requires a password
PdfDocument securePdf = PdfDocument.FromFile("secure_sample.pdf", "SecurePassword");
```

### 9.2 Combining Multiple PDFs

IronPDF allows the merging of several PDF files into a single document:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

var pdfList = new List<PdfDocument>
{
    PdfDocument.FromFile("file1.pdf"),
    PdfDocument.FromFile("file2.pdf"),
    PdfDocument.FromFile("file3.pdf")
};

using PdfDocument resultPdf = PdfDocument.Merge(pdfList);
resultPdf.SaveAs("combined.pdf");

// Cleaning up resources by disposing of PDFs
foreach (PdfDocument pdf in pdfList)
{
    pdf.Dispose();
}
```

Additionally, append a PDF at the end of an existing one or insert a PDF at a specified index within another PDF:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument basePdf = PdfDocument.FromFile("base.pdf");
PdfDocument appendPdf = PdfDocument.FromFile("append.pdf");

// Append another PDF to the existing one
basePdf.AppendPdf(appendPdf);
basePdf.SaveAs("extended.pdf");

// Inserting a PDF at a specific index
basePdf.InsertPdf(appendPdf, 0);
basePdf.SaveAs("modified.pdf");
```

### 9.3 Applying Headers and Footers

Enhance your PDFs by adding custom headers and footers, utilizing text or rich HTML content:

**Adding headers to an existing PDF:**

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdfDoc = PdfDocument.FromFile("example.pdf");
TextHeaderFooter textHeader = new TextHeaderFooter
{
    CenterText = "Company Header",
    LeftText = "{date} {time}",
    RightText = "{page} of {total-pages}",
    DrawDividerLine = true,
    FontSize = 12
};

pdfDoc.AddTextHeaders(textHeader);
pdfDoc.SaveAs("withHeader.pdf");

HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = "<span style='color:navy;'>Page {page} of {total-pages}</span>",
    DrawDividerLine = true,
    MaxHeight = 15 // in millimeters
};

pdfDoc.AddHtmlFooters(htmlFooter);
pdfDoc.SaveAs("complete.pdf");
```

This section demonstrates the powerful capabilities IronPDF offers for managing and manipulating existing PDF files within .NET Core applications, further detailed by numerous custom options available for text and HTML headers and footers.

### 9.1 Opening Existing PDF Documents

Just as you can generate PDFs from URLs and HTML (whether as text or complete files), you can also manipulate pre-existing PDF documents.

Here's how you can open both standard and encrypted PDFs using a password:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

// Loading an unsealed PDF document
PdfDocument regularPdf = PdfDocument.FromFile("testFile.pdf");

// Loading a secured PDF document using a password
PdfDocument passwordProtectedPdf = PdfDocument.FromFile("testFile2.pdf", "MyPassword");
```

### 9.2 Combine Multiple PDFs into One

The following code snippet demonstrates how to combine several PDF files into a single PDF document:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

List<PdfDocument> pdfDocuments = new List<PdfDocument>();
pdfDocuments.Add(PdfDocument.FromFile("1.pdf"));
pdfDocuments.Add(PdfDocument.FromFile("2.pdf"));
pdfDocuments.Add(PdfDocument.FromFile("3.pdf"));

using PdfDocument combinedPdf = PdfDocument.Merge(pdfDocuments);
combinedPdf.SaveAs("combinedFile.pdf");

foreach (PdfDocument pdf in pdfDocuments)
{
    pdf.Dispose();
}
```

This method uses `PdfDocument.Merge()` to consolidate multiple PDF files. It then saves the combined PDF as `"combinedFile.pdf"`. Ensure all individual PDF files are properly disposed of after merging to free up resources.

```cs
// Assign your license key
IronPdf.License.LicenseKey = "YourLicenseKey";

// Create a list of PdfDocument objects
List<PdfDocument> pdfList = new List<PdfDocument>();
pdfList.Add(PdfDocument.FromFile("1.pdf"));
pdfList.Add(PdfDocument.FromFile("2.pdf"));
pdfList.Add(PdfDocument.FromFile("3.pdf"));

// Merge all PDFs into a single document
using (PdfDocument mergedPdf = PdfDocument.Merge(pdfList))
{
    // Save the merged PDF to a new file
    mergedPdf.SaveAs("mergedFile.pdf");
}

// Properly dispose all individual PDF documents to free resources
foreach (PdfDocument singlePdf in pdfList)
{
    singlePdf.Dispose();
}
```

Here is a revised version of the section you provided, with relative URL paths resolved against `ironpdf.com`:

---
Append an additional PDF to an existing file with the following steps:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdf = PdfDocument.FromFile("1.pdf");
PdfDocument pdf2 = PdfDocument.FromFile("2.pdf");

pdf.AppendPdf(pdf2);
pdf.SaveAs("appendedFile.pdf");
```

This code snippet demonstrates how to append the contents of one PDF file, `pdf2`, to another, `pdf`, using IronPDF's PDF document management features.

```cs
// Set your license key to unlock IronPdf features
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load two PDF files from the local storage
PdfDocument originalPdf = PdfDocument.FromFile("1.pdf");
PdfDocument additionalPdf = PdfDocument.FromFile("2.pdf");

// Append the second PDF to the end of the first PDF
originalPdf.AppendPdf(additionalPdf);
// Save the combined PDF to a new file
originalPdf.SaveAs("appendedFile.pdf");
```

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument mainPdf = PdfDocument.FromFile("1.pdf");
PdfDocument insertablePdf = PdfDocument.FromFile("2.pdf");

// Inserts the second PDF at the beginning of the first PDF
mainPdf.InsertPdf(insertablePdf, 0);

mainPdf.SaveAs("InsertIntoSpecificIndex.pdf");
```

Here's the paraphrased section with the relative URL paths resolved:

```cs
// Initialize the licensing key for your IronPDF installation.
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load the primary PDF document.
PdfDocument mainPdf = PdfDocument.FromFile("1.pdf");

// Load another PDF document to insert.
PdfDocument secondaryPdf = PdfDocument.FromFile("2.pdf");

// Insert the secondary PDF at the beginning of the main PDF.
mainPdf.InsertPdf(secondaryPdf, 0);

// Save the updated document to a new file.
mainPdf.SaveAs("InsertIntoSpecificIndex.pdf");
```

### 9.3 Incorporating Headers or Footers into PDF Documents

It's possible to insert headers and footers either into an existing PDF document or during the PDF creation process from HTML or URL sources.

There are primarily two classes available for adding headers and footers into your PDFs:

- `TextHeaderFooter`: This class allows you to add plain text into the header or footer sections.
- `HtmlHeaderFooter`: Utilize this class to incorporate more complex HTML content and images in headers or footers.

Let's explore how you can utilize these classes to add headers and footers, either to existing PDFs or while generating them.

**9.3.1 Adding Headers to an Existing PDF**

Here's how you can open an existing PDF file and apply textual and HTML headers and footers using the `AddTextHeaders` and `AddHtmlFooters` methods:

```cs
// Set the license key for IronPDF
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load a PDF document from the file system
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Create a text-based header configuration
TextHeaderFooter header = new TextHeaderFooter()
{
    CenterText = "Pdf Header", // Centered text
    LeftText = "{date} {time}", // Left text showing date and time
    RightText = "{page} of {total-pages}", // Right text showing page count
    DrawDividerLine = true, // Draw a line under the header
    FontSize = 10 // Set the font size
};

// Add the configured text header to the PDF
pdf.AddTextHeaders(header);

// Save the PDF with the text header
pdf.SaveAs("withHeader.pdf");

// Prepare an HTML footer
HtmlHeaderFooter footer = new HtmlHeaderFooter()
{
    HtmlFragment = "<span style='text-align:right'> page {page} of {totalpages}</span>", // Right-aligned text showing page numbers
    DrawDividerLine = true, // Include a dividing line above the footer
    MaxHeight = 10 // Maximum height of the footer in mm
};

// Add the configured HTML footer to the PDF
pdf.AddHtmlFooters(footer);

// Save the final PDF with both header and footer
pdf.SaveAs("withHeaderAndFooters.pdf");
```

**9.3.2 Adding Headers and Footers to a Newly Created PDF**

In the example provided below, we demonstrate the process of generating a new PDF from an HTML file and how to incorporate a header and footer using specific rendering settings:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.TextHeader = new TextHeaderFooter()
{
    CenterText = "Pdf Header",
    LeftText = "{date} {time}",
    RightText = "{page} of {total-pages}",
    DrawDividerLine = true,
    FontSize = 10
};

renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<span style='text-align:right'> page {page} of {totalpages}</span>",
    DrawDividerLine = true,
    MaxHeight = 10
};

PdfDocument pdf = renderer.RenderHtmlFileAsPdf("test.html");
pdf.SaveAs("generatedFile.pdf");
```

```cs
// Set your IronPDF license key to activate the product
IronPdf.License.LicenseKey = "YourLicenseKey";

// Create a new instance of ChromePdfRenderer to render HTML to PDF
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Configure text-based headers by utilizing the TextHeaderFooter class
pdfRenderer.RenderingOptions.TextHeader = new TextHeaderFooter
{
    CenterText = "Pdf Header", // Text displayed at the center of the header
    LeftText = "{date} {time}", // Date and time placeholders at the left
    RightText = "{page} of {total-pages}", // Page information at the right
    DrawDividerLine = true, // Draws a line beneath the header
    FontSize = 10 // The font size for the header text
};

// Setup HTML footers using the HtmlHeaderFooter class, which allows for HTML content
pdfRenderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
{
    HtmlFragment = "<span style='text-align:right'> page {page} of {totalpages}</span>", // HTML content for the footer
    DrawDividerLine = true, // Adds a dividing line above the footer
    MaxHeight = 10 // Maximum height of the footer
};

// Render the HTML file into a PDF document
PdfDocument pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("test.html");

// Save the generated PDF to a file
pdfDocument.SaveAs("generatedFile.pdf");
```

<hr class="separator">

## 10. Enhance PDF Security and Confidentiality

You have the ability to safeguard your PDF by setting a password and configuring document security settings to restrict actions such as copying and printing.

Here is the paraphrased version of the provided code snippet, with resolved URLs for images and links as requested:

```cs
// Assign a license key to IronPDF 
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load an existing PDF from the file system
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Modify the PDF metadata
pdf.MetaData.Author = "john smith";
pdf.MetaData.Keywords = "SEO, Friendly";
pdf.MetaData.ModifiedDate = DateTime.Now;

// Configure security settings for the PDF
// This code segment sets the PDF to read-only, preventing copy, paste, and printing actions
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key"); // 'secret-key' is treated as the owner password
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Set or change the encryption password for the document
pdf.Password = "123";
// Save the updated PDF with the new settings
pdf.SaveAs("secured.pdf");
```

<hr class="separator">

## 11. Sign PDF Documents Digitally

The process of digitally signing a PDF document can be executed using the following steps:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load the PDF to be signed
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Digitally sign the PDF
pdf.Sign(new PdfSignature("cert123.pfx", "password"), IronPdf.Signing.SignaturePermissions.Default);

// Save the signed PDF
pdf.SaveAs("signed.pdf");
```

For more granular control over the signing process, you can use the example below which includes optional settings:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load the PDF
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Setup the digital signature
IronPdf.Signing.PdfSignature signature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");

// Optional: Configure additional properties of the signature
signature.SigningContact = "support@ironsoftware.com";
signature.SigningLocation = "Chicago, USA";
signature.SigningReason = "To demonstrate digital signing";

// Apply the signature to the PDF
pdf.Sign(signature);

// Save the digitally signed PDF
pdf.SaveAs("customSigned.pdf");
```

These methods offer a reliable and secure way to add digital signatures to your PDFs, enhancing their authenticity and integrity.

Below is your paraphrased section, where the relative URL paths have been resolved and the code snippet has been slightly modified to maintain functionality but differ from the original version:

-----
```cs
// Assign your license key for IronPdf
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load a PDF from file
PdfDocument document = PdfDocument.FromFile("testFile.pdf");

// Digitally sign the PDF with the specified certificate and permissions
PdfSignature signature = new PdfSignature("cert123.pfx", "password");
document.Sign(signature, IronPdf.Signing.SignaturePermissions.Default);

// Save the signed PDF with a new file name
document.SaveAs("signedDocument.pdf");
```

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
IronPdf.Signing.PdfSignature signature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");

// Optional customization for the signing process
signature.SigningContact = "support@ironsoftware.com";
signature.SigningLocation = "Chicago, USA";
signature.SigningReason = "Demonstrating PDF signing capabilities";

// Apply the digital signature to the PDF
pdf.Sign(signature);
```

Here's the paraphrased content:

```cs
// Set your license key
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load an existing PDF file
PdfDocument existingPdf = PdfDocument.FromFile("testFile.pdf");

// Create a new digital signature using a specified certificate
IronPdf.Signing.PdfSignature digitalSignature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");

// You can set additional properties on the signature
digitalSignature.SigningContact = "support@ironsoftware.com";
digitalSignature.SigningLocation = "Chicago, USA";
digitalSignature.SigningReason = "Demonstration of PDF signing";

// Apply the digital signature to the PDF
existingPdf.Sign(digitalSignature);
```

## 12. Extract Content from PDFs

The robust IronPDF library not only supports the creation and manipulation of PDF files but also excels in extracting text and images from PDF documents. Below are some practical examples showing how to retrieve content from a PDF using IronPDF.

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Extract all textual content from the PDF
var fullText = pdf.ExtractAllText();

// Extract text from a specific page in the PDF
var pageText = pdf.ExtractTextFromPage(0);

// Retrieve all images contained in the entire PDF
var imagesInPdf = pdf.ExtractAllImages();

// Retrieve images from a specific page in the PDF
var imagesOnPage = pdf.ExtractImagesFromPage(0);
```

### 12.1. Convert PDF Pages to Images

In addition to text and image extraction, IronPDF allows you to rasterize PDF pages into image formats. Here’s how you can convert specified PDF pages into images:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Define a list of pages to convert
List<int> pagesToConvert = new List<int>() { 1, 2 };

// Rasterize specified pages into PNG images
pdf.RasterizeToImageFiles("output*.png", pagesToConvert);
```

<b>Extract text and images</b>

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

// Extract all text from the PDF
var extractedText = pdf.ExtractAllText();

// Extract text from a specific page, e.g., page 1
var pageText = pdf.ExtractTextFromPage(1);

// Retrieve all images from the PDF
var imagesInPdf = pdf.ExtractAllImages();

// Extract images from a particular page, e.g., page 1
var imagesOnFirstPage = pdf.ExtractImagesFromPage(1);
```

Here's the paraphrased content for the provided section:

```cs
// Assign your license key to activate IronPDF features
IronPdf.License.LicenseKey = "YourLicenseKey";

// Open a PDF from a file path
PdfDocument document = PdfDocument.FromFile("testFile.pdf");

// Extract text from the entire document
document.ExtractAllText(); // This will extract all text from the PDF
// Get text from the first page of the document
document.ExtractTextFromPage(0); // This pulls text from the first page specifically

// Retrieve all images from the entire PDF
var imagesInDocument = document.ExtractAllImages();

// Fetch images from the first page only
var imagesOnFirstPage = document.ExtractImagesFromPage(0);
```

In this version, comments are expanded for clarity, variable names are slightly altered to enhance readability, and the code structure remains intact but with simplified presentation.

### 12.1 Converting PDF Pages to Images

Transform PDF documents into image files with the following approach:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";
PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");

List<int> pageNumbers = new List<int>() { 1, 2 };

// Rasterize selected pages to image files (*.png format)
pdf.RasterizeToImageFiles("*.png", pageNumbers);
```

Here's the paraphrased section with updated paths for images and links resolved to `ironpdf.com`.

```cs
// Assign the license key to activate IronPDF
IronPdf.License.LicenseKey = "YourLicenseKey";

// Load a PDF document into the application
PdfDocument document = PdfDocument.FromFile("testFile.pdf");

// List of pages to convert from PDF to image (PNG format)
List<int> pagesToConvert = new List<int>() { 1, 2 };

// Convert specified pages to image files
document.RasterizeToImageFiles("*.png", pagesToConvert);
```

<hr class="separator">

## 13. Adding Watermarks to PDF Documents

Here's how you can add watermarks to PDF pages using IronPDF:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Implement watermark
pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);
pdf.SaveAs("Watermarked.pdf");
```

To have more control over watermarking, consider using the `HTMLStamper` class:

```cs
IronPdf.License.LicenseKey = "YourLicenseKey";

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<div>test text </div>");

// Set up HTML stamper
HtmlStamper backgroundStamp = new HtmlStamper()
{
    Html = "<h2 style='color:red'>copyright 2018 ironpdf.com",
    MaxWidth = new Length(20),
    MaxHeight = new Length(20),
    Opacity = 50,
    Rotation = -45,
    IsStampBehindContent = true,
    VerticalAlignment = VerticalAlignment.Middle
};

pdf.ApplyStamp(backgroundStamp);
pdf.SaveAs("stamped.pdf");
```

Here is the paraphrased section of the article, with relative URL paths resolved to `ironpdf.com`:

```cs
// Set your IronPDF license key to unlock full features
IronPdf.License.LicenseKey = "YourLicenseKey";

// Initialize the PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Create a PDF from a URL
PdfDocument document = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Add a red 'SAMPLE' watermark to the center of each page
document.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);

// Save the watermarked PDF to a file
document.SaveAs("Watermarked.pdf");
```

Watermarking offers limited customization possibilities. For more extensive capabilities, consider using the **HTMLStamper** class.

Here's a paraphrased version of the provided C# code snippet from the IronPDF article, with resolved relative URL paths from ironpdf.com:

```cs
// Sets the license key for IronPdf
IronPdf.License.LicenseKey = "YourLicenseKey";

// Initialize a new instance of ChromePdfRenderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
// Render HTML as a PDF document
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<div>sample text</div>");

// Setting up an HTML stamper
HtmlStamper stamp = new HtmlStamper {
    Html = "<h2 style='color:red'>copyright 2018 ironpdf.com",
    MaxWidth = new Length(20),
    MaxHeight = new Length(20),
    Opacity = 50, // Set the opacity to 50%
    Rotation = -45, // Rotate the stamp by -45 degrees
    IsStampBehindContent = true, // Place the stamp behind the PDF content
    VerticalAlignment = VerticalAlignment.Middle // Align vertically in the middle
};

// Apply the HTML stamper to the PDF
document.ApplyStamp(stamp);
// Save the PDF with the applied stamp
document.SaveAs("stamped.pdf");
```

This code sets up a PDF document renderer, creates a simple HTML content PDF, applies a customized watermark using 'HtmlStamper', and finally saves the stamped PDF document.

<hr class="separator">

<h4 class="tutorial-segment-title">Tutorial Quick Access</h4>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/brand-visual-studio.svg">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Get the Source Code</h3>
      <p>Access all the source code found in this tutorial as a Visual Studio project ZIP file, easy to use and share for your project. </p>
      <a class="btn btn-white3" href="/downloads/assets/tutorials/core-pdf/PdfCoreTutorial.zip">
        <i class="fa fa-cloud-download"></i> Get the Code</a>
      </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-8">
      <h3>GitHub Tutorial Access</h3>
      <p> Explore this tutorial and many more via GitHub. Using the projects and source code is the best way to learn and apply it to your own PDF .NET Core needs and use cases. </p>
      <a class="doc-link" href="https://github.com/iron-software/tutorials/tree/master/IronPdf/CoreTutorial" target="_blank">Generate PDFs in .NET Core Tutorial<i class="fa fa-chevron-right"></i></a>
    </div>
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/github-icon.svg">
      </div>
    </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img alt="" class="img-responsive add-shadow" src="/img/svgs/html-to-pdf-icon.svg" width="214" height="141">
      </div>
    </div>
    <div class="col-sm-8">
      <h3>Keep the PDF CSharp Cheat Sheet</h3>
      <p>Develop PDFS in your .NET applications using our handy reference document. Providing quick access to common functions and examples for generating and editing PDFs in C# and VB.NET, this shareable tool helps you save time and effort getting started with IronPDF and common PDF requirements in your project. </p>
      <a class="btn btn-white3" target="_blank" href="/csharp-pdf.pdf">
        <i class="fa fa-cloud-download"></i> Keep the Cheat Sheet</a>
      </div>
  </div>
</div>

<div class="tutorial-section">
  <div class="row">
    <div class="col-sm-8">
      <h3>More Documentation</h3>
      <p>Read the IronPDF API Reference, which thoroughly presents the details of all the features in IronPDF plus namespaces, classes, methods fields and enums.</p>
      <a class="doc-link" href="/object-reference/api/IronPdf.html" target="_blank">API Reference Documentation<i class="fa fa-chevron-right"></i></a>
    </div>
    <div class="col-sm-4">
      <div class="tutorial-image">
        <img style="max-width: 110px; width: 100px; height: 140px;" alt="" class="img-responsive add-shadow" src="/img/svgs/documentation.svg" width="100" height="140">
      </div>
    </div>
  </div>
</div>

