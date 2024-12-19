# Generate PDF Documents in .NET MAUI with Visual Studio

***Based on <https://ironpdf.com/how-to/net-maui-create-pdf-tutorial/>***


## Overview

The .NET Multi-platform App UI (.NET MAUI) is a framework used for constructing native applications across mobile and desktop platforms utilizing C# and XAML. Serving as a modern evolution of .NET Core and .NET Framework, .NET MAUI provides developers the capability to develop applications for a variety of platforms from a singular codebase, integrating platform-specific resources as needed.

In the context of generating PDF documents within a .NET MAUI application, leveraging a PDF library like IronPDF is a feasible approach.

## Capabilities of IronPDF

IronPDF stands out as a comprehensive library adept at converting HTML to PDF, mirroring the capabilities of a standard web browser. This library facilitates the creation and modification of PDF documents within .NET applications, supporting complex web page designs that utilize extensive CSS and JavaScript. Utilizing IronPDF involves loading HTML content into a string or stream and converting it with IronPDF to produce a PDF file, which can then be saved or exported as needed.

This library is versatile enough to be employed across various .NET projects, including those developed with .NET MAUI.

## Preparation Steps

Before starting the PDF generation process in a .NET MAUI environment with IronPDF, ensure the following prerequisites are met:

- Installation of the .NET Framework within Visual Studio.
- An operational .NET MAUI Blazor application or a basic .NET MAUI project.
- Reliable internet connection for installing the IronPDF library via the Visual Studio Command-line.

## Creating PDF Files in .NET MAUI

1. Begin by establishing a new .NET MAUI PDF project in Visual Studio.
2. Integrate the IronPDF Library into your project via NuGet.
3. Develop the user interface (UI) for the .NET MAUI content pages.
4. Utilize the `ChromePdfRenderer.RenderHtmlAsPdf` method to generate a PDF document.
5. Utilize platform-specific coding to store the PDF document on the user's device.

## Installing the IronPDF Library

### Through the Visual Studio Command-Line

To integrate IronPDF into your .NET project, proceed with the following steps using the NuGet Package Manager Console:

1. Access the NuGet Package Manager Console found under the "Tools" menu in Visual Studio by navigating to "NuGet Package Manager" > "Package Manager Console".
2. Execute the command below to install IronPDF.

    ```shell
    /Install-Package IronPdf
    ```

    ![Install IronPDF](https://ironpdf.com/static-assets/pdf/blog/csharp-maui-pdf-ironpdf/csharp-maui-pdf-ironpdf-6.webp)

## Implementing PDF Creation in .NET MAUI Using IronPDF

Upon creating a new .NET MAUI project, a file named `MainPage.xaml` is automatically generated, which includes the default UI for your application. This file can be customized by editing its XML content to adjust the UI elements such as buttons, labels, and images according to your application's design needs.

The XAML configuration for the MainPage is displayed below.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="MAUI_PDF.MainPage"
>
    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center">
            <Image
                Source="https://ironpdf.com/dotnet_bot.png"
                SemanticProperties.Description="Cute dotnet bot waving hi to you!"
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

Inside `MainPage.xaml.cs`, add the method shown below within the `MainPage` class to generate a PDF document from HTML content using IronPDF and save it via the `SaveService` class:

```cs
private void GeneratePDF(object sender, EventArgs e)
{
    ChromePdfRenderer renderer = new ChromePdfRenderer();
    var doc = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF!</h1> <p>I'm using IronPDF with MAUI!</p>");
    // Saves the memory stream as a file.
    SaveService saveService = new SaveService();
    saveService.SaveAndView("IronPDF HTML string.pdf", "application/pdf", doc.Stream);
}
``` 

The remainder of the `MainPage.xaml.cs` and the `SaveService.cs` file arrangements facilitate saving the PDF file to the device, depending on the user's platform.

## Conclusion

IronPDF proves to be an influential and adaptable library suitable for .NET MAUI applications. It supports a varied suite of PDF operations such as merging, splitting, text and image extraction, and more. IronPDF also facilitates the creation of interactive PDF forms and documents.

Various licensing options for IronPDF start at `$liteLicense`, with opportunities for extended support, updates, and royalty-free redistribution options also available for purchase. 

Find more details and guidance by visiting the [C# MAUI PDF Blog Post](https://ironpdf.com/blog/using-ironpdf/csharp-maui-pdf-ironpdf/).