using IronPdf;
using IronPdf.Signing;


new IronPdf.Signing.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");