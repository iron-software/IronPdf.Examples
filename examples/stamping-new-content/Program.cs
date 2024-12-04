using IronPdf;
using IronPdf.Editing;

var stamper =
    new HtmlStamper("<img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'/>")
    {
        HorizontalAlignment = HorizontalAlignment.Center,
        VerticalAlignment = VerticalAlignment.Bottom,
        IsStampBehindContent = false,
        Opacity = 30
    };

var pdf = PdfDocument.FromFile("Sample.pdf");

pdf.ApplyStamp(stamper).SaveAs("stamped_image.pdf");
