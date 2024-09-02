using IronPdf;
using System;

// Import PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Scan PDF
CleanerScanResult result = Cleaner.ScanPdf(pdf);

// Output the result
Console.WriteLine(result.IsDetected);
Console.WriteLine(result.Risks.Count);