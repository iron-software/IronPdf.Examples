# Utilizing CSS for HTML Content

The `screen` media type in CSS is designed for devices like computer screens, focusing on enhancing the presentation of web content through visual designs and interactivity.

On the other hand, the `print` media type targets printed output. It enhances how pages are rendered on paper, for instance, by tweaking font sizes and margins, and sometimes concealing non-essential elements for print.

## Screen vs. Print CSS in CSS3

IronPDF, a tool that converts HTML to PDF in C#, seamlessly supports rendering using the screen type CSS by default. This is quite handy given that stylesheets for print are generally less elaborated and commonly used than those for screens.

CSS3 introduces styles tailored exclusively for print media, while maintaining others specifically for viewing in web browsers. IronPDF is capable of handling both scenarios effectively.

To explore creating a print-specific stylesheet for your HTML, visit: [CSS perfect print stylesheet](https://www.jotform.com/blog/css-perfect-print-stylesheet-98272/).

Deciding which CSS media type is more effective depends largely on the context and needs. Experimenting with both media types through trial and error can uncover which is more applicable for your specific needs.

![Comparison of Print Stylesheet](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%201.webp)
![Comparison of Screen Stylesheet](https://ironpdf.com/static-assets/pdf/how-to/pixel-perfect-html-to-pdf/Comparison%20of%20Screen%20and%20Print%202.webp)

<hr>

## Ensuring Repeat Headers in Tables Across Pages

In scenarios where HTML tables span across several pages, utilizing the **PdfCssMediaType.Print** setting for the **CssMediaType** ensures that table headers repeat at the top of each new page. Conversely, the **PdfCssMediaType.Screen** setting will have the headers appear only once.

Ensure that the table headers are wrapped in a `<thead>` tag for accurate detection. Below, we demonstrate how to convert the '[tableHeader.html](https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.html)' file into a PDF to observe how headers are handled:

```cs
using IronPdf;
using IronPdf.Rendering;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Set smaller paper size
renderer.RenderingOptions.SetCustomPaperSizeinPixelsOrPoints(600, 400);

// Select CSS media type for formatting
renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;

// Convert HTML to PDF
PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableHeader.html");

// Save the PDF file
pdf.SaveAs("tableHeader.pdf");
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/html-to-pdf-responsive-css/tableHeader.pdf" width="100%" height="400px">
</iframe>