# How to Sanitize PDF Documents

***Based on <https://ironpdf.com/how-to/sanitize-pdf/>***


Sanitizing PDF documents is an essential procedure that offers numerous benefits. It primarily enhances document security by eliminating potentially dangerous elements such as embedded scripts or metadata, minimizing the threat of malicious exploitation. Furthermore, it boosts compatibility across various platforms by stripping out complex or proprietary components, improving accessibility. Through reducing the chances of data leaks and maintaining document integrity, the process of sanitizing PDFs plays a vital role in safeguarding the reliability and security of document management systems.

### Getting Started with IronPDF

---

## Example: Sanitizing a PDF

The essence of sanitizing a PDF involves transforming the PDF into an image format, effectively stripping away JavaScript code, embedded objects, and interactive buttons, and then reconverting it to a PDF. IronPDF supports both Bitmap and SVG formats for this purpose. The advantages of using SVG over Bitmap include:
- Faster sanitization process
- Generates a searchable PDF
- Possible inconsistencies in layout

```cs
using IronPdf;

// Load the PDF document
PdfDocument originalPdf = PdfDocument.FromFile("sample.pdf");

// Sanitize using Bitmap
PdfDocument bitmapSanitizedPdf = Cleaner.SanitizeWithBitmap(originalPdf);

// Sanitize using SVG
PdfDocument svgSanitizedPdf = Cleaner.SanitizeWithSvg(originalPdf);

// Save the sanitized PDFs
bitmapSanitizedPdf.SaveAs("bitmapSanitized.pdf");
svgSanitizedPdf.SaveAs("svgSanitized.pdf");
```

## Example: Scanning a PDF for Vulnerabilities

The `ScanPdf` method from the `Cleaner` class is designed to inspect a PDF for potential vulnerabilities using a default YARA file. Users can also supply their custom YARA file as a second parameter to tailor the scanning process to specific needs.

A YARA file targeted at PDFs includes a set of rules meant to identify traits linked with malicious PDFs, assisting security professionals in automating the detection of threats and implementing preventive measures.

```cs
using IronPdf;
using System;

// Load the PDF document
PdfDocument pdfToScan = PdfDocument.FromFile("sample.pdf");

// Perform a security scan on the PDF
CleanerScanResult scanResult = Cleaner.ScanPdf(pdfToScan);

// Display the scan results
Console.WriteLine(scanResult.IsDetected);
Console.WriteLine(scanResult.Risks.Count);
```