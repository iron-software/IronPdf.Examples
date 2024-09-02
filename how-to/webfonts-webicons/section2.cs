using IronPdf;

// Import custom font
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
<p>Custom font</p>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Export the PDF
pdf.SaveAs("customFont.pdf");