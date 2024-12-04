using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section22
    {
        public void Run()
        {
            BarcodeStamper qrStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);
            
            qrStamp.Height = 50; // pixels
            qrStamp.Width = 50; // pixels
            
            qrStamp.HorizontalAlignment = HorizontalAlignment.Left;
            qrStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            var pdf = new PdfDocument("example.pdf");
            pdf.ApplyStamp(qrStamp);
        }
    }
}