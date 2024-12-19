using IronPdf;
namespace IronPdf.Examples.GettingStarted.LicenseKeys
{
    public static class Section3
    {
        public static void Run()
        {
            // Check if a given license key string is valid.
            bool result = IronPdf.License.IsValidLicense("IRONPDF-MYLICENSE-KEY-1EF01");
            
            // Check if IronPDF is licensed successfully 
            bool is_licensed = IronPdf.License.IsLicensed;
        }
    }
}