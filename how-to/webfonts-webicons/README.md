# Setting Fonts in PDF Documents

Webfonts are designed specifically for use on websites. Hosted on web servers, these fonts ensure that text appears consistently attractive across different websites by being downloaded by web browsers, regardless of the local fonts users might have available. Furthermore, web design frequently utilizes icon fonts that encompass symbols and glyphs, allowing designers to create scalable, customizable icons while achieving a consistent user interface via CSS.

CSS can employ these web fonts by specifying which font files should be downloaded when a website is visited. IronPDF supports loading and rendering these fonts to PDF from HTML.

## Implementing WebFonts and Icons

IronPDF fully supports both [WebFonts](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts) like Google Fonts and Adobe’s web font API, as well as icon fonts used by systems such as Bootstrap and [FontAwesome](https://www.w3schools.com/icons/fontawesome5_intro.asp).

When working with fonts, it’s essential to allow time for them to load properly; otherwise, they might not display and could even result in a completely blank page. IronPDF’s `WaitFor.AllFontsLoaded` method ensures fonts have fully loaded by setting a maximum delay time, which defaults to 500ms.

Below is a practical example that incorporates the [WebFont Lobster](https://developer.mozilla.org/en-US/docs/Learn/CSS/Styling_text/Web_fonts).

```cs
using IronPdf;

// HTML contains a webfont reference
var html = @"<link href=""https://fonts.googleapis.com/css?family=Lobster"" rel=""stylesheet"">
<p style=""font-family: 'Lobster', serif; font-size:30px;""> Hello Google Fonts</p>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Ensure the font loads before rendering
renderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Save the PDF document
pdf.SaveAs("font-test.pdf");
```

Further details on the `WaitFor` class and its various options can be found at '[How to Use the WaitFor Class to Delay C# PDF Rendering](https://ironpdf.com/how-to/waitfor/)'.

<hr>

## Embedding Font Files

You can also integrate your own font files using the [`@font-face`](https://developer.mozilla.org/en-US/docs/Web/CSS/@font-face) rule in CSS, which is effective with base64-encoded woff files in combination. Here’s how you might apply this for a font like [Pixelify Sans Font](https://fonts.google.com/specimen/Pixelify+Sans):

```cs
using IronPdf;

// HTML with inline custom font definition
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
<p>Custom font usage</p>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate PDF from HTML
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Output the PDF file
pdf.SaveAs("customFont.pdf");
```

Embedded PDF view:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/webfonts-webicons/customFont.pdf" width="100%" height="400px">
</iframe>

<hr>

## Challenges With Azure PDF Rendering

The [Azure hosting platform](https://azure.microsoft.com/en-us/) presents limitations with certain services, specifically their shared lower web app tiers, which do not support SVG font loading. On the other hand, Azure's VPS and Web Role environments offer more flexibility and do support web font rendering.