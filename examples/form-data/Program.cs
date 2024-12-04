using IronPdf;
using System;

// Step 1.  Creating a PDF with editable forms from HTML using form and input tags
// Radio Button and Checkbox can also be implemented with input type 'radio' and 'checkbox'
const string formHtml = @"
    <html>
        <body>
            <h2>Editable PDF  Form</h2>
            <form>
              First name: <br> <input type='text' name='firstname' value=''> <br>
              Last name: <br> <input type='text' name='lastname' value=''> <br>
              <br>
              <p>Please specify your gender:</p>
              <input type='radio' id='female' name='gender' value= 'Female'>
                <label for='female'>Female</label> <br>
                <br>
              <input type='radio' id='male' name='gender' value='Male'>
                <label for='male'>Male</label> <br>
                <br>
              <input type='radio' id='non-binary/other' name='gender' value='Non-Binary / Other'>
                <label for='non-binary/other'>Non-Binary / Other</label>
              <br>

              <p>Please select all medical conditions that apply:</p>
              <input type='checkbox' id='condition1' name='Hypertension' value='Hypertension'>
              <label for='condition1'> Hypertension</label><br>
              <input type='checkbox' id='condition2' name='Heart Disease' value='Heart Disease'>
              <label for='condition2'> Heart Disease</label><br>
              <input type='checkbox' id='condition3' name='Stoke' value='Stoke'>
              <label for='condition3'> Stoke</label><br>
              <input type='checkbox' id='condition4' name='Diabetes' value='Diabetes'>
              <label for='condition4'> Diabetes</label><br>
              <input type='checkbox' id='condition5' name='Kidney Disease' value='Kidney Disease'>
              <label for='condition5'> Kidney Disease</label><br>
            </form>
        </body>
    </html>";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderHtmlAsPdf(formHtml).SaveAs("BasicForm.pdf");

// Step 2. Reading and Writing PDF form values.
var FormDocument = PdfDocument.FromFile("BasicForm.pdf");

// Set and Read the value of the "firstname" field
var FirstNameField = FormDocument.Form.FindFormField("firstname");
FirstNameField.Value = "Minnie";
Console.WriteLine("FirstNameField value: {0}", FirstNameField.Value);

// Set and Read the value of the "lastname" field
var LastNameField = FormDocument.Form.FindFormField("lastname");
LastNameField.Value = "Mouse";
Console.WriteLine("LastNameField value: {0}", LastNameField.Value);

FormDocument.SaveAs("FilledForm.pdf");
