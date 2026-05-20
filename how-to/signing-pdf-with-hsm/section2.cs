using IronPdf;
namespace IronPdf.Examples.HowTo.SigningPdfWithHsm
{
    public static class Section2
    {
        public static void Run()
        {
            Console.WriteLine($"Verifying variable: {Environment.GetEnvironmentVariable("SOFTHSM2_CONF")}");
        }
    }
}