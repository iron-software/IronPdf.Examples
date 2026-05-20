using IronPdf;
namespace IronPdf.Examples.GettingStarted.InstallationOverview
{
    public static class Section5
    {
        public static void Run()
        {
            // Adjusts System.IO.Path.GetTempFileName and System.IO.Path.GetTempPath behavior for the application
            var MyTempPath = @"C:\Safe\Path\";
            Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);
            
            // Set IronPDF Temp Path
            IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");
            
            // Your PDF Generation and editing code
            var Renderer = new IronPdf.ChromePdfRenderer();
            using var Doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
            Doc.SaveAs("example.pdf");
        }
    }
}