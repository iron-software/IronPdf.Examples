# Generate PDF Documents in .NET MAUI Projects Using Visual Studio

***Based on <https://ironpdf.com/how-to/net-maui-create-pdf-tutorial/>***


## Overview

The .NET Multi-platform App UI (.NET MAUI) is a framework designed for building cross-platform native mobile and desktop applications using C# and XAML. As a successor to .NET Core and .NET Framework, it facilitates the development of applications across desktop, web, and mobile platforms employing a single codebase and allows the introduction of platform-specific code and resources when needed. For generating PDF files within .NET MAUI applications, libraries such as IronPDF can be deployed effectively.

## Key Features of IronPDF

IronPDF stands out as an advanced library capable of converting HTML to PDF, mirroring the capabilities of a browser. It seamlessly creates, edits, and manipulates PDFs within .NET environments, leveraging CSS and JavaScript to render complex web pages. By loading HTML content into a string or stream and processing it through IronPDF, developers can convert it into a PDF and manage its output smoothly.

Utilized widely across various .NET projects, this guide focuses on integrating IronPDF within .NET MAUI applications.

## Preparation

To begin converting HTML into PDF using IronPDF in a .NET MAUI environment, ensure you have:

- Visual Studio installed with .NET Framework
- An operational .NET MAUI Blazor application or a standard .NET MAUI project
- Reliable internet connectivity to install IronPDF via Visual Studio's Command-line.

## Generating PDF Files with .NET MAUI

1. Start by creating a new .NET MAUI PDF project in Visual Studio.
2. Install IronPDF using the NuGet:
   ```shell
   /Install-Package IronPdf
   ```
   
   ![Installing IronPDF](https://www.ironsoftware.com/static-assets/pdf/blog/csharp-maui-pdf-ironpdf/csharp-maui-pdf-ironpdf-6.webp)

3. Develop the User Interface of your .NET MAUI Content Pages.
4. Use the `ChromePdfRenderer.RenderHtmlAsPdf` method to generate PDF files.
5. Utilize platform-specific code to store the PDF on users' devices.

### Installation of IronPDF Using the Command-Line

Employing the Visual Studio Command-Line, follow these steps to integrate IronPDF within your project:

1. Navigate to "Tools" -> "NuGet Package Manager" -> "Package Manager Console" in Visual Studio.
2. Execute the command below:
   ```shell
   /Install-Package IronPdf
   ```

## Crafting PDF Documents in .NET MAUI with IronPDF

In your new .NET MAUI project, the **MainPage.xaml** serves as the foundation for UI design. Edit this file to adjust UI components according to your design preferences.

Consider the following XAML example for `MainPage.xaml`:

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
                Source="dotnet_bot.png"
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

Post-updating your UI, add the necessary code in `MainPage.xaml.cs` for PDF creation:

```cs
private void GeneratePDF(object sender, EventArgs e)
{
    ChromePdfRenderer renderer = new ChromePdfRenderer();
    var doc = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF!</h1> <p>I'm using IronPDF MAUI!</p>");
    // Save the PDF as a file using memory stream.
    SaveService saveService = new SaveService();
    saveService.SaveAndView("IronPDF HTML string.pdf", "application/pdf", doc.Stream);
}
```

To deploy the PDF file saving functionality, integrate a new `SaveService.cs` class in your project, and apply platform-specific installations.

## Conclusion

IronPDF integrates smoothly with .NET MAUI, offering extensive PDF manipulation capabilities like merging, splitting, extracting content, and filling forms. It supports generating interactive documents across different platforms, making it an indispensable tool for .NET MAUI developers.

IronPDF offers various licensing options starting from `$liteLicense`, with additional support, updates, and royalty-free redistribution options available for purchase.