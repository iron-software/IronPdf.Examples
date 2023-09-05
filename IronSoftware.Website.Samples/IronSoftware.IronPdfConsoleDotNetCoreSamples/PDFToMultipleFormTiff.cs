namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    using IronPdf;
    using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
    using System.Drawing;
    public class PDFToMultipleFormTiff : IExecuteApp
    {
        public string OutputPath { get ; set ; }

        public void Run()
        {
            //Rendering PDF documents to Images or Thumbnails
            var pdf = PdfDocument.FromFile(@"Inputs\PDFToImages.pdf");

            //Extract all pages to a folder as tiff files            
            pdf.ToMultiPageTiffImage($@"{OutputPath}\*.tiff",300);

            //Extract all pages as System.Drawing.Bitmap objects
            Bitmap[] pageImages = pdf.ToBitmap();
        }
    }
}
