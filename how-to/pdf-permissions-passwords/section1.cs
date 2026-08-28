using IronPdf;
namespace IronPdf.Examples.HowTo.PdfPermissionsPasswords
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("document.pdf");
            pdf.SecuritySettings.OwnerPassword = "owner123";
            pdf.SecuritySettings.UserPassword = "user123";
            // There is no Permissions property; each permission is its own setting.
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.NoPrint;
            pdf.SaveAs("secured_document.pdf");
        }
    }
}