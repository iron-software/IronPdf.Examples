using IronSoftware.Forms;
using IronPdf;
namespace IronPdf.Examples.HowTo.EditForms
{
    public static class Section5
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("textAreaAndInputForm.pdf");
            
            // Remove Form
            IFormField targetForm = pdf.Form.FindFormField("firstname");
            pdf.Form.Remove(targetForm);
            
            pdf.SaveAs("removedForm.pdf");
        }
    }
}