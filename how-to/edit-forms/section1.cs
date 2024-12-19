using IronPdf;
namespace IronPdf.Examples.HowTo.EditForms
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("textAreaAndInputForm.pdf");
            
            // Set text input form values
            pdf.Form.FindFormField("firstname").Value = "John";
            pdf.Form.FindFormField("lastname").Value = "Smith";
            
            // Set text area form values
            pdf.Form.FindFormField("address").Value = "Iron Software LLC\r\n205 N. Michigan Ave.";
            
            pdf.SaveAs("textAreaAndInputFormEdited.pdf");
        }
    }
}