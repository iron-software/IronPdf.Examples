using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section11
    {
        public static void Run()
        {
            // Save with a strong encryption password.
            pdf.Password = "my.secure.password";
            pdf.SaveAs("secured.pdf")
        }
    }
}