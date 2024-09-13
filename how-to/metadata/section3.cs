using IronPdf;
using IronPdf.MetaData;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

PdfCustomMetadataProperties customProperties = pdf.MetaData.CustomProperties;

// Add custom property
customProperties.Add("foo", "bar"); // Key: foo, Value: bar

// Edit custom property
customProperties["foo"] = "baz";