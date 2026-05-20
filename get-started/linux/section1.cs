using IronPdf;
namespace IronPdf.Examples.GettingStarted.Linux
{
    public static class Section1
    {
        public static void Run()
        {
            // Enables automatic configuration of dependencies for Linux
            IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
        }
    }
}