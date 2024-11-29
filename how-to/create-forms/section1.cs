using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section1
    {
        public void Run()
        {
            // Input and Text Area forms HTML
            string FormHtml = @"
            <html>
                <body>
                    <h2>Editable PDF Form</h2>
                    <form>
                        First name: <br> <input type='text' name='firstname' value=''> <br>
                        Last name: <br> <input type='text' name='lastname' value=''> <br>
                        Address: <br> <textarea name='address' rows='4' cols='50'></textarea>
                    </form>
                </body>
            </html>
            ";
            
            // Instantiate Renderer
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("textAreaAndInputForm.pdf");
        }
    }
}