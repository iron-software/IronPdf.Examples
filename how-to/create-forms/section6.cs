using IronPdf;
namespace IronPdf.Examples.HowTo.CreateForms
{
    public static class Section6
    {
        public static void Run()
        {
            // Radio buttons HTML
            string FormHtml = @"
            <html>
                <body>
                    <h2>Editable PDF Form</h2>
                    Choose your preferred travel type: <br>
                    <input type='radio' name='traveltype' value='Bike'>
                    Bike <br>
                    <input type='radio' name='traveltype' value='Car'>
                    Car <br>
                    <input type='radio' name='traveltype' value='Airplane'>
                    Airplane
                </body>
            </html>
            ";
            
            // Instantiate Renderer
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("radioButtomForm.pdf");
        }
    }
}