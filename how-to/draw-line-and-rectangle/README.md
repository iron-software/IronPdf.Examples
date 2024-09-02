# How to Draw Lines and Rectangles on PDFs

Adding lines and rectangles to a PDF involves incorporating specific geometric shapes directly into a PDF's content. This enhancement is typically performed using .NET programming languages like C# or VB.NET, along with libraries such as IronPDF.

In essence, drawing lines involves creating a visible segment between specified start and end points. Similarly, drawing a rectangle consists of defining a four-sided figure with set dimensions and placement within the document.

## Draw Line Example

The `DrawLine` method linked to the **PdfDocument** object allows you to incorporate lines into an existing PDF. The **Color** class from [IronDrawing](https://ironsoftware.com/open-source/csharp/drawing/docs/) facilitates the application of a specific color to the line via a HEX code.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Text</h1>");

// Set the necessary parameters
int pageIndex = 0;
var start = new IronSoftware.Drawing.PointF(200,150);
var end = new IronSoftware.Drawing.PointF(1000,150);
int lineWidth = 10;
var lineColor = new IronSoftware.Drawing.Color("#000000");

// Draw the line on the PDF
pdf.DrawLine(pageIndex, start, end, lineWidth, lineColor);

pdf.SaveAs("lineExample.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawLine.pdf" width="100%" height="300px">
</iframe>

## Draw Rectangle Example

The `DrawRectangle` method in the **PdfDocument** object is used to introduce rectangles into PDFs. This method becomes usable after a PDF is opened or created, allowing you to set the rectangle's coordinates, dimensions, and color properties with the **RectangleF** class from [IronDrawing](https://ironsoftware.com/open-source/csharp/drawing/docs/).

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Text</h1>");

// Define the necessary parameters
int pageIndex = 0;
var rectangle = new IronSoftware.Drawing.RectangleF(200, 100, 1000, 100);
var borderColor = new IronSoftware.Drawing.Color("#000000");
var fillColor = new IronSoftware.Drawing.Color("#32AB90");
int borderWidth = 5;

// Execute the rectangle drawing on the PDF
pdf.DrawRectangle(pageIndex, rectangle, borderColor, fillColor, borderWidth);

pdf.SaveAs("rectangleExample.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawRectangle.pdf" width="100%" height="300px">
</iframe> 

This refashioned content presents the concepts with a blend of varied sentence styles and enriched technical details while adjusting code examples for enhanced clarity and demonstrational purposes.