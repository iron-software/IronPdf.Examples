using IronPdf;
namespace IronPdf.Examples.HowTo.Logins
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Render a password‑protected URL to PDF in one line!
            new ChromePdfRenderer { LoginCredentials = new ChromeHttpLoginCredentials("username","password") }
                .RenderUrlAsPdf("https://example.com/protected")
                .SaveAs("secure.pdf");
        }
    }
}