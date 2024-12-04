using IronPdf;
using System;
using System.IO;

var uri = new Uri("http://localhost:51169/Invoice");
var urlToPdf = new ChromePdfRenderer
{
    RenderingOptions = new ChromePdfRenderOptions()
    {
        MarginTop = 50,
        MarginBottom = 50,
        TextHeader = new TextHeaderFooter()
        {
            CenterText = "{pdf-title}",
            DrawDividerLine = true,
            FontSize = 16
        },
        TextFooter = new TextHeaderFooter()
        {
            LeftText = "{date} {time}",
            RightText = "Page {page} of {total-pages}",
            DrawDividerLine = true,
            FontSize = 14
        },
        CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print
    },

    // setting login credentials to bypass basic authentication
    LoginCredentials = new IronPdf.ChromeHttpLoginCredentials
    {
        NetworkUsername = "testUser",
        NetworkPassword = "testPassword"
    }
};

var pdf = urlToPdf.RenderUrlAsPdf(uri);
pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "UrlToPdfExample2.Pdf"));
