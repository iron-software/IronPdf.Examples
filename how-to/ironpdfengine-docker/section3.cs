using IronPdf;
using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!<h1>");
pdf.SaveAs("ironpdf.pdf");