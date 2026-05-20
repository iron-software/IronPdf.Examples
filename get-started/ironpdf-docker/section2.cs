using IronPdf;
namespace IronPdf.Examples.GettingStarted.IronpdfDocker
{
    public static class Section2
    {
        public static void Run()
        {
            // Disable GPU acceleration for Docker environments
            IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
        }
    }
}