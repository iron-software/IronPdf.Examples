using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render unless there are at most 5 network activities for at least 1000ms
renderer.RenderingOptions.WaitFor.NetworkIdle(1000, 5);

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");