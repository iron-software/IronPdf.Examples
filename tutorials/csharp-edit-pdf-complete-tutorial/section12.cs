using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section12
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Build a footer using html to style the text
            // mergeable fields are:
            // {page} {total-pages} {url} {date} {time} {html-title} & {pdf-title}
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
            {
                MaxHeight = 15, //millimeters
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true
            };
            
            // Build a header using an image asset
            // Note the use of BaseUrl to set a relative path to the assets
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                MaxHeight = 20, //millimeters
                HtmlFragment = "<img src='logo.png'>",
                BaseUrl = new System.Uri(@"C:\assets\images").AbsoluteUri
            };
        }
    }
}