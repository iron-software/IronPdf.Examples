using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.IronpdfengineDocker
{
    public static class Section3
    {
        public static void Run()
        {
            // This code demonstrates how to use IronPdf with gRPC in a .NET Framework application.
            
            // 1. Configure connection to use local IronPdfEngine executable
            var config = IronPdf.GrpcLayer.IronPdfConnectionConfiguration.Executable;
            
            // 2. Connect to the IronPDF host with the executable configuration
            IronPdf.Installation.ConnectToIronPdfHost(config);
            
            // 3. Create a PDF renderer instance
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // 4. Render HTML string as PDF document
            PdfDocument pdf = renderer.RenderHtmlAsPdf("Hello world");
            
            // 5. Save the PDF to disk
            pdf.SaveAs("output.pdf");
            
            // 6. Clean up , this is needed to work
            pdf.Dispose();
        }
    }
}