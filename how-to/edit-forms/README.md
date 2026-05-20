# How to Modify and Populate PDF Forms

***Based on <https://ironpdf.com/how-to/edit-forms/>***


<div class="alert alert-info iron-variant-1" role="alert">
Avoid high costs on annual PDF security subscriptions by exploring IronSecureDoc, which delivers a comprehensive suite of PDF management solutions including digital signing, redaction, encryption, and protection, all available for a one-time fee. Dive into the details by visiting [IronSecureDoc Details](https://ironsoftware.com/enterprise/securedoc/) and [IronSecureDoc Documentation](https://ironsoftware.com/enterprise/securedoc/docs/).
</div>

IronPDF furnishes a straightforward toolkit for updating forms within a PDF, including text fields, checkboxes, drop-down lists, and radio buttons.

## Getting Started: Modifying PDF Forms with IronPDF

With IronPDF, you can quickly modify and populate PDF forms. This guide will help you identify form fields, update their content, and save the file, perfect for developers wanting to integrate PDF form modifications within their C# projects seamlessly.

```cs
:title=Effortless PDF Form Editing
var pdfDocument = IronPdf.PdfDocument.FromFile("form.pdf");
var formField = pdfDocument.Form.FindFormField("nameField");
formField.Value = "Jane Smith";
pdfDocument.SaveAs("updated_form.pdf");
```

## Edit Form Fields

IronPDF simplifies the process of modifying various form fields in a PDF.

## Editing Text Fields

Assign the **Value** property of a form field to update text areas and inputs. The example below demonstrates locating a form field by name, and then setting the **Value** property.

```csharp
using IronPdf;

PdfDocument pdfDoc = PdfDocument.FromFile("textAreaAndInputForm.pdf");

// Modify text inputs
pdfDoc.Form.FindFormField("firstname").Value = "Alice";
pdfDoc.Form.FindFormField("lastname").Value = "Johnson";

// Update text area
pdfDoc.Form.FindFormField("address").Value = "Iron Software HQ\n205 N. Michigan Ave.";

pdfDoc.SaveAs("textAreaAndInputFormModified.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/textAreaAndInputFormModified.pdf#zoom=100" width="100%" height="400px"></iframe>

<hr class="separator">

## Checkbox and Drop-Down List Forms

Modify checkboxes and drop-down lists by locating the form field and assigning the **Value** property appropriately. The example code demonstrates how to edit these fields and list all available options.

```csharp
using IronPdf;
using System;

PdfDocument pdfDocument = PdfDocument.FromFile("checkboxAndComboboxForm.pdf");

var completedTaskCheckbox = pdfDocument.Form.FindFormField("taskCompleted");
// Activate the checkbox
completedTaskCheckbox.Value = "Yes";

var priorityDropdown = pdfDocument.Form.FindFormField("priority");
// Update the dropdown value
priorityDropdown.Value = "Medium";

// Display all dropdown options
foreach (var option in priorityDropdown.Choices)
{
    Console.WriteLine(option);
}

pdfDocument.SaveAs("checkboxAndComboboxFormModified.pdf");
``` 

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/checkboxAndComboboxFormModified.pdf#zoom=100" width="100%" height="400px"></iframe>

<hr class="separator">

## Radio Button Forms

Radio buttons within the same group reside in a single form object. Update the radio button selection by assigning the **Value** property. Additionally, list all selectable options with the **Annotations** property as shown below.

```csharp
using IronPdf;
using System;

PdfDocument pdf = PdfDocument.FromFile("radioButtomForm.pdf");
var radioButtonGroup = pdf.Form.FindFormField("traveltype");

// Choose the radio button value
radioButtonGroup.Value = "Train";

// List all the selectable options
foreach(var annotation in radioButtonGroup.Annotations)
{
    Console.WriteLine(annotation.OnAppearance);
}

pdf.SaveAs("radioButtomFormModified.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/radioButtomFormModified.pdf#zoom=110" width="100%" height="400px">
</iframe>

<hr>

## Eliminating Forms

Remove a form by identifying and passing it to the `Form.Remove` method from your **PdfDocument** object.

```csharp
using IronPdf;
using IronSoftware.Forms;

PdfDocument pdfDocument = PdfDocument.FromFile("textAreaAndInputForm.pdf");

// Delete a Form
IFormField forsakenForm = pdfDocument.Form.FindFormField("firstname");
pdfDocument.Form.Remove(forsakenForm);

pdfDocument.SaveAs("removedForm.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/removedForm.pdf#zoom=110" width="100%" height="400px"></iframe>

To learn about creating PDF forms programmatically, view the following guide: "[Creating PDF Forms](https://ironpdf.com/how-to/create-forms/)." Discover more functionalities by visiting our tutorial page: [PDF Security Tutorial](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/)