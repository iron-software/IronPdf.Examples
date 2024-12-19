using IronPdf;
namespace IronPdf.Examples.HowTo.Waitfor
{
    public static class Section7
    {
        public static void Run()
        {
            string htmlContent = @"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
              <meta charset=""UTF-8"">
              <title>Delayed render tests</title>
              <script type=""text/javascript"">
            	setTimeout(function() {
            		var newElem = document.createElement(""h2"");
            		newElem.innerHTML = ""bla bla bla"";
            
                    var block = document.querySelector(""div#x"");
            		block.appendChild(newElem);
            	}, 1000);
              </script>
            </head>
            <body>
            	<h1>This is Delayed Render Test!</h1>
                <div id=""x""></div>
            </body>
            </html>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.HtmlElementByTagName("h2", 5000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
        }
    }
}