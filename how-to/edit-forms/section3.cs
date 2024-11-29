using System;
using IronPdf;
namespace ironpdf.EditForms
{
    public class Section3
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("radioButtomForm.pdf");
            var radioForm = pdf.Form.FindFormField("traveltype");
            
            // Set the radio button value
            radioForm.Value = "Airplane";
            
            // Print out all the available choices
            foreach(var annotation in radioForm.Annotations)
            {
                Console.WriteLine(annotation.OnAppearance);
            }
            
            pdf.SaveAs("radioButtomFormEdited.pdf");
        }
    }
}