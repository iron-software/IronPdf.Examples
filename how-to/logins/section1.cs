using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer
{
    // setting login credentials to bypass basic authentication
    LoginCredentials = new ChromeHttpLoginCredentials()
    {
        NetworkUsername = "testUser",
        NetworkPassword = "testPassword"
    }
};

var uri = new Uri("http://localhost:51169/Invoice");

// Render web URL to PDF
PdfDocument pdf = renderer.RenderUrlAsPdf(uri);

// Export PDF
pdf.SaveAs("UrlToPdfExample.Pdf");