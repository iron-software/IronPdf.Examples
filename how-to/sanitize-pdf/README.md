# How to Sanitize PDF

***Based on <https://ironpdf.com/how-to/sanitize-pdf/>***


Sanitizing PDF files is essential for multiple reasons. It primarily protects the documents by eliminating dangerous elements such as embedded scripts or metadata, reducing the chances of attacks from malicious sources. Additionally, PDF sanitation simplifies the file structure by removing complex and proprietary components, increasing cross-platform compatibility and accessibility. This plays a vital role in preventing data breaches and maintaining the integrity of documents, thereby enhancing trust and security in document management systems.

## Straightforward PDF Sanitization with IronPDF

Secure your PDF files effortlessly with the `Cleaner` class from IronPDF. This quickstart guide shows you how to use C# .NET to sanitize a PDF promptly using the `ScanPdf` method. By following the example below, you will be able to remove risks such as embedded scripts and metadata, thereby securing the integrity and confidentiality of your PDF files.

```cs
:title=Sanitize a PDF with a single line of code!
IronPdf.Cleaner.SanitizeWithSvg(PdfDocument.FromFile("input.pdf")).SaveAs("sanitized.pdf");
```

## Detailed Example of PDF Sanitization

The secret to effectively sanitizing a PDF involves converting the PDF into an image format, removing items like JavaScript code, embedded objects, and interactive buttons, and then reconverting it into a PDF. We offer options to sanitize using Bitmap or SVG formats. Below are some advantages of using SVG over Bitmap:

- Faster processing time compared to Bitmap
- Creates a PDF that remains searchable
- Note: Layout consistency may vary

```csharp
using IronPdf;

// Load the PDF document
PdfDocument originalPdf = PdfDocument.FromFile("sample.pdf");

// Sanitize using Bitmap method
PdfDocument bitmapSanitizedPdf = Cleaner.SanitizeWithBitmap(originalPdf);

// Sanitize using SVG method
PdfDocument svgSanitizedPdf = Cleaner.SanitizeWithSvg(originalPdf);

// Save the sanitized PDFs
bitmapSanitizedPdf.SaveAs("bitmap-sanitized.pdf");
svgSanitizedPdf.SaveAs("svg-sanitized.pdf");
```

### Customizing Sanitization Options

IronPDF's `Cleaner` classes don't just sanitize; they allow for customization of the PDF rendering process through the `ChromeRenderOptions`. For instance, you can alter the PDF's margin sizes, paper dimensions, and orientation. Both `SanitizeWithBitmap` and `SanitizeWithSvg` can be enhanced by passing a `ChromeRenderOptions` object as a second, optional parameter. Here’s how to adjust the bottom margin to 50 pixels:

For a detailed guide on all the available options, please visit [here](https://ironpdf.com/how-to/rendering-options/).

```csharp
using IronPdf;

// Adjust rendering settings
var renderOptions = new ChromePdfRenderOptions();
renderOptions.MarginBottom = 50;

// Load the PDF document
PdfDocument pdfDoc = PdfDocument.FromFile("sample.pdf");

// Sanitize and apply custom render options
PdfDocument customizedBitmapPdf = Cleaner.SanitizeWithBitmap(pdfDoc, renderOptions);
PdfDocument customizedSvgPdf = Cleaner.SanitizeWithSvg(pdfDoc, renderOptions);

// Save the customized PDFs
customizedBitmapPdf.SaveAs("customized-bitmap.pdf");
customizedSvgPdf.SaveAs("customized-svg.pdf");
```

## Vulnerability Scanning in PDFs

The `ScanPdf` method in IronPDF's `Cleaner` class is designed to detect potential vulnerabilities in PDF files. It uses the default YARA rule set, but you can also upload a custom YARA file to tailor the scanning process to your specific needs.

A YARA file is essentially a set of rules for identifying characteristics usually found in malicious PDFs. These rules aid in automating the detection of threats, thus enhancing document security.

```csharp
using IronPdf;
using System;

// Load the PDF document
PdfDocument scannedPdf = PdfDocument.FromFile("sample.pdf");

// Execute the PDF scan
CleanerScanResult scanResults = Cleaner.ScanPdf(scannedPdf);

// Display the scanning outcomes
Console.WriteLine(scanResults.IsDetected);
Console.WriteLine(scanResults.Risks.Count);
```

Discover more about what you can do by visiting our comprehensive tutorial page here: [Sign and Secure PDFs](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/)