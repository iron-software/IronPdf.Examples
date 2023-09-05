namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    using IronPdf;
    using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
    using System.Drawing;
    public class PDFToImages : IExecuteApp
    {
        public string OutputPath { get ; set ; }

        public void Run()
        {
            //Rendering PDF documents to Images or Thumbnails
            var pdf = PdfDocument.FromFile(@"Inputs\PDFToImages.pdf");

            //Extract all pages to a folder as image files            
            pdf.RasterizeToImageFiles($@"{OutputPath}\*.png");

            //Dimensions and page ranges may be specified     
            pdf.RasterizeToImageFiles($@"{OutputPath}\thumbnail_*.jpg", 100, 80);

            //Extract all pages as System.Drawing.Bitmap objects
            Bitmap[] pageImages = pdf.ToBitmap();
        }
    }
}
