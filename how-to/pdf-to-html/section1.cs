using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Convert PDF to HTML string
string html = pdf.ToHtmlString();
Console.WriteLine(html);

// Convert PDF to HTML file
pdf.SaveAsHtml("myHtml.html");