using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section27
    {
        public void Run()
        {
            // Step 1.  Creating a PDF with editable forms from HTML using form and input tags
            const string formHtml = @"
                <html>
                    <body>
                        <h2>Editable PDF  Form</h2>
                        <form>
                          First name: <br> <input type='text' name='firstname' value=''> <br>
                          Last name: <br> <input type='text' name='lastname' value=''>
                        </form>
                    </body>
                </html>";
            
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            renderer.RenderHtmlAsPdf(formHtml).SaveAs("BasicForm.pdf");
            
            // Step 2. Reading and Writing PDF form values.
            var formDocument = PdfDocument.FromFile("BasicForm.pdf");
            
            // Read the value of the "firstname" field
            var firstNameField = formDocument.Form.FindFormField("firstname");
            
            // Read the value of the "lastname" field
            var lastNameField = formDocument.Form.FindFormField("lastname");
        }
    }
}