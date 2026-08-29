using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section17
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