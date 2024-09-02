using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("checkboxAndComboboxForm.pdf");

var checkboxForm = pdf.Form.FindFormField("taskCompleted");
// Check the checkbox form
checkboxForm.Value = "Yes";

var comboboxForm = pdf.Form.FindFormField("priority");
// Set the combobox value
comboboxForm.Value = "Low";

// Print out all the available choices
foreach (var choice in comboboxForm.Choices)
{
    Console.WriteLine(choice);
}
pdf.SaveAs("checkboxAndComboboxFormEdited.pdf");