namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
    using System.Drawing;
    using System.IO;

    public class MultipleFormTiffToPDF : IExecuteApp
    {
        public string OutputPath { get ; set ; }

        public void Run()
        {
            //Rendering Tiff multi form file to PDF 
            var TiffFile = $@"{Directory.GetCurrentDirectory()}\Inputs\MultiForm.tiff";

            //Load tiff multiform file            
            var pdf = IronPdf.ImageToPdfConverter.ImageToPdf(TiffFile);
            pdf.SaveAs($@"{OutputPath}\TiffToPDF.pdf");

            //Extract all pages as System.Drawing.Bitmap objects
            Bitmap[] pageImages = pdf.ToBitmap();
        }
    }
}
