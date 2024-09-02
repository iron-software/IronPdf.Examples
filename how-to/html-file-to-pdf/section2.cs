using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;


var renderer = new ChromePdfRenderer
{
    RenderingOptions = new ChromePdfRenderOptions
    {
        UseMarginsOnHeaderAndFooter = UseMargins.None,
        CreatePdfFormsFromHtml = false,
        CssMediaType = PdfCssMediaType.Print,
        CustomCssUrl = null,
        EnableJavaScript = false,
        Javascript = null,
        JavascriptMessageListener = null,
        FirstPageNumber = 0,
        GrayScale = false,
        HtmlHeader = null,
        HtmlFooter = null,
        InputEncoding = null,
        MarginBottom = 0,
        MarginLeft = 0,
        MarginRight = 0,
        MarginTop = 0,
        PaperOrientation = PdfPaperOrientation.Portrait,
        PaperSize = PdfPaperSize.Letter,
        PrintHtmlBackgrounds = false,
        TextFooter = null,
        TextHeader = null,
        Timeout = 0,
        Title = null,
        ForcePaperSize = false,
        ViewPortHeight = 0,
        ViewPortWidth = 0,
        Zoom = 0,
        FitToPaperMode = FitToPaperModes.Zoom
    },
    LoginCredentials = null
};
renderer.RenderingOptions.WaitFor.RenderDelay(50);

// Create a PDF from an existing HTML file using C#
var pdf = renderer.RenderHtmlFileAsPdf("example.html");

// Export to a file or Stream
pdf.SaveAs("output.pdf");