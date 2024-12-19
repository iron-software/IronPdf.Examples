using IronPdf;
namespace IronPdf.Examples.HowTo.VbNetPdf
{
    public static class Section13
    {
        public static void Run()
        {
            // Save with a strong encryption password.
            pdf.Password = "my.secure.password";
            pdf.SaveAs("secured.pdf")
        }
    }
}