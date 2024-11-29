using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section21
    {
        public void Run()
        {
            BarcodeStamper bcStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);
            
            bcStamp.HorizontalAlignment = HorizontalAlignment.Left;
            bcStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            var pdf = new PdfDocument("example.pdf");
            pdf.ApplyStamp(bcStamp);
        }
    }
}