using IronPdf;
namespace IronPdf.Examples.HowTo.LicenseKeys
{
    public static class Section2
    {
        public static void Run()
        {
            // Apply the IronPDF license key
            IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
        }
    }
}