# How to Apply Fonts in PDF Files

***Based on <https://ironpdf.com/how-to/webfonts-webicons/>***


Webfonts, which are essential for creating visually cohesive and appealing websites, are hosted on web servers and deployed through web browsers to provide a consistent typographical experience. This approach ensures that even if a user does not have a specific font installed, the website's text appears as intended. In web design, icon fonts comprising symbols and glyphs are also popular for crafting scalable and uniform user interface elements via CSS styling.

CSS is integral in implementing web fonts, as it directs the browser to download specific font files when accessing a website. IronPDF supports the handling of fonts directly from HTML to PDF rendering, accommodating both traditional webfonts and iconographic fonts.

### Getting Started with IronPDF

#### Implementing WebFonts and Icons with IronPDF

IronPDF extends support for various [WebFonts](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) like Google Fonts and Adobe's web font service, as well as icon fonts used in libraries such as Bootstrap and [FontAwesome](https://www.w3schools.com/icons/fontawesome5_intro.asp).

It's common for fonts to require some loading time, which can occasionally result in pages rendering without text if the font fails to load promptly. This can be managed using IronPDF's `WaitFor.AllFontsLoaded` method by setting a maximum wait time, traditionally set at 500ms by default.

Below is an example of integrating the [WebFont](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) named Lobster into your project:

```cs
using IronPdf;

// HTML that includes a WebFont
var html = @"<link href=""https://fonts.googleapis.com/css?family=Lobster"" rel=""stylesheet"">
<p style=""font-family: 'Lobster', serif; font-size:30px;"" >Hello Google Fonts</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Ensure all fonts are loaded
renderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the generated PDF
pdf.SaveAs("font-test.pdf");
```

Discover additional `WaitFor` configurations for handling fonts, JavaScript, and other resources in the '[IronPDF WaitFor Class Documentation](https://ironpdf.com/how-to/waitfor/).'

---

#### Example: Incorporating a Custom Font File

To integrate an existing font file, use the CSS `@font-face` rule. This feature allows for great customization, including embedding fonts in base64-encoded woff file format. Here’s how to incorporate a custom font, specifically the [Pixelify Sans Font](https://fonts.google.com/specimen/Pixelify+Sans):

```cs
using IronPdf;

// Embedding a custom font
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
<p>Custom font utilized here</p>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate PDF from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Output the PDF
pdf.SaveAs("customFont.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/webfonts-webicons/customFont.pdf" width="100%" height="400px">
</iframe>

---

### Font Limitations on Microsoft Azure

The [Azure hosting platform](https://azure.microsoft.com/en-us/) accommodates different capabilities across its service tiers. Notably, the lower shared web app tiers on Azure do not support the loading of SVG fonts. Conversely, higher-tier services such as VPS and Web Role offer enhanced support and are not restricted in this manner.