using IronPdf;
namespace IronPdf.Examples.Overview.Quickstart
{
    public static class Section3
    {
        public static void Run()
        {
            // Set Application scope Temp Files Path.
            // This changes System.IO.Path.GetTempFileName and System.IO.Path.GetTempPath behavior for the entire .NET application
            var MyTempPath = @"C:\Safe\Path\";
            Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);
            
            // Set IronPDF Temp Path
            IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdf");
            
            // Your PDF Generation and editing code here..E.G.
            var Renderer = new IronPdf.ChromePdfRenderer();
            using var Doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
            Doc.SaveAs("example.pdf");
        }
    }
}