using IronPdf.GrpcLayer;

namespace IronPdf.AndroidDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        // pre-config
        IronPdf.Logging.Logger.EnableDebugging = false;
        IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.None;
        Installation.LinuxAndDockerDependenciesAutoConfig = false;
        Installation.AutomaticallyDownloadNativeBinaries = false;
        Installation.LicenseKey = "ENTER-LICENSE-KEY-HERE";

        Installation.ConnectToIronPdfHost(new IronPdfConnectionConfiguration()
        {
            ConnectionType = IronPdfConnectionType.RemoteServer,
            Host = "https://YOUR-APP-SERVICE.azurewebsites.net/",
            Port = 80
        });
    }

	private void OnCounterClicked(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();
        using (var doc = renderer.RenderUrlAsPdf(UrlEntry.Text))
        {
            string dir = FileSystem.Current.CacheDirectory;
            string path = Path.Combine(dir, "test.pdf");
            doc.SaveAs(path);
            Launcher.OpenAsync(new OpenFileRequest
            {
                File = new ReadOnlyFile(path)
            });
        }
    }
}

