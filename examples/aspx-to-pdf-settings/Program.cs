using IronPdf;

var PdfOptions = new IronPdf.ChromePdfRenderOptions()
{
    CreatePdfFormsFromHtml = true,
    EnableJavaScript = false,
    Title = "My ASPX Page Rendered as a PDF"
    //.. many more options available
};

AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.Attachment, "MyPdfFile.pdf", PdfOptions);
