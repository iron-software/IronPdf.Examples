using IronPdf;
namespace IronPdf.Examples.HowTo.Logins
{
    public static class Section1
    {
        public static void Run()
        {
            // ChromeHttpLoginCredentials is built by property, not by constructor.
            new ChromePdfRenderer { LoginCredentials = new ChromeHttpLoginCredentials { NetworkUsername = "username", NetworkPassword = "password" } }
                .RenderUrlAsPdf("https://example.com/protected")
                .SaveAs("secure.pdf");
        }
    }
}