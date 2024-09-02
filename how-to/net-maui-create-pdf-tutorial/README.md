# Creating PDFs in .NET MAUI with IronPDF Using Visual Studio

## Overview

The .NET Multi-platform App UI (.NET MAUI) is a cutting-edge framework designed for building native mobile and desktop applications using C# and XAML. It is an evolution from .NET Core and .NET Framework, enabling developers to construct applications across multiple platforms such as desktop, web, and mobile using a unified code base. It also supports the incorporation of platform-specific code and resources as required.

For generating PDFs within a .NET MAUI application, one efficient approach could be to employ a PDF library such as IronPDF, which facilitates the creation and management of PDF documents directly from your app.

## IronPDF Capabilities

IronPDF stands out as a comprehensive HTML to PDF conversion library, equipped to handle a myriad of operations similar to a web browser. It enables the creation, modification, and management of PDF files in .NET environments, supporting complex web pages with extensive CSS and JavaScript. By simply loading HTML content into a string or a stream, IronPDF can transform it into a PDF, which can then be saved to various outputs.

IronPDF seamlessly integrates into any .NET project, including those using .NET MAUI, as detailed in this guide.

## Getting Started

Before beginning with PDF generation in .NET MAUI using IronPDF, ensure the following prerequisites:

- Installation of the .NET SDK in Visual Studio
- An active .NET MAUI Blazor app or a simple .NET MAUI project
- Internet connectivity for downloading the IronPDF library via Visual Studio's Command-line

## Generating PDFs in .NET MAUI

1. Start by creating a new .NET MAUI PDF project in Visual Studio.
2. Install the IronPDF Library via NuGet.
3. Design the UI for the .NET MAUI Content Pages.
4. Utilize the `ChromePdfRenderer.RenderHtmlAsPdf` method to generate a PDF.
5. Utilize platform-specific code to store the PDF on users' devices.

## Installation of the IronPDF Library

### Via Visual Studio Command-Line

To integrate IronPDF in your project using the NuGet Package Manager in Visual Studio, perform the following:

1. Navigate to "Tools" -> "NuGet Package Manager" -> "Package Manager Console".
2. Execute the following command to install IronPDF:

    ```shell
    Install-Package IronPdf
    ```

    ![Installation of IronPDF](https://ironpdf.com/static-assets/pdf/blog/csharp-maui-pdf-ironpdf/csharp-maui-pdf-ironpdf-6.webp)

## Implementing PDF Functionality in .NET MAUI

Upon creating a new .NET MAUI project, a default file named `MainPage.xaml` will be generated. This file houses the initial UI setup of your application which can be modified to include elements such as buttons and textboxes as shown below:

```xml
<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="MAUI_PDF.MainPage">
    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center">
            <Image
                Source="https://ironpdf.com/dotnet_bot.png"
                SemanticProperties.Description="Cute dot net bot waving hi to you!"
                HeightRequest="200"
                HorizontalOptions="Center" />
            <Label
                Text="Welcome to IronPDF!"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />
            <Button
                x:Name="PdfBtn"
                Text="Click me to generate PDF"
                SemanticProperties.Hint="Click button to generate PDF"
                Clicked="GeneratePDF"
                HorizontalOptions="Center" />
        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
```

In `MainPage.xaml.cs`, implement the `GeneratePDF` method:

```cs
private void GeneratePDF(object sender, EventArgs e)
{
    ChromePdfRenderer renderer = new ChromePdfRenderer();
    var doc = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF!</h1> <p>I'm using IronPDF MAUI!</p>");
    //Saves the memory stream as a file.
    SaveService saveService = new SaveService();
    saveService.SaveAndView("IronPDF HTML string.pdf", "application/pdf", doc.Stream);
}
```

For platform-specific file saving, define a `SaveService` class as outlined previously, using separate partial classes to handle file saving per platform.

## Conclusion

IronPDF is an effective and versatile library, ideal for incorporating comprehensive PDF functionalities into .NET MAUI applications. It supports a full spectrum of PDF manipulations ranging from merging, splitting, text extraction, interactive form filling, to full document creation. IronPDF offers various licensing options, starting from `$liteLicense`, along with additional product support and update packages.

Explore additional resources and tutorials from [IronPDF Tutorials](https://ironpdf.com/blog/using-ironpdf/csharp-maui-pdf-ironpdf/).