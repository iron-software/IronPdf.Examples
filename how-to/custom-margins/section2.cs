const string htmlWithStyle = @"
<!DOCTYPE html>
<html>
    <head>
        <style>
            body {margin: 50mm 50mm 50mm 50mm;}
        </style>
    </head>
<body>
    <h1>Hello World!</h1>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderingOptions.MarginTop = 30;
renderer.RenderingOptions.MarginLeft = 30;
renderer.RenderingOptions.MarginRight = 30;
renderer.RenderingOptions.MarginBottom = 30;

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlWithStyle);
pdf.SaveAs("PdfWithCustomMargins.pdf");