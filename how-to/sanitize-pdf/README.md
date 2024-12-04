# How to Sanitize PDF

***Based on <https://ironpdf.com/how-to/sanitize-pdf/>***


Sanitizing PDF documents is an essential practice that offers several advantages. It primarily bolsters document security by eliminating potentially hazardous components such as embedded scripts or metadata, thus diminishing the likelihood of exploitation by malicious actors. Moreover, it enhances compatibility across diverse platforms by stripping away complex or proprietary elements, thereby improving accessibility. By reducing the risks associated with data leakage and maintaining document integrity, the sanitization of PDFs plays a vital role in fortifying the security and reliability of document management processes.

## Sanitize PDF Example

The technique for sanitizing a PDF involves converting the PDF file into an image format, which effectively strips away JavaScript code, embedded objects, and buttons, and then re-converting it back into a PDF. We support both Bitmap and SVG image formats for this process. The advantages of using SVG over Bitmap include:
- Faster processing time than sanitizing with a bitmap
- Produces a PDF that retains text searchability
- Potential variations in layout

```cs
using IronPdf;
namespace ironpdf.SanitizePdf
{
    public class SanitizeExample
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument document = PdfDocument.FromFile("sample.pdf");
            
            // Sanitization using Bitmap
            PdfDocument bitmapSanitized = Cleaner.SanitizeWithBitmap(document);
            
            // Sanitization using SVG
            PdfDocument svgSanitized = Cleaner.SanitizeWithSvg(document);
            
            // Save the sanitized PDFs
            bitmapSanitized.SaveAs("bitmapSanitized.pdf");
            svgSanitized.SaveAs("svgSanitized.pdf");
        }
    }
}
```

## Scan PDF Example

To verify possible vulnerabilities in a PDF, utilize the `ScanPdf` method from the `Cleaner` class. It initially utilizes a default YARA file to conduct the check, but you can also supply a custom YARA file as the second parameter to meet specific security needs.

A YARA file is a set of rules or patterns designed to identify characteristics typical of malicious PDF files. These rules are instrumental for security analysts in automating the detection of potential threats and implementing measures to address these risks effectively.

```cs
using System;
using IronPdf;
namespace ironpdf.SanitizePdf
{
    public class ScanExample
    {
        public void Execute()
        {
            // Load the PDF document
            PdfDocument document = PdfDocument.FromFile("sample.pdf");
            
            // Perform a scan on the PDF
            CleanerScanResult scanResult = Cleaner.ScanPdf(document);
            
            // Display the scan results
            Console.WriteLine(scanResult.IsDetected);
            Console.WriteLine(scanResult.Risks.Count);
        }
    }
}
```