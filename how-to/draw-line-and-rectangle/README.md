# Enhancing PDFs with Lines and Rectangles

***Based on <https://ironpdf.com/how-to/draw-line-and-rectangle/>***


Adding geometric shapes, such as lines and rectangles, to PDF documents enriches the content and visual appeal. This type of enhancement can be achieved programmatically using languages like C# or VB.NET along with a library such as IronPDF.

This guide will show you how easy it is to insert clean, professional-looking lines and rectangles into your PDF files using IronPDF. Let's begin by exploring the methods you'll use.

## Easy Steps to Add Lines and Rectangles Using IronPDF

Unlock the potential of your PDFs by incorporating lines and rectangles through IronPDF. This quickstart guide will introduce you to the `DrawLine` and `DrawRectangle` methods. These methods enable you to effortlessly add dynamic graphical elements to your documents. Let’s dive right in.

```cs
:title=Quick Shape Drawing in PDFs
IronPdf.PdfDocument pdf = IronPdf.PdfDocument.FromFile("input.pdf");
pdf.DrawLine(10, 10, 200, 10, "#FF0000", 2);
pdf.SaveAs("output.pdf");
```

## Example of Drawing Lines

The `DrawLine` method is part of the **PdfDocument** class and allows for the insertion of line elements within a PDF. You can use the **IronSoftware.Drawing.Color** class which is found in the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/) to set the color of the line using HEX codes.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Set up the necessary parameters
int pageIndex = 0;
var start = new IronSoftware.Drawing.PointF(200, 150);
var end = new IronSoftware.Drawing.PointF(1000, 150);
int width = 10;
var color = new IronSoftware.Drawing.Color("#000000");

// Drawing a line in the PDF
pdf.DrawLine(pageIndex, start, end, width, color);

pdf.SaveAs("drawLine.pdf");
```

### View the PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawLine.pdf" width="100%" height="300px">
</iframe>

## Example of Drawing Rectangles

Using the `DrawRectangle` method, rectangles can be added to PDF files after the document is loaded or rendered. This method is part of the **PdfDocument** class too. Define the rectangle using parameters from the **RectangleF** class provided in the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/).

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Setting up necessary parameters
int pageIndex = 0;
var rectangle = new IronSoftware.Drawing.RectangleF(200, 100, 1000, 100);
var lineColor = new IronSoftware.Drawing.Color("#000000");
var fillColor = new IronSoftware.Drawing.Color("#32AB90");
int lineWidth = 5;

// Rectangular shape addition to PDF
pdf.DrawRectangle(pageIndex, rectangle, lineColor, fillColor, lineWidth);

pdf.SaveAs("drawRectangle.pdf");
```

### View the PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawRectangle.pdf" width="100%" height="300px">
</iframe>