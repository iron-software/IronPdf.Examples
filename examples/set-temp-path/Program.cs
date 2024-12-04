using IronPdf;
using System;
using System.IO;

// Set Application scope Temp Path (On Linux /tmp is a good choice)
var MyTempPath = @"C:\Safe\Location\";

Environment.SetEnvironmentVariable("TEMP", MyTempPath);
Environment.SetEnvironmentVariable("TMP", MyTempPath);

// Set IronPDF Temp Path
Installation.TempFolderPath = Path.Combine(MyTempPath, "IronPdfTemp");

// Your PDF Generation and editing code here
var renderer = new ChromePdfRenderer();
var doc = renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
doc.SaveAs("example.pdf");
