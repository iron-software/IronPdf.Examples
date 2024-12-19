# Adding Lines and Rectangles to PDF Documents

***Based on <https://ironpdf.com/how-to/draw-line-and-rectangle/>***


When we refer to adding lines and rectangles to a PDF document, we are discussing the technique of integrating specific geometric figures—lines and rectangles—into a PDF's visual layout. This insertion is commonly carried out through programming, particularly using C# or VB.NET, coupled with a supportive library such as IronPDF.

Drawing a line involves the creation of a distinct line segment defined by its starting and ending coordinates. On the other hand, drawing a rectangle involves specifying a quadrilateral based on its size and position on the document.

<h3>Introduction to IronPDF</h3>

--------------------------------------

## Example: Drawing a Line

Using the `DrawLine` method from the **PdfDocument** class in IronPDF, you can seamlessly introduce lines into any existing PDF. The **Color** class, as described in the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/), allows you to specify the line color using a HEX code.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Header</h1>");

// Set up the necessary parameters
int pageIndex = 0;
var startPoint = new IronSoftware.Drawing.PointF(200,150);
var endPoint = new IronSoftware.Drawing.PointF(1000,150);
int lineThickness = 10;
var lineColor = new IronSoftware.Drawing.Color("#000000");

// Execute the draw line operation
pdf.DrawLine(pageIndex, startPoint, endPoint, lineThickness, lineColor);

pdf.SaveAs("drawLine.pdf");
```

### Visual Output of PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawLine.pdf" width="100%" height="300px">
</iframe>

## Example: Drawing a Rectangle

Utilize the `DrawRectangle` method available in the **PdfDocument** class to insert rectangles into PDF files. After loading or rendering the PDF, you can easily set the coordinates, dimensions, and colors with the **RectangleF** class, as detailed in the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/).

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Header</h1>");

// Set up the necessary parameters
int pageIndex = 0;
var rectangleSpecs = new IronSoftware.Drawing.RectangleF(200, 100, 1000, 100);
var borderColor = new IronSoftware.Drawing.Color("#000000");
var backgroundColor = new IronSoftware.Drawing.Color("#32AB90");
int borderThickness = 5;

// Execute the draw rectangle operation
pdf.DrawRectangle(pageIndex, rectangleSpecs, borderColor, backgroundColor, borderThickness);

pdf.SaveAs("drawRectangle.pdf");
```

### Visual Output of PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawRectangle.pdf" width="100%" height="300px">
</iframe>