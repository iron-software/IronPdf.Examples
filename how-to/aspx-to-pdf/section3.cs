var AspxToPdfOptions = new IronPdf.ChromePdfRenderOptions()
{
    EnableJavaScript = false,
    //.. many more options available
};
IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Invoice.pdf", AspxToPdfOptions);