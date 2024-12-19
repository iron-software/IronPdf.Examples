using IronPdf;
namespace IronPdf.Examples.GettingStarted.Linux
{
    public static class Section2
    {
        public static void Run()
        {
            //set IronPDF Temp Path
            string tmpPath =  @"/tmp/";
            
            IronPdf.Logging.Logger.LogFilePath = tmpPath;
            Environment.SetEnvironmentVariable("TEMP", tmpPath, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("TMP", tmpPath, EnvironmentVariableTarget.Process);
            IronPdf.Installation.TempFolderPath = tmpPath;
            IronPdf.Installation.CustomDeploymentDirectory = tmpPath;
        }
    }
}