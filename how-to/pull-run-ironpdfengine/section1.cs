using IronPdf;
using IronPdf.GrpcLayer;

IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";

IronPdfConnectionConfiguration configuration = new IronPdfConnectionConfiguration();
configuration.ConnectionType = IronPdfConnectionType.RemoteServer;
configuration.Host = "http://48.216.143.233";
configuration.Port = 80;
IronPdf.Installation.ConnectToIronPdfHost(configuration);

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
pdf.SaveAs("output.pdf");