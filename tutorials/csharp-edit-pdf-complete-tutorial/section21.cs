using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section21
    {
        public static void Run()
        {
            BarcodeStamper bcStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);
            
            bcStamp.HorizontalAlignment = HorizontalAlignment.Left;
            bcStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            var pdf = new PdfDocument("example.pdf");
            pdf.ApplyStamp(bcStamp);
        }
    }
}