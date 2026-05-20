using IronPdf;
namespace IronPdf.Examples.GettingStarted.IronpdfDocker
{
    public static class Section1
    {
        public static void Run()
        {
            // Disable automatic configuration of Linux and Docker dependencies
            IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
        }
    }
}