using IronPdf;

// Initiate PDF Renderer
var renderer = new ChromePdfRenderer();

// Add a header to every page easily
renderer.RenderingOptions.FirstPageNumber = 1; // use 2 if a cover page  will be appended
renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Helvetica;
renderer.RenderingOptions.TextHeader.FontSize = 12;
renderer.RenderingOptions.MarginTop = 25; //create 25mm space for header

// Add a footer too
renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
renderer.RenderingOptions.TextFooter.Font = IronSoftware.Drawing.FontTypes.Arial;
renderer.RenderingOptions.TextFooter.FontSize = 10;
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
renderer.RenderingOptions.MarginTop = 25; //create 25mm space for footer

// Mergeable fields are:
// {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
