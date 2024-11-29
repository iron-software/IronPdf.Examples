# Utilizing the WaitFor Class to Optimize PDF Rendering in C#

***Based on <https://ironpdf.com/how-to/waitfor/>***


Rendering PDFs in C# can face issues like premature rendering before JavaScript assets and animations fully load, leading to incomplete or erroneous outputs. The introduction of the **WaitFor** class offers a more dependable solution compared to the earlier arbitrary delay tactic, enhancing PDF rendering accuracy and efficiency.

The **WaitFor** entity within **RenderOptions** presents various robust methods to fine-tune rendering timings:
- [Immediate Page Load](#anchor-default-immediate-render-example): Renders immediately post-page load.
- [Custom Render Delay](#anchor-custom-render-delay-example): Allows setting a specific millisecond delay.
- [Font Loading Completion](#anchor-all-fonts-loaded-example): Delays rendering until all fonts are available.
- [JavaScript Function Execution](#anchor-custom-javascript-execution-example): Waits for a custom JavaScript function to dictate rendering start.
- [Specific HTML Element Detection](#anchor-html-elements-example): Delays until certain HTML elements become present.
- [Network Idle Conditions](#anchor-network-idle-example): Awaits minimal network activity.
  
These capabilities support various file transformations including [converting HTML strings to PDF](https://ironpdf.com/how-to/html-string-to-pdf/), [HTML files to PDF](https://ironpdf.com/how-to/html-file-to-pdf/), and [URLs to PDF](https://ironpdf.com/how-to/url-to-pdf/).

## Default Immediate Render 

Without configuring any delays, the rendering kicks off as soon as the webpage loads. The `PageLoad` option functions directly in this default setting and needs no explicit initiation for standard rendering.

```cs
using IronPdf;
namespace ironpdf.Waitfor
{
    public class ImmediateRenderExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Execute rendering immediately after page load
            renderer.RenderingOptions.WaitFor.PageLoad();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Test</h1>");
        }
    }
}
```

## Implementing Custom Render Delay 

For use cases requiring controlled timing, you can incorporate a deliberate delay specified in milliseconds. This is a shift from the deprecated approach of `RenderingOptions.RenderDelay` to using the revised method `RenderingOptions.WaitFor.RenderDelay`.

```cs
using IronPdf;
namespace ironpdf.Waitfor
{
    public class DelayedRenderExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Delay rendering by 3000ms
            renderer.RenderingOptions.WaitFor.RenderDelay(3000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Test</h1>");
        }
    }
}
```

## Font Readiness Implementation

Ensuring all external fonts are loaded prior to rendering prevents typographic inconsistencies. The `AllFontsLoaded` method provides this capability, particularly useful for documents relying on font-specific designs.

```cs
using IronPdf;
namespace ironpdf.Waitfor
{
    public class FontLoadHandling
    {
        public void Execute()
        {
            string htmlContent = @"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
              <meta charset=""UTF-8"">
              <title>Test Case for Font Loading</title>
              
              <link rel=""preconnect"" href=""https://fonts.google.com"" crossorigin>
              <link rel=""stylesheet"" href=""https://fonts.google.com/css?family=Open+Sans"">
            
              <style>
              /* Custom and local font setup */
              p.custom { font-family: 'Open Sans', serif; }
              </style>
            </head>
            <body>
	            <h1>Font Loading Test</h1>
	            <p class=""custom"">Sample text with a custom font.</p>
            </body>
            </html>";

            ChromePdfRenderer renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.AllFontsLoaded(10000);
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);
        }
    }
}
```

## Custom JavaScript Trigger for Rendering

This option allows integrating a specific JavaScript function to determine the rendering initiation, thus offering higher control over the process timing.

```cs
using IronPdf;
namespace ironpdf.Waitfor
{
    public class CustomScriptExecution
    {
        public void Execute()
        {
            string html = @"
            <!DOCTYPE html>
            <html>
            <body>
            <h1>Script Execution Example</h1>
            <script type='text/javascript'>
            // Waiting period before triggering render
            setTimeout(function() {
                window.ironpdf.notifyRender();
            }, 1000);
            </script>
            </body>
            </html>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Setup to wait for custom script trigger
            renderer.RenderingOptions.WaitFor.JavaScript(5000);
            
            PdfDocument pdf = ChromePdfRenderer.StaticRenderHtmlAsPdf(html);
        }
    }
}
```

## HTML Element Specific Waits

Rendering can also be contingent on the presence of specific HTML elements, enhancing rendering accuracy especially in dynamic content scenarios.

### Element ID Strategy

This approach