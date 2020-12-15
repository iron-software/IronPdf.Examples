using IronPdf;
using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System.IO;
using System.Linq;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class ImagesToPDF : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            var ImageFiles = Directory.EnumerateFiles($@"{Directory.GetCurrentDirectory()}\Inputs\Images\").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            // Convert the images to a PDF and save it.
        
            ImageToPdfConverter.ImageToPdf(ImageFiles).SaveAs($@"{OutputPath}\Composite.pdf");
            //Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails
        }
    }
}
