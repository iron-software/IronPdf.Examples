using IronPdf;
namespace IronPdf.Examples.HowTo.Cookies
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderingOptions.RequestContext = IronPdf.Rendering.RequestContexts.Global;
            
            ChromeHttpLoginCredentials credentials = new ChromeHttpLoginCredentials() {
                NetworkUsername = "testUser",
                NetworkPassword = "testPassword"
            };
            
            string uri = "http://localhost:51169/Invoice";
            
            // Apply cookies
            renderer.ApplyCookies(uri, credentials);
        }
    }
}