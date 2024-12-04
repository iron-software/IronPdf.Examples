# How to Draw Lines and Rectangles on PDFs

***Based on <https://ironpdf.com/how-to/draw-line-and-rectangle/>***


Adding lines and rectangles to a PDF document entails the insertion of these geometric figures directly into the contents of a PDF file. This task can generally be accomplished programmatically by employing languages such as C# or VB.NET along with a PDF manipulation library like IronPDF.

In detail, drawing a line means creating a straight visual segment connecting two points. Similarly, drawing a rectangle involves shaping a four-sided figure with specified dimensions and coordinates.

## Draw Line Example

To incorporate lines into a PDF, you can use the `DrawLine` method from the **PdfDocument** object. For setting a color to your line, the **Color** class from the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/) provides ample customization through HEX color codes.

```cs
using IronPdf;
namespace ironpdf.DrawLineAndRectangle
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            // Set parameters as required
            int pageIndex = 0;
            var startPoint = new IronSoftware.Drawing.PointF(200,150);
            var endPoint = new IronSoftware.Drawing.PointF(1000,150);
            int thickness = 10;
            var lineColor = new IronSoftware.Drawing.Color("#000000");
            
            // Execute Line drawing on the PDF
            pdf.DrawLine(pageIndex, startPoint, endPoint, thickness, lineColor);
            
            pdf.SaveAs("exampleLine.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawLine.pdf" width="100%" height="300px">
</iframe>

## Draw Rectangle Example

The `DrawRectangle` method enables the addition of rectangles once a PDF is opened or rendered via the **PdfDocument** object. Use the **RectangleF** class from the [IronDrawing API Documentation](https://ironsoftware.com/open-source/csharp/drawing/docs/) to define the rectangle's parameters easily.

```cs
using IronPdf;
namespace ironpdf.DrawLineAndRectangle
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            // Define the rectangle and color parameters
            int pageIndex = 0;
            var rectangleShape = new IronSoftware.Drawing.RectangleF(200, 100, 1000, 100);
            var borderColor = new IronSoftware.Drawing.Color("#000000");
            var backgroundColor = new IronSoftware.Drawing.Color("#32AB90");
            int borderThickness = 5;
            
            // Execute rectangle drawing on PDF
            pdf.DrawRectangle(pageIndex, rectangleShape, borderColor, backgroundColor, borderThickness);
            
            pdf.SaveAs("exampleRectangle.pdf");
        }
    }
}
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-line-and-rectangle/drawRectangle.pdf" width="100%" height="300px">
</iframe>