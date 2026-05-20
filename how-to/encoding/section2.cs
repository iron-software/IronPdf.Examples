using IronPdf;
namespace IronPdf.Examples.HowTo.Encoding
{
    public static class Section2
    {
        public static void Run()
        {
            // Create an instance of the ChromePdfRenderer class
            var renderer = new IronPdf.ChromePdfRenderer();
            
            // Set the input encoding for rendering options to UTF-8
            renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; // default
            
            // Render HTML as PDF
            using var pdf = renderer.RenderHtmlAsPdf(@"
            <html>
                <head>
                    <!-- Specify UTF-8 character encoding in the HTML header -->
                    <meta charset='utf-8'>
                </head>
                <body>こんにちは世界</body>
            </html>
            ");
        }
    }
}