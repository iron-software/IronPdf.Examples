# How to Populate and Modify PDF Forms

***Based on <https://ironpdf.com/how-to/edit-forms/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your business overspending on yearly subscriptions for PDF security and compliance? Discover <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering a suite of services such as digital signatures, redaction, encryption, and more, all under a single purchase. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Read more about IronSecureDoc</a>
</div>

IronPDF provides a straightforward suite of tools for modifying existing PDF forms, accommodating components like text areas, text inputs, checkboxes, combo boxes, and radio buttons.

<h3>Beginning with IronPDF</h3>



--------------------------------------



## Form Modifications

IronPDF seamlessly adjusts existing fields across various types within a PDF document.

## Text Area and Input Fields

To adjust text areas and input fields, simply set the **Value** property to the necessary information. The following code demonstrates locating the form field using the `FindFormField` method and altering the **Value** property:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("textAreaAndInputForm.pdf");

// Modify text input form values
pdf.Form.FindFormField("firstname").Value = "Jane";
pdf.Form.FindFormField("lastname").Value = "Doe";

// Modify text area form values
pdf.Form.FindFormField("address").Value = "Iron Software LLC\r\n500 W Madison St.";

pdf.SaveAs("UpdatedTextAreaAndInputForm.pdf");
```

### Revised PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/textAreaAndInputFormEdited.pdf#zoom=100" width="100%" height="400px">
</iframe>

<hr class="separator">

## Checkbox and Combobox Fields

To edit checkbox and combobox fields, locate the form field via its name. Set a checkbox to 'Yes' or select a combobox option by updating the **Value** property. List all possible choices by accessing the **Choices** property:

```cs
using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("checkboxAndComboboxForm.pdf");

var checkboxForm = pdf.Form.FindFormField("taskCompleted");
// Activate the checkbox
checkboxForm.Value = "Yes";

var comboboxForm = pdf.Form.FindFormField("priority");
// Select the combobox value
comboboxForm.Value = "Medium";

// Display all combobox options
foreach (var choice in comboboxForm.Choices)
{
    Console.WriteLine(choice);
}
pdf.SaveAs("UpdatedCheckboxAndComboboxForm.pdf");
```

### Revised PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/checkboxAndComboboxFormEdited.pdf#zoom=100" width="100%" height="400px">
</iframe>

<hr class="separator">

## Radio Button Fields

To modify radio button selections in a PDF using IronPDF, each group of radio buttons is managed as a single form object. Change the radio button selection by updating the **Value** property to one of the selection options. Access all options via the **Annotations** property. Below is a code example:

```cs
using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("radioButtomForm.pdf");
var radioForm = pdf.Form.FindFormField("traveltype");

// Change the radio button selection
radioForm.Value = "Car";

// Output available options
foreach(var annotation in radioForm.Annotations)
{
    Console.WriteLine(annotation.OnAppearance);
}

pdf.SaveAs("UpdatedRadioButtonForm.pdf");
```

Additionally, the `Clear` method can be employed to deselect a radio button. It is applicable when the form object is of type **RadioFormField**.

### Revised PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/radioButtomFormEdited.pdf#zoom=110" width="100%" height="400px">
</iframe>

For guidance on creating PDF forms through programming, see the following tutorial: "[How to Create PDF Forms](https://ironpdf.com/how-to/create-forms/)."