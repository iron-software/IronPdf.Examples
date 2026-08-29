# How to Set Fonts in PDFs

> Full guide: [How to Set Fonts in PDFs](https://ironpdf.com/how-to/webfonts-webicons/)


A webfont is specifically created for use on websites. Hosted on web servers and downloaded by browsers, these fonts ensure that text appears consistent and aesthetically pleasing across different devices, even if the device does not have the font installed locally. Additionally, icon fonts—which include symbols and glyphs—are frequently employed in web design to enable scalable, customizable icons and achieve consistent visual presentations using CSS.

CSS facilitates the use of web fonts by allowing the specification of fonts to be downloaded when a website loads. IronPDF fully supports the process of loading fonts and rendering them into PDFs from HTML.

## Quickstart: Using WebFonts in PDF Generation

Use web and icon fonts in PDF documents with IronPDF. This guide renders HTML that carries custom fonts and saves the styled document.

```cs
var pdfRenderer = new IronPdf.ChromePdfRenderer { 
    RenderingOptions = { 
        WaitFor = IronPdf.Rendering.WaitFor.AllFontsLoaded(2000)
    } 
};
var htmlContent = "<link href=\"https://fonts.googleapis.com/css?family=Lobster\" rel=\"stylesheet\">" +
                  "<link href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css\" rel=\"stylesheet\">" +
                  "<p style=\"font-family:'Lobster', serif; font-size:30px;\">Explore Google Font</p>" +
                  "<i class=\"fa fa-coffee\" style=\"font-size:40px; color:#b00;\"></i>";
var pdf = pdfRenderer.RenderHtmlAsPdf(htmlContent);
pdf.SaveAs("styled-fonts-pdf.pdf");
```

## Using WebFonts and Icons Example

IronPDF supports utilizing [WebFonts](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) such as Google Fonts and Adobe’s web font API, as well as icon fonts employed by Bootstrap and [FontAwesome](https://www.w3schools.com/icons/fontawesome5_intro.asp).

Since fonts might require some time to load fully, rendering them improperly could result in a blank PDF page. The method `WaitFor.AllFontsLoaded` is useful in these scenarios by allowing you to set a maximum waiting duration. By default, this duration stands at 500 milliseconds.

Below is a practical example using a [WebFont](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) named Lobster:

```csharp
using IronPdf;

// Setup HTML with web font
var htmlContent = "<link href=\"https://fonts.googleapis.com/css?family=Lobster\" rel=\"stylesheet\">" +
                  "<p style=\"font-family: 'Lobster', serif; font-size:30px;\" >Welcome to Google Fonts</p>";

var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);  // Configure waiting time

// Convert HTML to PDF
PdfDocument createdPdf = pdfRenderer.RenderHtmlAsPdf(htmlContent);

// Save the generated PDF
createdPdf.SaveAs("example-fonts.pdf");
```

Discover additional `WaitFor` configurations related to fonts, JavaScript, HTML nodes, and network idle states at the ['IronPDF WaitFor Class Documentation'](https://ironpdf.com/how-to/waitfor/).

---

## Importing Font Files Example

When utilizing your own fonts, employ the [@font-face](https://developer.mozilla.org/en-US/docs/Web/CSS/@font-face) rule within CSS. This technique also applies when incorporating base64-encoded WOFF files. In the example below, we will be using [Pixelify Sans Font](https://fonts.google.com/specimen/Pixelify+Sans).

```csharp
using IronPdf;

// Define HTML with local font
string htmlSetup = @"<!DOCTYPE html>
<html>
<head>
<style>
@font-face {
    font-family: 'Pixelify';
    src: url('fonts/PixelifySans-VariableFont_wght.ttf');
}
p {
    font-family: 'Pixelify';
    font-size: 70px;
}
</style>
</head>
<body>
<p>Unique Custom Font Example!</p>
</body>
</html>";

var renderer = new ChromePdfRenderer();
PdfDocument document = renderer.RenderHtmlAsPdf(htmlSetup);
document.SaveAs("customizedFont.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/webfonts-webicons/customFont.pdf" width="100%" height="400px">
</iframe>

---

## Considerations Using Azure PDF Services

The [Azure hosting platform](https://azure.microsoft.com/en-us/) may restrict the loading of SVG fonts at lower shared app tier levels. Nevertheless, Azure's VPS and Web Role configurations support web font rendering without the restrictions seen in lower tiers.