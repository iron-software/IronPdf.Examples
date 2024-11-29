# Setting Fonts in PDF Documents

***Based on <https://ironpdf.com/how-to/webfonts-webicons/>***


Webfonts are specifically designed for websites, hosted on web servers and used to ensure that text appears consistent and visually engaging on various devices regardless of the local fonts installed. Icon fonts also play a crucial role in web design, allowing for scalable and customizable icons through CSS, which aids in maintaining a visually coherent interface.

CSS can specify web fonts to be downloaded automatically when someone visits your webpage. IronPDF extends this functionality to PDFs, where it supports loading and rendering fonts from HTML content.

## Implementing WebFonts and Icons with IronPDF

IronPDF has robust support for WebFonts (like those from Google Fonts and Adobe’s web font API) and popular icon fonts such as Bootstrap icons and [FontAwesome](https://www.w3schools.com/icons/fontawesome5_intro.asp).

To ensure fonts load correctly and avoid any rendering issues such as blank pages, IronPDF includes a `WaitFor.AllFontsLoaded` method. This method enables you to define a maximum waiting period for font loading, with the default set at 500ms.

Below is an example of incorporating a [WebFont](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) named Lobster into your application using IronPDF:

```cs
using IronPdf;
namespace ironpdf.WebfontsWebicons
{
    public class SessionExample
    {
        public void Execute()
        {
            // HTML with a webfont link
            var html = @"<link href=""https://fonts.googleapis.com/css?family=Lobster"" rel=""stylesheet"">
            <p style=""font-family: 'Lobster', serif; font-size:30px;"">Hello Google Fonts</p>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Ensure all fonts are loaded
            renderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);
            
            // Generate PDF from HTML
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Save the generated PDF
            pdf.SaveAs("example-font.pdf");
        }
    }
}
```

Discover additional waiting options for fonts, scripts, HTML elements, and network states in the [IronPDF WaitFor Class Documentation](https://ironpdf.com/how-to/waitfor/).

## Embedding Custom Font Files Into PDFs

To include custom fonts in your PDFs, you can use the `@font-face` rule in CSS. This method is effective when combining CSS rules with base64-encoded woff files. Here’s how you might incorporate a custom font named Pixelify Sans:

```cs
using IronPdf;
namespace ironpdf.WebfontsWebicons
{
    public class CustomFontExample
    {
        public void Execute()
        {
            // HTML with embedded custom font
            string html = @"<!DOCTYPE html>
            <html>
            <head>
            <style>
            @font-face {font-family: 'Pixelify';
            src: url('fonts\PixelifySans-VariableFont_wght.ttf');
            }
            p {
                font-family: 'Pixelify';
                font-size: 70px;
            }
            </style>
            </head>
            <body>
            <p>Experiment with custom font.</p>
            </body>
            </html>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Convert HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Output the PDF
            pdf.SaveAs("custom-font-example.pdf");
        }
    }
}
```

View the live example [here](https://ironpdf.com/static-assets/pdf/how-to/webfonts-webicons/customFont.pdf).

## Considerations for Azure PDF Rendering

When deploying on Azure, be aware that its lower-tier shared web apps do not support SVG fonts. Only the VPS and Web Role environments, which are not limited by the same sandbox, can render web fonts.