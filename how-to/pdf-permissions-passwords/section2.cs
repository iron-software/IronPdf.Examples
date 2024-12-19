using IronPdf;
namespace IronPdf.Examples.HowTo.PdfPermissionsPasswords
{
    public static class Section2
    {
        public static void Run()
        {
            var pdf = PdfDocument.FromFile("protected.pdf", "password123");
            
            //... perform PDF-tasks
            
            pdf.SaveAs("protected_2.pdf"); // Saved as another file
        }
    }
}