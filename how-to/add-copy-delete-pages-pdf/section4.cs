using IronPdf;
using System.Collections.Generic;

PdfDocument pdf = PdfDocument.FromFile("full_report.pdf");

// Remove a single page
pdf.RemovePage(0);

// Remove multiple pages
pdf.RemovePages(new List<int> { 2, 3 });