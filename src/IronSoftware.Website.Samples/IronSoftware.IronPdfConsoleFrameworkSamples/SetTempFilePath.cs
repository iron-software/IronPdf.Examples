using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System;
using System.IO;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class SetTempFilePath : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            Environment.SetEnvironmentVariable("TEMP", OutputPath);
            Environment.SetEnvironmentVariable("TMP", OutputPath);
            // Set IronPDF Temp Path
            IronPdf.Installation.TempFolderPath = Path.Combine(OutputPath, "IronPdfTemp");          
            // Your PDF Generation and editing code here
            var Renderer = new IronPdf.HtmlToPdf();
            var doc = Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
            doc.SaveAs($@"{OutputPath}\SetTempFilePath.pdf");
        }
    }
}
