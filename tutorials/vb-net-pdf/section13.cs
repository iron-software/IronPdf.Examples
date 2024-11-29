using IronPdf;
namespace ironpdf.VbNetPdf
{
    public class Section13
    {
        public void Run()
        {
            // Save with a strong encryption password.
            pdf.Password = "my.secure.password";
            pdf.SaveAs("secured.pdf")
        }
    }
}