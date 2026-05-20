using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section11
    {
        public static void Run()
        {
            // Simple HTML templating with String.Format
            string htmlTemplate = String.Format("<h1>Hello {0}!</h1>", "World");
            
            // Results in HTML content: <h1>Hello World!</h1>
        }
    }
}