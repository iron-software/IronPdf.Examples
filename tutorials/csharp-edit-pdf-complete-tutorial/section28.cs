using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section28
    {
        public static void Run()
        {
            var formDocument = PdfDocument.FromFile("BasicForm.pdf");
            
            // Set and Read the value of the "firstname" field
            var firstNameField = formDocument.Form.FindFormField("firstname");
            firstNameField.Value = "Minnie";
            Console.WriteLine("FirstNameField value: {0}", firstNameField.Value);
            
            // Set and Read the value of the "lastname" field
            var lastNameField = formDocument.Form.FindFormField("lastname");
            lastNameField.Value = "Mouse";
            Console.WriteLine("LastNameField value: {0}", lastNameField.Value);
            
            formDocument.SaveAs("FilledForm.pdf");
        }
    }
}