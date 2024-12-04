using IronPdf;
using IronSoftware.Drawing;
using System;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Convert PDF to HTML string
string html = pdf.ToHtmlString();
Console.WriteLine(html);

// Convert PDF to HTML file
pdf.SaveAsHtml("myHtml.html");

// PDF to HTML configuration options
HtmlFormatOptions htmlformat = new HtmlFormatOptions();
htmlformat.BackgroundColor = Color.White;
htmlformat.H1Color = Color.Blue;
htmlformat.H1FontSize = 25;
htmlformat.H1TextAlignment = TextAlignment.Center;
htmlformat.PdfPageMargin = 10;

// Convert PDF to HTML file
pdf.SaveAsHtml("myHtmlConfigured.html", true, "Hello World", htmlFormatOptions: htmlformat);
