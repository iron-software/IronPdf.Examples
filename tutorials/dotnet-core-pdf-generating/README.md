# HTML to PDF Conversion in .NET Core (Updated 2024 Tutorial)

***Based on <https://ironpdf.com/tutorials/dotnet-core-pdf-generating/>***


## .NET Core PDF Creation

Generating PDF files in .NET Core often presents a complex challenge. This includes efforts to convert MVC views, HTML files, and online web pages to PDF within ASP.NET MVC projects. This updated 2024 guide utilizes IronPDF to simplify these tasks, offering detailed instructions for a variety of PDF generation requirements in .NET.

**IronPDF further provides [enhanced HTML debugging with Chrome for flawless PDF results](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).**

<hr class="separator">

<h4 class="tutorial-segment-title">Tutorial Overview</h4>

Completing this guide will empower you to:

- Convert various sources such as URLs, HTML content, and MVC views into PDF format.
- Utilize advanced configuration settings for tailored PDF outputs.
- Deploy your applications across both Linux and Windows platforms.
- Manipulate PDF documents by adding headers, footers, merging documents, and more.
- Leverage Docker containers in your workflows.

This comprehensive set of capabilities will address a broad spectrum of PDF conversion needs in .NET Core projects.

<hr class="separator">

<h4 class="tutorial-segment-title">Beginning Steps</h4>

## 1. Installing the IronPDF Library for Free

IronPDF is compatible with all .NET project types, including Windows applications, ASP.NET MVC, and .NET Core applications.

There are two methods to incorporate IronPDF into your project, either via the NuGet package manager within the Visual Studio environment or through command-line operations.

<h3>Installation via NuGet</h3>

Incorporating IronPDF into your project through NuGet can be accomplished using either the GUI or the console:

<p class="list-decimal">1.1.1 Via NuGet Package Manager GUI</p>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/1.png" target="_blank">
<span class="no-link-style">1- Right-click on the project name -> Select 'Manage NuGet Packages'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/1.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/2.png" target="_blank">
<span class="no-link-style">2- Navigate to the 'Browse' tab, search for 'IronPdf' and select 'Install'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/2.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/3.png" target="_blank">
<span class="no-link-style">3- Confirm the installation by clicking 'Ok'</span>
img src="https://ironpdf.com/img/tutorials/dot-net-core/3.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/4.png" target="_blank">
<span class="no-link-style">4- Installation complete!</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/4.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<p class="list-decimal">1.1.2 Via NuGet Package Console Manager</p>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/5.png" target="_blank">
<span class="no-link-style">1- Access through 'Tools' -> 'NuGet Package Manager' -> 'Package Manager Console'</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/5.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/6.png" target="_blank">
<span class="no-link-style">2- Execute the command: `Install-Package IronPdf`</span>
<img src="https://ironpdf.com/img/tutorials/dot-net-core/6.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

<h4 class="tutorial-segment-title">How To Tutorials</h4>

## Generating PDFs with .NET Core

Producing PDF documents in .NET Core environments often involves complex procedures. Managing PDF generation in ASP.NET MVC, along with converting MVC views, HTML content, and websites into PDF files, presents several hurdles. This guide introduces the IronPDF library as a solution to streamline these processes, offering comprehensive instructions to address a variety of PDF generation requirements in .NET.

**IronPDF enhances your workflow by enabling [Chrome-based HTML debugging for flawless PDF results](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/).**

<hr class="separator">

<h4 class="tutorial-segment-title">Overview</h4>

Upon completing this tutorial, you will gain the ability to:

- Execute PDF conversions from various sources such as URLs, HTML content, and MVC views.
- Utilize advanced configuration options for diverse PDF output settings.
- Implement your projects on both Linux and Windows platforms.
- Manage PDF documents with capabilities like manipulation, adding headers and footers, merging multiple files, and applying stamps.
- Utilize Docker for containerized application management.

These extensive capabilities will enhance your projects by integrating comprehensive .NET Core HTML to PDF functionalities.

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## Installation of the IronPDF Library

IronPDF can be seamlessly integrated across various .NET project frameworks including traditional Windows applications, ASP.NET MVC, and .NET Core applications.

There are two primary methods to include the IronPDF library into your project: either directly through the Visual Studio environment using NuGet, or using a command line interface via the package manager console.

<h3>Install using NuGet</h3>

Integrating the IronPDF library into your project can be done through two major pathways in NuGet: either by utilizing the graphical interface of the NuGet Package Manager or by issuing commands through the Package Manager Console. Here's how to accomplish both tasks:

### Adding IronPDF via NuGet Package Manager Interface

1. **Access NuGet Package Manager:** Right-click on your project's name in the solution explorer and select 'Manage NuGet Packages'.
2. **Search for IronPDF:** Navigate to the 'Browse' tab, enter "IronPdf" in the search bar, and hit Install to add the library to your project.
3. **Confirmation:** Once the installation is complete, you'll need to confirm the action by clicking 'OK', then the setup for IronPDF is done!

### Using the Package Manager Console for Installation

1. **Open the Console:** Go to 'Tools' > 'NuGet Package Manager' > 'Package Manager Console'.
2. **Install Command:** Type in `Install-Package IronPdf` and press Enter to execute the command, initiating the installation of the IronPDF library into your project.

By following either of these pathways, you can easily add IronPDF to your .NET project and start harnessing its extensive PDF functionality.

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

To proceed with this example, we will develop a new Asp.NET MVC Project by following these steps:

- **Step 1:** Open Visual Studio.
    - ![Step 1 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/7.png)
- **Step 2:** Choose 'Create new project'.
    - ![Step 2 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/8.png)
- **Step 3:** Select 'Console App (.NET Core)' from the available project types.
    - ![Step 3 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/9.png)
- **Step 4:** Name your project "ConvertUrlToPdf" and click 'Create'.
    - ![Step 4 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/10.png)
- **Step 5:** A new console application is now ready.
    - ![Step 5 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/11.png)
- **Step 6:** Include IronPdf by selecting 'Add IronPdf' and then clicking 'Install'.
    - ![Step 6 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/12.png)


Now start adding the initial code to convert the main page of Wikipedia into a PDF:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section1
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
            pdf.SaveAs("wiki.pdf");
        }
    }
}
```

After writing the code:

- **Step 8:** Execute the application and review the generated PDF file, 'wiki.pdf'.
    - ![Step 8 Visual](https://ironsoftware.com/img/tutorials/dot-net-core/14.png)

This process not only provides a straightforward path to create a PDF from a website but also demonstrates the powerful capabilities of IronPDF within .NET Core applications.

<b>Sample: ConvertUrlToPdf console application</b>
<br>
<br>

Here's a rephrased version of the specific section:

-----
Begin your new ASP.NET MVC project by following these instructions:

1. Launch Visual Studio.
   ![Start Visual Studio](https://ironpdf.com/img/tutorials/dot-net-core/7.png)
2. Select `Create new project`.
   ![Create new project](https://ironpdf.com/img/tutorials/dot-net-core/8.png)
3. Choose `Console App (.NET Core)`.
   ![Select Console App (.NET Core)](https://ironpdf.com/img/tutorials/dot-net-core/9.png)
4. Name your application "ConvertUrlToPdf" and then click `create`.
   ![Name and create project](https://ironpdf.com/img/tutorials/dot-net-core/10.png)
5. You will now see that your console application has been set up.
   ![Console application setup complete](https://ironpdf.com/img/tutorials/dot-net-core/11.png)
6. Add IronPdf to your project by clicking install.
   ![Add IronPdf](https://ironpdf.com/img/tutorials/dot-net-core/12.png)
   ![Continue installation](https://ironpdf.com/img/tutorials/dot-net-core/13.png)
7. Begin coding by including a few lines to render the main page of the Wikipedia website into a PDF.
8. Execute the program and inspect the newly created `wiki.pdf`.
   ![Check the PDF](https://ironpdf.com/img/tutorials/dot-net-core/14.png)

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

Here's a paraphrased version of the provided .NET code snippet, with the relative URL paths resolved:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class ExampleSection
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            PdfDocument document = pdfRenderer.RenderUrlAsPdf("https://www.wikipedia.org/");
            document.SaveAs("wiki.pdf");
        }
    }
}
```

This revised version maintains the same functionality and logic as the original snippet, but with some variable names and comments altered for a fresher perspective.

<p class="list-decimal"></p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/14.png" target="_blank">
<span class="no-link-style">8- Run and check created file wiki.pdf</span>
<img src="/img/tutorials/dot-net-core/14.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## 3. Convert .NET Core HTML to PDF

For transforming HTML into a PDF within .NET Core applications, IronPDF offers two primary approaches:

1. Directly render a string containing HTML.
2. Utilize a path to an HTML file stored on your system and render it.

### Directly Rendering HTML Strings

Here's an example showing how to convert an HTML string to a PDF document:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section2
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
            pdf.SaveAs("ExamplePdfFromString.pdf");
        }
    }
}
```

When rendered, this code will produce a PDF displaying the HTML content, the location of which is indicated below.

![Rendered PDF Sample](https://ironpdf.com/img/tutorials/dot-net-core/15.png)

<p class="list-decimal">
<b>Sample: ConvertHTMLToPdf Console application</b>
<br>
<br>
  <span class="list-description">

1- Write HTML directly into a string, then convert it into a PDF.  
2- Save HTML into a file, and then use IronPDF to convert that file into a PDF.  

Here's an illustration of the code required to render HTML content as a PDF:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section2
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            pdf.SaveAs("HtmlString.pdf");
        }
    }
}
```

The generated PDF from the above operation is displayed in the following image:

![](https://ironpdf.com/img/tutorials/dot-net-core/15.png)

<span class="list-description">

Here's the paraphrased section with resolved relative URL paths:

-----
1. Craft the HTML content directly in a string and use that for rendering.<br>

2. Alternatively, save the HTML content to a file, then provide the file path to IronPDF for rendering.<br>

</span>
    <br>

To illustrate the rendering of an HTML string into a PDF, the following example provides a code snippet:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section2
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
            pdf.SaveAs("RenderedHtmlString.pdf");
        }
    }
}
```

In this code, a short HTML string is transformed into a PDF file titled `RenderedHtmlString.pdf`. This process utilizes IronPDF's `ChromePdfRenderer` class to manage the rendering seamlessly.

</span>
</p>

Here's the paraphrased section:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section2
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";  // Set your license key
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();  // Create a PDF renderer
            // Generate a PDF from HTML string
            PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
            document.SaveAs("OutputHtmlString.pdf");  // Save the PDF to a file
        }
    }
}
```

<p class="list-decimal">
  <span class="list-description">And the resulting PDF will look like this.</span>
</p>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/15.png" target="_blank">
<img src="/img/tutorials/dot-net-core/15.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## 4. Convert MVC View to PDF

**Example Project: TicketsApps .NET Core MVC Application**

This section presents a practical example by creating an online ticketing system where users can book tickets and download them as PDFs.

The project development will follow these key phases:

- [Initiate New Project](#anchor-create-project)
- [Establish Client Data Model](#anchor-add-client-model)
- [Define Client Services (Add, Display)](#anchor-add-client-services)
- [Formulate Ticket Booking Interface](#anchor-design-ticket-booking-page)
- [Confirm and Store Booking Details](#anchor-validate-and-save-the-booking-information)
- [Facilitate Ticket Download in PDF Format](#anchor-download-pdf-ticket)

### Setting up a New Project

1. Select the "ASP.NET Core Web App (Model-View-Controller)" project type.

<img src="/img/tutorials/dot-net-core/16.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

Below is the revised version of the selected section with updated URL paths and a paraphrased content:

### Naming the Project

Set the project's name as "TicketsApps."

![Project Name Setting](https://ironpdf.com/img/tutorials/dot-net-core/17.webp "Naming the project in the setup wizard")

<img src="/img/tutorials/dot-net-core/17.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

Rephrased Section:
-----
 3. Utilize .NET 8, incorporating Linux Docker support. Modify the Dockerfile by switching from "USER app" to "USER root" to confirm that the library has adequate permissions.

<img src="/img/tutorials/dot-net-core/18.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

4. Your project setup is now complete.

<img src="/img/tutorials/dot-net-core/19.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Setting Up the Client Model

1. Right-click on the "Models" folder in your project structure and select the option to add a new class.

<img src="/img/tutorials/dot-net-core/20.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

2. Give the model the name "ClientModel" and proceed by clicking on add.
```

<img src="/img/tutorials/dot-net-core/21.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section3
    {
        public void Run()
        {
            public class ClientModel
            {
                [Required]
                public string Name { get; set; }
                [Required]
                public string Phone { get; set; }
                [Required]
                public string Email { get; set; }
            }
        }
    }
}
```

Here, we enhance the `ClientModel` by adding essential fields such as 'name', 'phone', and 'email', ensuring each field is mandatory with the application of the `[Required]` attribute. This guarantees that all instances of `ClientModel` must include valid entries for these attributes before they can be processed further in the application.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfCreation
{
    public class MemberSection
    {
        public void Execute()
        {
            public class UserModel
            {
                [Required]
                public string UserName { get; set; }
                [Required]
                public string PhoneNumber { get; set; }
                [Required]
                public string EmailAddress { get; set; }
            }
        }
    }
}
```

### Implementing Client Services

1. Start by creating a directory named `services`.

2. Within this folder, create a class file called `ClientServices`.

3. Inside the `ClientServices` class, declare a static instance of the `ClientModel` to function as a data repository.

4. Define two methods within this class:
   - One method named `AddClient` to store client details into the repository.
   - Another method named `GetClient` to fetch client details from the repository.

Here's the paraphrased section with updated code comments and slight changes in code structure for clarity and distinction:

```cs
using IronPdf;

// Establish a namespace tailored for managing various client services
namespace IronPdfCorePdfGeneration
{
    public class ClientServicesManager
    {
        // Initialization of static field to hold client data
        private static ClientModel storedClientData;

        // Execute relevant functionalities
        public void ExecuteServices()
        {
            // Internal class to handle client services operations
            public class ClientServices
            {
                // Method to store a client model
                public static void StoreClient(ClientModel client)
                {
                    storedClientData = client;
                }

                // Method to retrieve stored client model
                public static ClientModel RetrieveClient()
                {
                    return storedClientData;
                }
            }
        }
    }
}
``` 

This updated code maintains the functionality of the original while introducing different naming and structural layouts to improve understanding and management of the client data within a hypothetical .NET Core application using the IronPDF library.

### Constructing the Ticket Booking Interface

1. In the Solution Explorer, right-click on the "Controllers" folder and choose to add a new controller.

<img src="/img/tutorials/dot-net-core/22.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

2. Assign the name "BookTicketController" to it.

![controller naming](https://ironpdf.com/img/tutorials/dot-net-core/23.webp)

<img src="/img/tutorials/dot-net-core/23.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

3. Right-click on the index method (which we refer to as the action) and select "Add View."

<img src="/img/tutorials/dot-net-core/24.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Add the "index" View

1. In the Solution Explorer, right-click on the "Controllers" folder and choose to add a new controller.

![Add Controller](https://ironpdf.com/img/tutorials/dot-net-core/22.webp)
*Initiate adding a controller in Visual Studio*

2. Name the controller "BookTicketController".

![Name Controller](https://ironpdf.com/img/tutorials/dot-net-core/23.webp)
*Setting the name for the controller*

3. Navigate to the action method in the controller, usually the `index` method, right-click and select "Add View".

![Add View](https://ironpdf.com/img/tutorials/dot-net-core/24.webp)
*Adding a view from the controller method*

4. Create a view named "index" to correspond with the controller action.

![Create index View](https://ironpdf.com/img/tutorials/dot-net-core/25.webp)
*Creating the index view in the MVC structure*

The newly created View "index" serves as the primary interface for interacting with the application feature that the "BookTicketController" controls. In essence, this facilitates the user's interaction for booking tickets through a structured and user-friendly GUI, integrated into your .NET Core application.

<img src="/img/tutorials/dot-net-core/25.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

Here's the paraphrased section:

### Update the HTML Template

Follow these steps to revise the HTML for your booking form:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section5
    {
        public void Run()
        {
            @model IronPdfMVCHelloWorld.Models.ClientModel
            @{
              ViewBag.Title = "Book Your Tickets";
            }
            <h2>Booking Form</h2>
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
                    <input type="submit" value="Submit" class="btn btn-primary"/>
                  </div>
                </div>
              </div>
            }
        }
    }
}
```

This revised section provides clear instructions on how to set up the HTML for a booking form using MVC pattern in your application.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section5
    {
        public void Run()
        {
            @model IronPdfMVCHelloWorld.Models.ClientModel
            @{ 
                ViewBag.Title = "Book Ticket"; // Set the title via ViewBag 
            }
            <h2>Index</h2> // The main header for this view 
            @using (Html.BeginForm()) // Create a form using Html helper
            {
                <div class="form-horizontal"> // Form uses horizontal layout
                    @Html.ValidationSummary(true, "", new { @class = "text-danger" }) // Display validation summary
                    <div class="form-group"> // Name input field
                        @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }) // Label for the name
                        <div class="col-md-10">
                            @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }) // Editor for name entry
                            @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }) // Validation message for name
                        </div>
                    </div>
                    <div class="form-group"> // Phone input field
                        @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }) // Label for the phone
                        <div class="col-md-10">
                            @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }) // Editor for phone entry
                            @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }) // Validation message for phone
                        </div>
                    </div>
                    <div class="form-group"> // Email input field
                        @Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }) // Label for the email
                        <div class="col-md-10">
                            @Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }) // Editor for email entry
                            @Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }) // Validation message for email
                        </div>
                    </div>
                    <div class="form-group"> // Save button
                        <div class="col-md-10 pull-right">
                            <button type="submit" value="Save" class="btn btn-sm"> // Submit button for the form
                                <i class="fa fa-plus"></i> // Icon for the button
                                <span>
                                    Save
                                </span>
                            </button>
                        </div>
                    </div>
                </div>
            }
        }
    }
}
```

```html
6. To facilitate navigation for users to the newly created booking page, integrate a navigation link by adjusting the layout file found at (Views -> Shared -> _Layout.cshtml). Insert the code below:

```html
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="BookTicket" asp-action="Index">Book Ticket</a>
</li>
```

This update will ensure that your website visitors can easily access the booking interface from anywhere within the site.

Below is the paraphrased section of the article with resolved relative URL paths:

```html
<li class="nav-item">
    <a
        class="nav-link text-dark"
        asp-area=""
        asp-controller="BookTicket"
        asp-action="Index"
        >Reserve Ticket</a
    >
</li>
```

Here's the paraphrased section with resolved URL paths:

-----
### Resulting Display

Following the implementation steps, your final result should appear as follows:

![Final Interface Appearance](https://ironpdf.com/img/tutorials/dot-net-core/27.webp "Booking Interface") 

This shows the completed booking interface on your application after the steps have been successfully followed.

<img src="/img/tutorials/dot-net-core/26.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

8. Transition to the "Book Ticket" page; it should appear as follows:

![Book Ticket Page](https://ironpdf.com/img/tutorials/dot-net-core/27.webp)

<img src="/img/tutorials/dot-net-core/27.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Validating and Storing Booking Details

1. To enable data submission, introduce an additional index action decorated with the `[HttpPost]` attribute. This informs the MVC framework to handle form data submission. Validate the incoming data, and if it meets the criteria, guide the user to the TicketView Page. Should the validation fail, display relevant error messages to the user.

Here's a paraphrased version of the provided C# code snippet:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section6
    {
        public void Execute()
        {
            [HttpPost]
            public ActionResult Submit(ClientModel data)
            {
                if (ModelState.IsValid)
                {
                    ClientServices.RegisterClient(data);
                    return RedirectToAction("TicketView");
                }
                return View(data);
            }
        }
    }
}
```

This version of the code uses different method and variable names to perform the same functions, clarifying the actions being taken (like client registration) while keeping the original logic intact.

The following image shows examples of error messages displayed:
![Example of error messages](https://ironpdf.com/img/tutorials/dot-net-core/28.webp)

<img src="/img/tutorials/dot-net-core/28.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section7
    {
        public void Run()
        {
            public class TicketModel : ClientModel
            {
                public int TicketNumber { get; set; }
                public DateTime TicketDate { get; set; }
            }
        }
    }
}
```

Here's a paraphrased version of the section concerning the creation of a Ticket model within the "Models" file:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section7
    {
        public void Run()
        {
            // Define the TicketModel class, inheriting from ClientModel
            public class TicketModel : ClientModel
            {
                // Properties to hold ticket number and the date of the ticket
                public int TicketNumber { get; set; }
                public DateTime TicketDate { get; set; }
            }
        }
    }
}
```

In this section, a new class named `TicketModel` is generated, extending from the `ClientModel`. It contains properties for storing the ticket number (`TicketNumber`) and the event date (`TicketDate`). These properties enable tracking of individual tickets issued through this model.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section7
    {
        public void Execute()
        {
            public class TicketDetails : ClientModel
            {
                public int Number { get; set; }
                public DateTime Date { get; set; }
            }
        }
    }
}
```

## 3. Implement the TicketView for Displaying Tickets

The `TicketView` will serve as the visual presentation layer for tickets. This view integrates a Ticket partial view which specifically handles the display of the ticket details. This setup is crucial as it also facilitates future printing functionalities.

Here's how you can add this view to your project:

1. **Create the View:** From the "Controllers" folder in your solution explorer, right-click and add a new controller named `TicketView`.

   ![Create Controller](https://ironpdf.com/img/tutorials/dot-net-core/22.webp)

2. **Configure the Controller:** Name the controller `TicketViewController`.

   ![Name Controller](https://ironpdf.com/img/tutorials/dot-net-core/23.webp)

3. **Add View Setup:** Right-click on the controller method that you wish to associate with your view (typically an index or main method) and select "Add View".

   ![Add View](https://ironpdf.com/img/tutorials/dot-net-core/24.webp)

4. **Define the View:** Create a View called `index` where the Ticket details can be managed and displayed.

   ![Define View](https://ironpdf.com/img/tutorials/dot-net-core/25.webp)

5. **Implement Navigation:** To facilitate user access to the TicketBooking page, update the navigation layout in `Views -> Shared -> _Layout.cshtml`. Insert the following snippet to add a navigation link:

   ```html
   <li class="nav-item">
       <a class="nav-link text-dark" asp-area="" asp-controller="TicketViewController" asp-action="Index">Book Ticket</a>
   </li>
   ```

6. **View the Resulting Page:** Accessing the "Book Ticket" page through the updated navigation should display a page similar to the following:

   ![Ticket Page View](https://ironpdf.com/img/tutorials/dot-net-core/27.webp)

This setup ensures that your ticketing application not only displays tickets effectively but is also primed for subsequent functionalities such as printing.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section8
    {
        public void Execute()
        {
            public ActionResult RenderTicketView()
            {
                Random randomNumberGenerator = new Random();
                var clientDetails = ClientServices.GetClient();
                var ticketInformation = new TicketModel()
                {
                    TicketNumber = randomNumberGenerator.Next(100000, 999999),
                    TicketDate = DateTime.Now,
                    Email = clientDetails.Email,
                    Name = clientDetails.Name,
                    Phone = clientDetails.Phone
                };

                return View(ticketInformation);
            }
        }
    }
}
```

4. Right-click on the `TicketView` function, select "Add View," and designate it as "TicketView." Incorporate the following code:
```

```html
@model TicketsApps.Models.TicketModel 
@{
    ViewData["Title"] = "View Your Ticket";
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
	    <div class="col-md-10 pull-right">
		    <button type="submit" class="btn btn-sm">
			    <i class="fa fa-plus"></i>
			    <span> Download PDF </span>
		    </button>
	    </div>
    </div>
}
```

```html
@model TicketsApps.Models.TicketModel @{ Layout = null; }
<link href="../css/ticket.css" rel="stylesheet" />
<div class="ticket">
	<div class="stub">
		<div class="top">
			<span class="admit">VIP</span>
			<span class="line"></span>
			<span class="num">
				@Model.TicketNumber
				<span> Ticket</span>
			</span>
		</div>
		<div class="number">1</div>
		<div class="invite">Room Number</div>
	</div>
	<div class="check">
		<div class="big">
			Your <br />
			Ticket
		</div>
		<div class="number">VIP</div>
		<div class="info">
			<section>
				<div class="title">Date</div>
				<div>@Model.TicketDate.ToShortDateString()</div>
			</section>
			<section>
				<div class="title">Issued By</div>
				<div>Admin</div>
			</section>
			<section>
				<div the title="Invite number">Invite Number</div>
				<div>@Model.TicketNumber</div>
			</section>
		</div>
	</div>
</div>
```

### Rewritten Section 5 Paragraph:

5. Right-click on the `BookTicket` file in the solution explorer, select "Add View," and give it the name "_TicketPdf." Incorporate the following HTML structure:
```html
@model TicketsApps.Models.TicketModel @{ Layout = null; }
<link href="../css/ticket.css" rel="stylesheet" />
<div class="ticket">
    <div class="stub">
        <div class="top">
            <span class="admit">VIP</span>
            <span class="line"></span>
            <span class="num">
                @Model.TicketNumber
                <span> Ticket</span>
            </span>
        </div>
        <div class="number">1</div>
        <div class="invite">Room Number</div>
    </div>
    <div class="check">
        <div class="big">
            Your <br />
            Ticket
        </div>
        <div class="number">VIP</div>
        <div class="info">
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

```html
@model TicketsApps.Models.TicketModel @{ Layout = null; }
<link href="https://ironsoftware.com/img/tutorials/dot-net-core/css/ticket.css" rel="stylesheet" />
<div class="ticket">
	<div class="stub">
		<div class="top">
			<span class="admit">VIP</span>
			<span class="line"></span>
			<span class="num">
				@Model.TicketNumber
				<span> Ticket</span>
			</span>
		</div>
		<div class="number">1</div>
		<div class="invite">Room Number</div>
	</div>
	<div class="check">
		<div class="big">
			Your <br />
			Ticket
		</div>
		<div class="number">VIP</div>
		<div class="info">
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

6. Next, incorporate the "ticket.css" file from [this link](https://ironpdf.com/img/tutorials/dot-net-core/ticket.css) into the "wwwroot/css" directory in your project.

7. Ensure to include IronPDF in your project and accept the terms of the license agreement.
```

<img src="/img/tutorials/dot-net-core/31.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section9
    {
        public void Run()
        {
            IronPdf.Installation.TempFolderPath = $@"{Directory.GetParent}/irontemp/";
            IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
            var htmlContent = this.RenderViewAsync("_TicketPdf", model);
            var pdfRenderer = new IronPdf.ChromePdfRenderer();
            using var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent.Result, @"wwwroot/css");
            return File(pdfDocument.Stream.ToArray(), "application/pdf");
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section9
    {
        public void Run()
        {
            [HttpPost]
            public ActionResult DownloadPDF(TicketModel model)
            {
                // Temporary path for processing the files
                IronPdf.Installation.TempFolderPath = $@"{Directory.GetParent}/temp-pdf-files/";

                // Ensure compatibility with Linux and Docker environments
                IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

                // Convert the partial view to HTML string
                var htmlContent = this.RenderViewAsync("_TicketPdf", model);

                // Create an instance of ChromePdfRenderer
                var pdfRenderer = new IronPdf.ChromePdfRenderer();

                // Render the HTML string as a PDF with specified style sheet
                using var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlContent.Result, @"wwwroot/css");

                // Return the rendered PDF as a downloadable file
                return File(pdfDocument.Stream.ToArray(), "application/pdf");
            }
        }
    }
}
```

9. Develop a new controller in the "Controller" directory titled "ControllerExtensions". This controller will convert the partial view into a string format. Implement this extension using the code below:

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section10
    {
        public void Run()
        {
            public static class ControllerExtensions
            {
                public static async Task<string> RenderViewAsync<TModel>(this Controller controller, string viewName, TModel model, bool partial = false)
                {
                    if (string.IsNullOrEmpty(viewName))
                    {
                        viewName = controller.ControllerContext.ActionDescriptor.ActionName;
                    }
                    controller.ViewData.Model = model;
                    using (var writer = new StringWriter())
                    {
                        IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                        ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, !partial);
                        if (!viewResult.Success)
                        {
                            return $"A view with the name {viewName} could not be found";
                        }
                        ViewContext viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, writer, new HtmlHelperOptions());
                        await viewResult.View.RenderAsync(viewContext);
                        return writer.GetStringBuilder().ToString();
                    }
                }
            }
        }
    }
}
```

Here's the paraphrased section with resolved relative URL paths:

```cs
using System.Threading.Tasks;  // System namespace for parallel and asynchronous tasks
using IronPdf;  // Iron Software IronPdf library
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section10
    {
        public void Run()
        {
            // A static helper class to extend controller functionalities
            public static class ControllerExtensions
            {
                // Method to asynchronously render a view to a string representation
                public static async Task<string> RenderViewAsync<TModel>(this Controller controller, string viewName, TModel model, bool partial = false)
                {
                    // If no view name provided, use the current action name
                    if (string.IsNullOrEmpty(viewName))
                    {
                        viewName = controller.ControllerContext.ActionDescriptor.ActionName;
                    }
                    // Assign the model to the view data model
                    controller.ViewData.Model = model;
                    using (var writer = new StringWriter())  // Create a text writer
                    {
                        // Get the view engine from the service provider
                        IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                        // Try to find the view
                        ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, !partial);
                        if (!viewResult.Success)  // If view not found
                        {
                            return $"The view named {viewName} could not be found";
                        }
                        // Create the view context
                        ViewContext viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, writer, new HtmlHelperOptions());
                        // Render the view to the StringWriter
                        await viewResult.View.RenderAsync(viewContext);
                        // Return the rendered view as a string
                        return writer.GetStringBuilder().ToString();
                    }
                }
            }
        }
    }
}
``` 

This rewritten section preserves the original logic and structure while rephrasing explanations and the process flow. Also, it ensures that the namespace and method usage are clearly outlined.

Execute the application, input the necessary ticket details, and then select 'Save'.

<img src="/img/tutorials/dot-net-core/32.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

Below is the revised version of the section titled "11. View the generated ticket" with updated image URLs and a few editorial adjustments.

-----
### 11. View the Generated Ticket

Once you have populated the ticket information and performed the 'Save' operation, you'll be able to view the completed ticket. This step comes after the ticket data has been successfully input and the form submission has returned a successful save operation. The form will redirect you to a page where the ticket, structured with all the given details, is displayed for your review. 

The appearance of the generated ticket is designed to be clear and user-friendly, ensuring all the relevant details are displayed neatly. You can view an example of what the generated ticket looks like below:

![View the Generated Ticket](https://ironpdf.com/img/tutorials/dot-net-core/33.webp)

This visual confirmation is crucial as it allows you to verify the information before proceeding to the next step, which typically involves downloading or printing the ticket.

<img src="/img/tutorials/dot-net-core/33.webp" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;">

### Download Your PDF Ticket

To obtain a PDF version of your ticket, click on the 'Download Pdf' button. A PDF file containing the ticket details will then be generated for you to download.

For a comprehensive review of the code used in this tutorial, you can download the entire project in a ZIP file. This can be imported and accessed through Visual Studio for your own use and modifications. [Download the complete project here.](https://ironpdf.com/img/tutorials/dot-net-core/TicketsApps.zip)

<hr class="separator">

## 5. Adjusting .NET PDF Rendering Settings

Explore advanced configurations available for customizing PDF rendering, such as margin adjustments, page orientation, and paper sizing.

Refer to the table below for a comprehensive guide to the numerous settings you can modify.

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

## 6. Chart of Options for .NET PDF Headers and Footers

The following table provides a detailed look at the options available for customizing headers and footers in .NET PDF documents using the `TextHeaderFooter` class.

<div class="content-table dotnet-core-pdf-table">
  <table>
    <tbody>
      <tr class="tr-head">
          <th class="tcol1">Class</th>
          <th colspan="2">TextHeaderFooter</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Explanation</th>
          <th colspan="2">Utilized for specifying the appearances of text-based headers and footers in the PDF documents</th>
      </tr>
      <tr class="tr-head">
          <th class="tcol1">Attributes and Methods</th>
          <th class="tcol2">Type</th>
          <th class="tcol3">Detail</th>
      </tr>
      <tr>
          <td>CenterText</td>
          <td rowspan="3">string</td>
          <td rowspan="3">Defines texts positioned at the center, left, or right in PDF's header or footer. These elements can dynamically merge document metadata such as: {page}, {total-pages}, {url}, {date}, {time}, {html-title}, {pdf-title}</td>
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
          <td>Incorporates a horizontal line separating the content from header or footer throughout the PDF.</td>
      </tr>
      <tr>
        <td>DrawDividerLineColor</td>
        <td>Color</td>
        <td>Specifies the color for the divider line set by `DrawDividerLine`.</td>
      </tr>
      <tr>
          <td>Font</td>
          <td>PdfFont</td>
          <td>Indicates the font family to be utilized within the PDF. The default option is IronSoftware.Drawing.FontTypes.Helvetica.</td>
      </tr>
      <tr>
          <td>FontSize</td>
          <td>Double</td>
          <td>Specifies the size of the font in the header or footer text, measured in pixels.</td>
      </tr>
    </tbody>
  </table>
</div>

The provided chart below serves to guide developers in configuring PDF header and footer options through attributes and methods inherent to the `TextHeaderFooter` class, enhancing layout customization within .NET PDF creation and manipulation tasks.

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

## 7. Set Up PDF Rendering Preferences

Explore how to adjust the settings for generating PDF documents.

The following code example demonstrates the configuration and utilization of rendering options in IronPDF to create a PDF file from an HTML document, specifically setting the paper size to A4 and the orientation to portrait before saving the output.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section11
    {
        public void Run()
        {
            // Assign your license key to access full features
            IronPdf.License.LicenseKey = "YourLicenseKey";
            
            // Initialize the PDF Renderer
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

            // Configure rendering parameters
            pdfRenderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.A4;
            pdfRenderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;

            // Generate the PDF from HTML file and save it
            pdfRenderer.RenderHtmlFileAsPdf(@"testFile.html").SaveAs("GeneratedFile.pdf");
        }
    }
}
```

<hr class="separator">

## 8. Docker and .NET Core Integration

Docker is an essential platform-as-a-service (PaaS) that uses OS-level virtualization to package software into standardized units called containers. These containers are isolated but can communicate through predefined channels. They bundle their own software, libraries, and configuration files, significantly simplifying the dependency management across different computing environments.

For a deeper understanding of Docker's integration with ASP.NET Core applications, consider visiting these detailed guides:

- [Building .NET Docker Images](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images)
- Introduction to [.NET and Docker](https://docs.microsoft.com/en-us/dotnet/core/docker/introduction)
- [How to Build Containers for .NET Core Applications](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container)

### 8.1 Installing Docker

To install Docker, begin by visiting the Docker homepage:

[Install Docker from Official Site](https://www.docker.com/)

Follow the steps below to download and install Docker on your system:

1. Click on 'Get Started' to navigate through the setup.
2. Select the appropriate download link for Mac or Windows.

   ![Download Docker Installation](https://ironsoftware.com/img/tutorials/dot-net-core/41.png)

3. Complete the signup process, if necessary, and then log in.
4. Download the Docker installation file for Windows.

   ![Download Docker for Windows](https://ironsoftware.com/img/tutorials/dot-net-core/43.png)

5. Proceed with the installation of Docker. This step might require restarting your computer.

   ![Installing Docker](https://ironsoftware.com/img/tutorials/dot-net-core/45.png)

6. Post restart, log into Docker to finalize the setup.

   ![Login to Docker](https://ironsoftware.com/img/tutorials/dot-net-core/46.png)

7. Test your Docker installation by running a simple "hello world" container via your command line or PowerShell:

   ```bash
   Docker run hello-world
   ```

   ![Docker Hello World](https://ironsoftware.com/img/tutorials/dot-net-core/47.png)

Here are some essential Docker commands to get you started:

- `Docker images`: List all images available on your machine.
- `Docker ps`: Show all running containers.
- `Docker ps -a`: Display all containers on your system.

### 8.2 Running in a Linux Container

Below are some visuals showing the process of running applications within a Linux container environment:

![Linux Container](https://ironsoftware.com/img/tutorials/dot-net-core/38.png)

![Using Linux Container](https://ironsoftware.com/img/tutorials/dot-net-core/39.png)

Docker enhances the deployment of applications by ensuring consistency across environments, simplifying the developer's task in shipping and running applications nearly anywhere.

### 8.1. Understanding Docker

Docker represents a suite of platform as a service (PaaS) products that utilize OS-level virtualization to deploy software in units known as containers. These containers are separated from one another and come packaged with their own software, libraries, and configuration files; they interact amongst themselves via well-defined channels.

Discover more about integrating [Docker with ASP.NET Core applications](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images).

We're moving forward with practical Docker use, but for a more in-depth exploration, see these resources on [.NET with Docker](https://docs.microsoft.com/en-us/dotnet/core/docker/introduction) and how to [construct containers for .NET Core applications](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container).

Let's dive into using Docker.

### 8.2. Install Docker

Begin by navigating to the Docker website to [download and install Docker](https://www.docker.com/).

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/40.png" target="_blank">
<img src="/img/tutorials/dot-net-core/40.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Click to begin.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/41.png" target="_blank">
<img src="/img/tutorials/dot-net-core/41.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Download for both Mac and Windows systems.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/42.png" target="_blank">
<img src="/img/tutorials/dot-net-core/42.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Sign up at no cost, then proceed to log in.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/43.png" target="_blank">
<img src="/img/tutorials/dot-net-core/43.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Download Docker for your Windows system.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/44.png" target="_blank">
<img src="/img/tutorials/dot-net-core/44.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

# Docker Installation Guide

***Based on <https://ironpdf.com/tutorials/dotnet-core-pdf-generating/>***


Begin the installation process for Docker by visiting the Docker homepage. 

Follow these steps:

1. Navigate to the Docker website to download the Docker application for either Mac or Windows.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/40.png)

   Click the "Get Started" button.

2. Proceed to download the appropriate version for your operating system.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/41.png)

   Select "Download for Mac and Windows."

3. Sign up for a free account and then log in to continue.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/42.png)

   Sign up by entering your details, or log in if you already have an account.

4. After logging in, click the link to download Docker for Windows.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/43.png)

   Follow the prompts to begin the download.

5. Execute the installer and follow the installation procedure.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/44.png)

   Run the installer and proceed as directed.

6. A system reboot may be required to complete the installation.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/45.png)

   Restart your computer to finalize the Docker installation.

7. Once your machine restarts, log in to Docker to start using it.

   ![](https://ironpdf.com/img/tutorials/dot-net-core/46.png)

   Log back into Docker after rebooting to activate the application.

Now, Docker should be successfully installed on your device, and you’re ready to run the Docker "hello world" command to verify the installation.

```bash
Docker run hello-world
```

   ![](https://ironpdf.com/img/tutorials/dot-net-core/47.png)

The successful execution of this command indicates that Docker is correctly set up and operational on your system.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/45.png" target="_blank">
<img src="/img/tutorials/dot-net-core/45.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

You'll need to restart your computer. Once it has rebooted, log in to Docker.

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/46.png" target="_blank">
<img src="/img/tutorials/dot-net-core/46.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Here's a paraphrased version of the provided section, with the relative URL paths resolved to `ironsoftware.com`:

---
You can test Docker on your system by launching the Windows command line or PowerShell, and executing the following command:

```bash
Docker run hello-world
```

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/47.png" target="_blank">
<img src="/img/tutorials/dot-net-core/47.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

Below are essential Docker command lines for navigating and managing containers:

- `Docker images` — Lists all Docker images currently available on this system.
- `Docker ps` — Displays all containers that are currently running.
- `Docker ps -a` — Shows all existing containers on the machine, regardless of their status.

### 8.3. Deploying to a Linux Container

Deploying your .NET Core applications within Linux containers offers enhanced portability and consistency across different environments. Follow the steps below to start using Linux containers for your .NET applications.

<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/38.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/38.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="https://ironpdf.com/img/tutorials/dot-net-core/39.png" target="_blank">
<img src="https://ironpdf.com/img/tutorials/dot-net-core/39.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<a style="text-decoration: none" href="/img/tutorials/dot-net-core/38.png" target="_blank">
<img src="/img/tutorials/dot-net-core/38.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>
<a style="text-decoration: none" href="/img/tutorials/dot-net-core/39.png" target="_blank">
<img src="/img/tutorials/dot-net-core/39.png" alt="" class="img-responsive add-shadow img-margin" style="max-width:100%;"></a>

<hr class="separator">

## 9. Manipulating Existing PDFs in .NET Core

### 9.1 Open PDF Files

You can open and work with existing PDF files in your .NET applications. The following examples demonstrate how to open both standard and password-protected PDFs:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section12
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument standardPdf = PdfDocument.FromFile("normal.pdf");
            PdfDocument securePdf = PdfDocument.FromFile("encrypted.pdf", "PasswordHere");
        }
    }
}
```

### 9.2 Merge PDF Documents

Easily combine several PDFs into one document. Below, you'll see how to merge three PDF files:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section13
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            var documents = new List<PdfDocument>
            {
                PdfDocument.FromFile("file1.pdf"),
                PdfDocument.FromFile("file2.pdf"),
                PdfDocument.FromFile("file3.pdf")
            };
            using PdfDocument mergedPDF = PdfDocument.Merge(documents);
            mergedPDF.SaveAs("combined.pdf");
            foreach (PdfDocument doc in documents)
            {
                doc.Dispose();
            }
        }
    }
}
```

Append PDFs or insert one PDF into another at a specific position:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section14
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument originalPdf = PdfDocument.FromFile("original.pdf");
            PdfDocument additionalPdf = PdfDocument.FromFile("insert.pdf");
            originalPdf.AppendPdf(additionalPdf);
            originalPdf.SaveAs("appendedFile.pdf");
        }
    }
}

using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section15
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument basePdf = PdfDocument.FromFile("base.pdf");
            PdfDocument insertPdf = PdfDocument.FromFile("insert.pdf");
            basePdf.InsertPdf(insertPdf, 0);
            basePdf.SaveAs("EnhancedFile.pdf");
        }
    }
}
```

### 9.3 Add Headers and Footers

Enhance your PDFs by adding customized headers and footers. Here is how you can add textual or HTML content as headers and footers:

**Add Text Headers and HTML Footers**

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section16
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdfDoc = PdfDocument.FromFile("demo.pdf");
            var textHeader = new TextHeaderFooter()
            {
                CenterText = "Document Title",
                LeftText = "{date} {time}",
                RightText = "{page} of {total-pages}",
                DrawDividerLine = true,
                FontSize = 12
            };
            pdfDoc.AddTextHeaders(textHeader);
            pdfDoc.SaveAs("WithTextHeaders.pdf");

            var htmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<div style='text-align:center;'>Page {page} of {total-pages}</div>",
                DrawDividerLine = true,
                MaxHeight = 15  // in millimeters
            };
            pdfDoc.AddHtmlFooters(htmlFooter);
            pdfDoc.SaveAs("CompleteDocument.pdf");
        }
    }
}
```

This snippet demonstrates opening, merging, and adding headers and footers to PDF documents using IronPDF in a .NET Core environment. Adapt and expand upon these examples to suit specific project needs and to fully leverage the capabilities of IronPDF.

### 9.1. Opening Existing PDF Files

Just as you can generate a PDF from URLs and HTML (either as strings or files), you similarly have the capability to manipulate already existing PDF files.

Here's how you can open a standard or password-protected encrypted PDF document:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section12
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            // Load a regular PDF
            PdfDocument regularPdf = PdfDocument.FromFile("testFile.pdf");
            
            // Load a password-protected PDF
            PdfDocument protectedPdf = PdfDocument.FromFile("secureTestFile.pdf", "MySecretPassword");
        }
    }
}
```

Here's a paraphrased version of the provided code section:

```cs
using IronPdf;
// Define the namespace for the PDF operations
namespace ironpdf.DotnetCorePdfOperations
{
    // Class definition for interacting with PDF files
    public class PdfInteractionExample
    {
        // Method to demonstrate opening PDF files
        public void Execute()
        {
            // Set the license key for IronPDF
            IronPdf.License.LicenseKey = "YourLicenseKey";

            // Load a non-secured PDF document from the storage
            PdfDocument regularPdf = PdfDocument.FromFile("testFile.pdf");

            // Load a secured PDF document using the provided password
            PdfDocument securePdf = PdfDocument.FromFile("testFile2.pdf", "MyPassword");
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section13
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            List<PdfDocument> PDFs = new List<PdfDocument>();
            PDFs.Add(PdfDocument.FromFile("1.pdf"));
            PDFs.Add(PdfDocument.FromFile("2.pdf"));
            PDFs.Add(PdfDocument.FromFile("3.pdf"));
            using PdfDocument PDF = PdfDocument.Merge(PDFs);
            PDF.SaveAs("mergedFile.pdf");
            foreach (PdfDocument pdf in PDFs)
            {
                pdf.Dispose();
            }
        }
    }
}
```

In this example, the process of merging multiple PDF files into a single document is demonstrated. Importing the necessary IronPdf namespace and employing the `IronPdf` class, several PDF files are added to a list, subsequently merged, and the final consolidated PDF is saved as "mergedFile.pdf". Post-saving, the original documents in the list are disposed of to free up resources.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class MergePDFExample
    {
        public void Execute()
        {
            // Set the license key for IronPDF
            IronPdf.License.LicenseKey = "YourLicenseKey";

            // Create a list to hold the PDF documents
            List<PdfDocument> pdfDocuments = new List<PdfDocument>();
            // Adding PDF files to the list
            pdfDocuments.Add(PdfDocument.FromFile("1.pdf"));
            pdfDocuments.Add(PdfDocument.FromFile("2.pdf"));
            pdfDocuments.Add(PdfDocument.FromFile("3.pdf"));

            // Merge the PDF documents into a single PDF
            using PdfDocument mergedPdf = PdfDocument.Merge(pdfDocuments);
            // Save the merged PDF file
            mergedPdf.SaveAs("mergedFile.pdf");

            // Clean up: Dispose of the PDF documents to free resources
            foreach (PdfDocument doc in pdfDocuments)
            {
                doc.Dispose();
            }
        }
    }
}
```

Here's the paraphrased section with resolved URLs:

---
### How to Append an Existing PDF to Another

You can expand your current PDF document by appending another file to its end. Here is how you can achieve this:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section14
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument originalPdf = PdfDocument.FromFile("1.pdf"); // Load the original PDF
            PdfDocument additionalPdf = PdfDocument.FromFile("2.pdf"); // Load the PDF to append

            originalPdf.AppendPdf(additionalPdf); // Append the additional PDF to the end of the original
            originalPdf.SaveAs("appendedFile.pdf"); // Save the combined document
        }
    }
}
``` 

This method facilitates the incorporation of content from multiple PDF files into a single document, streamlining access and improving document management.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section14
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            // Load the primary PDF document
            PdfDocument mainPdf = PdfDocument.FromFile("1.pdf");
            // Load the PDF to be appended
            PdfDocument additionalPdf = PdfDocument.FromFile("2.pdf");
            // Append the second PDF to the first
            mainPdf.AppendPdf(additionalPdf);
            // Save the combined PDF to a new file
            mainPdf.SaveAs("appendedFile.pdf");
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section15
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument basePdf = PdfDocument.FromFile("1.pdf");
            PdfDocument additionalPdf = PdfDocument.FromFile("2.pdf");
            basePdf.InsertPdf(additionalPdf, 0);
            basePdf.SaveAs("InsertIntoSpecificIndex.pdf");
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class PdfInsertExample
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            var primaryPdf = PdfDocument.FromFile("1.pdf");
            var secondaryPdf = PdfDocument.FromFile("2.pdf");
            // Insert second PDF at the beginning of the first PDF
            primaryPdf.InsertPdf(secondaryPdf, index: 0);
            primaryPdf.SaveAs("InsertedAtFirstPosition.pdf");
        }
    }
}
```

### 9.3 Adding Headers and Footers to PDFs

It's possible to append both headers and footers to PDFs that are already compiled or when they are generated from HTML or URL sources.

For this purpose, you can utilize two distinct classes:

- **`TextHeaderFooter`**: This allows the addition of plain text into the header or footer.
- **`HtmlHeaderFooter`**: This class is used for incorporating rich HTML content and images into the header or footer.

Now, let's explore two practical uses of these classes for adding headers and footers, both to existing PDFs and during the PDF rendering process.

#### 9.3.1 Inserting Headers into Existing PDFs

Here's how you can enhance an existing PDF by injecting both a header and a footer using the `AddTextHeaders` and `AddHtmlFooters` methods.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfCreating
{
    public class AddHeaderFooterExample
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument document = PdfDocument.FromFile("testFile.pdf");
            TextHeaderFooter textHeader = new TextHeaderFooter()
            {
                CenterText = "PDF Document Header",
                LeftText = "{date} {time}",
                RightText = "{page} of {total-pages}",
                DrawDividerLine = true,
                FontSize = 10
            };
            document.AddTextHeaders(textHeader);
            document.SaveAs("DocumentWithHeader.pdf");

            HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<span style='text-align:right'>Page {page} of {totalpages}</span>",
                DrawDividerLine = true,
                MaxHeight = 10 // Specified in mm
            };
            document.AddHtmlFooters(htmlFooter);
            document.SaveAs("DocumentWithHeaderAndFooter.pdf");
        }
    }
}
```

**9.3.2 Adding Headers and Footers to a Newly Created PDF**

Below, you'll find guidance on generating a PDF from an HTML file while incorporating headers and footers through rendering options.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section17
    {
        public void Run()
        {
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
                HtmlFragment = "<span style='text-align:right'> page {page} of {total-pages}</span>",
                DrawDividerLine = true,
                MaxHeight = 10 // in mm, specifying the maximum height of the footer
            };
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("test.html");
            pdf.SaveAs("generatedFile.pdf");
        }
    }
}
```

Here's a paraphrased version of the specified section from the article, with resolved URL paths:

```cs
using IronPdf;

namespace ironpdf.DotnetCorePdfProducing
{
    public class Section17
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";  // Set your license key
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            
            // Configure header options
            pdfRenderer.RenderingOptions.TextHeader = new TextHeaderFooter()
            {
                CenterText = "Pdf Document Header",
                LeftText = "{date} {time}",
                RightText = "{page} of {total-pages}",
                DrawDividerLine = true,  // Include a divider line
                FontSize = 10  // Set the font size
            };
            
            // Set footer using HTML
            pdfRenderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<span style='text-align:right'>Page {page} of {totalpages}</span>",
                DrawDividerLine = true,  // Include a divider line
                MaxHeight = 10  // Limit the height to 10mm
            };

            // Generate PDF from HTML file
            PdfDocument pdfDoc = pdfRenderer.RenderHtmlFileAsPdf("test.html");
            pdfDoc.SaveAs("generatedFile.pdf");  // Save the newly created PDF
        }
    }
}
``` 

This paraphrasing maintains the original code's structure while varying descriptions and comments to reflect a more natural and diverse language tone.

<hr class="separator">

## 10. Implement PDF Security and Password Protection

Secure your PDF documents with password protection and configure security settings to restrict actions such as copying and printing.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class SecuritySettingsExample
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument document = PdfDocument.FromFile("testFile.pdf");

            // Update file metadata
            document.MetaData.Author = "john smith";
            document.MetaData.Keywords = "SEO, Friendly";
            document.MetaData.ModifiedDate = DateTime.Now;

            // Configure security settings to make the PDF read-only and restrict copy, paste, and printing functionalities
            document.SecuritySettings.RemovePasswordsAndEncryption();
            document.SecuritySettings.MakePdfDocumentReadOnly("secret-key"); // Using 'secret-key' as the owner password
            document.SecuritySettings.AllowUserAnnotations = false;
            document.SecuritySettings.AllowUserCopyPasteContent = false;
            document.SecuritySettings.AllowUserFormData = false;
            document.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

            // Set or update the PDF's encryption password
            document.Password = "123";
            document.SaveAs("secured.pdf");
        }
    }
}
```

<hr class="separator">

## 11. Digitally Sign PDFs

Digitally signing a PDF can be done easily using the following method:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section19
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            pdf.Sign(new PdfSignature("cert123.pfx", "password"));
            pdf.SaveAs("signed.pdf");
        }
    }
}
```

For more detailed control over the digital signature, consider the following advanced example:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section20
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            IronPdf.Signing.PdfSignature signature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");
            
            // Optional parameters to further customize the signature
            signature.SigningContact = "support@ironsoftware.com";
            signature.SigningLocation = "Chicago, USA";
            signature.SigningReason = "To demonstrate PDF digital signing";
            
            // Apply the digital signature to the PDF document. Multiple signatures can be added.
            pdf.Sign(signature);
        }
    }
}
```

```cs
using IronPdf;

namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section19
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument document = PdfDocument.FromFile("testFile.pdf");
            PdfSignature signature = new PdfSignature("cert123.pfx", "password");
            document.Sign(signature);
            document.SaveAs("signed.pdf");
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section20
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            IronPdf.Signing.PdfSignature signature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");
            
            // Additional options for signing
            signature.SigningContact = "support@ironsoftware.com";
            signature.SigningLocation = "Chicago, USA";
            signature.SigningReason = "To demonstrate the process of signing a PDF";
            
            // Apply the signature to the PDF. You can use multiple certificates if needed
            pdf.Sign(signature);
        }
    }
}
```

In this enhanced example, we delve deeper into the options available for digitally signing a PDF document. Here, a digital signature is not only applied, but it’s also customized with additional information such as the contact details, location, and reason for signing. This example utilizes `IronPdf.Signing.PdfSignature` to handle the signature process, showing how to set up a more detailed and controlled digital signing environment within your .NET applications.

Here's the paraphrased section of the article regarding a more detailed control in applying a digital signature to a PDF using IronPDF:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class DetailedPdfSigning
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument document = PdfDocument.FromFile("testFile.pdf");
            IronPdf.Signing.PdfSignature digitalSignature = new IronPdf.Signing.PdfSignature("cert123.pfx", "123");
            
            // Configuring optional signature properties
            digitalSignature.SigningContact = "support@ironsoftware.com";
            digitalSignature.SigningLocation = "Chicago, USA";
            digitalSignature.SigningReason = "Demonstration of PDF signing capabilities";

            // Applying the signature to the PDF using the specified certificate
            document.Sign(digitalSignature);
        }
    }
}
```

This code snippet demonstrates how to digitally sign a PDF document using a certificate, providing optional information such as the contact email, location, and reason for signing. This ensures the authenticity and integrity of the document.

## 12. Retrieving Text and Images from PDFs

Using IronPdf, accessing text and images within PDF files is straightforward. Below, you'll find the necessary steps to extract this information, whether you're interested in all text and images or only specific portions.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section21
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            // Retrieve all text from the PDF
            pdf.ExtractAllText();
            // Extract text from a specific page
            pdf.ExtractTextFromPage(0);
            
            // Get all images from the PDF
            var AllImages = pdf.ExtractAllImages();
            
            // Extract images from a specific page
            var ImagesOfAPage = pdf.ExtractImagesFromPage(0);
        }
    }
}
```

### 12.1. Converting PDF Pages to Images

Further extend the capabilities by transforming PDF pages into image files. This is especially useful when previews or thumbnails are needed.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section22
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            var pageList = new List<int> { 1, 2 }; // Specify pages to convert
            
            // Convert selected pages to image files
            pdf.RasterizeToImageFiles("*.png", pageList);
        }
    }
}
```

<b>Extract text and images</b>

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section21
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            // Extracting all text from the PDF
            pdf.ExtractAllText(); 
            // Extracting text from a specific page, e.g., the first page
            pdf.ExtractTextFromPage(0); 
            
            // Extract all images contained in the PDF
            var AllImages = pdf.ExtractAllImages();
            
            // Extract images from a specific page, e.g., the first page
            var ImagesOfAPage = pdf.ExtractImagesFromPage(0);
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section21
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdfDocument = PdfDocument.FromFile("testFile.pdf");

            // Retrieve all text from the entire PDF
            pdfDocument.ExtractAllText(); 

            // Retrieve text from the first page of the PDF
            pdfDocument.ExtractTextFromPage(0); 

            // Get all images from the entire PDF document
            var imagesFromPdf = pdfDocument.ExtractAllImages();

            // Get images from the first page of the PDF
            var imagesFromFirstPage = pdfDocument.ExtractImagesFromPage(0);
        }
    }
}
```

### 12.1 Convert PDF to Image Format

Transforming PDF documents into images can be accomplished with the following steps:
```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section22
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            // Specify the pages to convert to images
            List<int> pageList = new List<int>() { 1, 2 };
            
            // Convert and save specified pages as image files
            pdf.RasterizeToImageFiles("*.png", pageList);
        }
    }
}
```

Here's the paraphrased version of the provided section, with all relative URLs resolved to `ironpdf.com`:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section22
    {
        public void Execute()
        {
            // Insert your IronPDF license key below
            IronPdf.License.LicenseKey = "YourLicenseKey";
            
            // Load the PDF document from the file
            PdfDocument pdfDocument = PdfDocument.FromFile("testFile.pdf");
            
            // Define a list of pages to convert to images
            List<int> pagesToRasterize = new List<int> { 1, 2 };
            
            // Convert the specified pages to PNG images
            pdfDocument.RasterizeToImageFiles("*.png", pagesToRasterize);
        }
    }
}
```

The provided code snippet is reformulated for clarity and utilizes alternative variable and method names while retaining the original logic and structure.

<hr class="separator">

## 13. Applying Watermarks to PDF Pages

This section demonstrates how to add watermarks to your PDF documents:

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section23
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            
            // Adding a watermark
            pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);
            pdf.SaveAs("Watermarked.pdf");
        }
    }
}
```

Watermarking offers limited customization options. For more comprehensive capabilities, consider using the **HTMLStamper** class.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section24
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<div>test text </div>");
            
            // Configuring HTML stamper
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
        }
    }
}
```

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section23
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

            // Adding a watermark to the PDF
            pdf.ApplyWatermark("<h2 style='color:red'>SAMPLE</h2>", 30, IronPdf.Editing.VerticalAlignment.Middle, IronPdf.Editing.HorizontalAlignment.Center);
            pdf.SaveAs("Watermarked.pdf");
        }
    }
}
```

Watermarking comes with a limited range of functionalities. For more comprehensive customization capabilities, the **HTMLStamper** class offers extensive control.

```cs
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class WatermarkingSection
    {
        public void Execute()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<div>test content</div>");

            // Setting up the HTML watermark
            HtmlStamper watermark = new HtmlStamper()
            {
                Html = "<h2 style='color:red'>copyright 2018 ironpdf.com</h2>",
                MaxWidth = new Length(20),
                MaxHeight = new Length(20),
                Opacity = 50,
                Rotation = -45,
                IsStampBehindContent = true,
                VerticalAlignment = VerticalAlignment.Middle
            };

            // Applying the watermark to the PDF
            document.ApplyStamp(watermark);
            document.SaveAs("watermarkedOutput.pdf");
        }
    }
}
```

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

