using IronPdf;
namespace IronPdf.Examples.HowTo.PdfPermissionsPasswords
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Secure Your PDFs Effortlessly
            var pdf = IronPdf.PdfDocument.FromFile("document.pdf");
            pdf.SecuritySettings.OwnerPassword = "owner123";
            pdf.SecuritySettings.UserPassword = "user123";
            pdf.SecuritySettings.Permissions = IronPdf.Security.Permissions.NoPrinting;
            pdf.SaveAs("secured_document.pdf");
        }
    }
}