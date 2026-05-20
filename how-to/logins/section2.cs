using IronPdf;
namespace IronPdf.Examples.HowTo.Logins
{
    public static class Section2
    {
        public static void Run()
        {
            // Download HTML content from a URL
            string html;
            using (WebClient client = new WebClient()) 
            {
                html = client.DownloadString("http://www.google.com");
            }
            
            // Load the HTML into an HtmlDocument
            HtmlDocument doc = new HtmlDocument();        
            doc.LoadHtml(html);
            
            // Iterate through all image nodes and print their src attributes
            foreach(HtmlNode img in doc.DocumentNode.SelectNodes("//img")) 
            {
                Console.WriteLine(img.GetAttributeValue("src", null));
            }
        }
    }
}