using IronPdf;
namespace IronPdf.Examples.HowTo.Encoding
{
    public static class Section1
    {
        public static void Run()
        {
            var Renderer = new IronPdf.ChromePdfRenderer();
            Renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8; //default
            
            using var Pdf = Renderer.RenderHtmlAsPdf(@"
            <html>
            	<head>
            	    <meta charset = 'utf-8'>
            	</head>
            	<body>こんにちは世界</body>
            </html>
            ");
        }
    }
}