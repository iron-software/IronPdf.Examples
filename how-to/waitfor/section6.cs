using IronPdf;
namespace ironpdf.Waitfor
{
    public class Section6
    {
        public void Run()
        {
            string htmlContent = @"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
              <meta charset=""UTF-8"">
              <title>Delayed render tests</title>
              <script type=""text/javascript"">
            	setTimeout(function() {
            		var h1Tag = document.createElement(""h1"");
            		h1Tag.innerHTML = ""bla bla bla"";
            		h1Tag.setAttribute(""name"", ""myName"");
            
                    var block = document.querySelector(""div#x"");
            		block.appendChild(h1Tag);
            	}, 1000);
              </script>
            </head>
            <body>
            	<h1>This is Delayed Render Test!</h1>
                <div id=""x""></div>
            </body>
            </html>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.HtmlElementByName("myName", 5000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
        }
    }
}