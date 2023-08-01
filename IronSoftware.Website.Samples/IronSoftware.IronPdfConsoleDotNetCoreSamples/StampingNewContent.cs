using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class StampingNewContent : IExecuteApp
    {
        public string OutputPath { get ; set ; }

        public void Run()
        {
            //PDFs can be edited or amended by stamping new HTML content into the foreground or background.
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            var pdf = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            var BackgroundStamp = new HtmlStamp() { Html = "<img src='logo.jpg' />", Width = 50, Height = 25, Opacity = 50, Bottom = 5, ZIndex = HtmlStamp.StampLayer.BehindExistingPDFContent };
            pdf.StampHTML(BackgroundStamp);
            var ForegroundStamp = new HtmlStamp() { Html = "<h2 style='color:red'>copyright 2018 ironpdf.com", Width = 50, Height = 50, Opacity = 50, Rotation = -45, ZIndex = HtmlStamp.StampLayer.OnTopOfExistingPDFContent };
            pdf.StampHTML(ForegroundStamp);
            pdf.SaveAs($@"{OutputPath}\StampingNewContent.pdf");
        }
    }
}
