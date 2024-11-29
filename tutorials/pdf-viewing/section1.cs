using IronPdf.Viewer.Maui;
using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Section1
    {
        public void Run()
        {
            public static class MauiProgram
            {
                public static MauiApp CreateMauiApp()
                {
                    var builder = MauiApp.CreateBuilder();
                    builder
                        .UseMauiApp<App>()
                        // other configuration options ...
                        .ConfigureIronPdfView(); // configure the viewer on app start-up
            
                    return builder.Build();
                }
            }
        }
    }
}