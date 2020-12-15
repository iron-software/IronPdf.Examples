using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class PDFForms : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf

            // Step 1.  Creating a PDF with editable forms from HTML using form and input tags
            var FormHtml = @"
<html>
    <body>
        <h2>Editable PDF  Form</h2>
        <form>
          First name:<br> <input type='text' name='firstname' value=''   > <br>
          Last name:<br> <input type='text' name='lastname'  value='' >
        </form>
    </body>
</html>";
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.CreatePdfFormsFromHtml = true;
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs($@"{OutputPath}\BasicForm.pdf");
            // Step 2. Reading and Writing PDF form values.
            var FormDocument = PdfDocument.FromFile($@"{OutputPath}\BasicForm.pdf");
            //Set and Read the value of the "firstname" field
            var FirstNameField = FormDocument.Form.GetFieldByName("firstname");
            FirstNameField.Value = "Minnie";
            Console.WriteLine("FirstNameField value: {0}", FirstNameField.Value);
            //Set and Read the value of the "lastname" field
            IronPdf.Forms.FormField LastNameField = FormDocument.Form.GetFieldByName("lastname");
            LastNameField.Value = "Mouse";
            Console.WriteLine("LastNameField value: {0}", LastNameField.Value);
            FormDocument.SaveAs($@"{OutputPath}\FilledForm.pdf");
        }
    }
}
