# Stamping Text and Images onto PDF Documents

***Based on <https://ironpdf.com/how-to/stamp-text-image/>***


Adding text and images to PDF documents, known as "stamping," allows users to overlay new content over existing PDF files. This new content, often labeled as a "stamp," could include text, graphics, or both, and is generally used for inserting additional details, tags, watermarks, or annotations onto a PDF.

IronPdf offers four different types of stamping tools: the **TextStamper**, **ImageStamper**, **HTMLStamper**, and **BarcodeStamper**, with the HTMLStamper being particularly versatile due to its capability to incorporate full HTML and CSS styling.

<h3>Initiate with IronPDF</h3>

-----

## Example of Text Stamping

Start by constructing an instance of the **TextStamper**. This instance holds all settings that determine the appearance of the text stamp. Use the `ApplyStamp` method along with your TextStamper instance. Set the `Text` property to your desired text, and further tailor the appearance with options like font family and style, and the positioning of the text stamp.

```cs
using IronPdf;
using IronPdf.Editing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Initialize text stamper
TextStamper textStamper = new TextStamper()
{
    Text = "This is a Text Stamper example!",
    FontFamily = "Arial",
    UseGoogleFont = true,
    FontSize = 24,
    IsBold = true,
    IsItalic = false,
    VerticalAlignment = VerticalAlignment.Top,
};

// Applying the text stamper
pdf.ApplyStamp(textStamper);

pdf.SaveAs("exampleTextStamp.pdf");
```

### Visualized PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/stamp-text-image/stampText.pdf" width="100%" height="400px">
</iframe>

For multiple lines of text within a text stamper, utilize the HTML `<br>` tag. For instance, "Hello,<br>World!" will display "Hello," on the first line followed by "World!" on the second line.

<hr>

## Example of Image Stamping

Create an **ImageStamper** object similarly and use the `ApplyStamp` method to apply the image onto the document. You can specify the exact page for the image stamp using the `page index` parameter.

Page indexes are zero-based.

```cs
using IronPdf;
using IronPdf.Editing;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Set up image stamper
ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
{
    VerticalAlignment = VerticalAlignment.Ce...