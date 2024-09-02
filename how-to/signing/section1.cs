using IronPdf;
using IronPdf.Signing;
using System.Security.Cryptography.X509Certificates;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>foo</h1>");

// Create X509Certificate2 object with X509KeyStorageFlags set to Exportable
X509Certificate2 cert = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

// Create PdfSignature object
var sig = new PdfSignature(cert);

// Sign PDF document
pdf.Sign(sig);

pdf.SaveAs("signed.pdf");