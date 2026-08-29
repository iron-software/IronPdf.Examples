using IronPdf.GrpcLayer;
using Grpc.Core;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.IronpdfengineDocker
{
    public static class Section4
    {
        public static void Run()
        {
            // 1. Create custom gRPC channel (.NET Framework style)
            var channel = new Channel("123.456.7.8:80", ChannelCredentials.SecureSsl);
            
            // 2. (Optional) Add metadata headers if needed
            var metadata = new Metadata
            {
                { "Authorization", "Bearer your_token_here" }
            };
            
            // 3. Configure IronPDF with custom channel
            var config = IronPdfConnectionConfiguration.WithCustomChannel(channel, metadata);
            IronPdf.Installation.ConnectToIronPdfHost(config);
            
            // 4. Generate PDF
            var renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("Hello world");
            
            // 5. Save the PDF to disk
            pdf.SaveAs("output.pdf");
            
            // 6. Clean up , this is needed to work
            pdf.Dispose();
        }
    }
}