# How to Fill and Edit PDF Forms

***Based on <https://ironpdf.com/how-to/edit-forms/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Your company can enjoy significant savings on annual subscriptions for PDF management tools. Check out <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, providing enterprise solutions for digital signing, redacting, encrypting, and protecting documents with a one-time payment option. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">View IronSecureDoc Documentation</a>
</div>

With IronPDF, you have a straightforward toolkit to modify existing PDF document forms, including text areas, text inputs, checkboxes, combo boxes, and radio buttons.

## Edit Forms

IronPDF allows for seamless modification of various form field types within a PDF.

## Text Area and Input Forms

For editing text areas and input forms, assign the **Value** property to the field you wish to update. Below, the code first locates the form field using the `FindFormField` method and its specified name, then modifies the **Value** property.

```cs
using IronPdf;
namespace ironpdf.EditForms
{
    public class Section1
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("textAreaAndInputForm.pdf");
            
            // Updating values for text input forms
            pdf.Form.FindFormField("firstname").Value = "John";
            pdf.Form.FindFormField("lastname").Value = "Smith";
            
            // Updating values for text area forms
            pdf.Form.FindFormField("address").Value = "Iron Software HQ\r\n205 N. Michigan Ave.";
            
            pdf.SaveAs("textAreaAndInputFormEdited.pdf");
        }
    }
}
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/textAreaAndInputFormEdited.pdf#zoom=100" width="100%" height="400px">
</iframe>

<hr class="separator">

## Checkbox and Combobox Forms

To modify checkbox and combobox forms, first identify the field by its name, and then update the **Value** property as needed. To check a checkbox, set the **Value** to 'Yes'. For comboboxes, choose from the available options in the **Choices** property.

```cs
using System;
using IronPdf;
namespace ironpdf.EditForms
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("checkboxAndComboboxForm.pdf");
            
            var checkboxForm = pdf.Form.FindFormField("taskCompleted");
            // Activating the checkbox
            checkboxForm.Value = "Yes";
            
            var comboboxForm = pdf.Form.FindFormField("priority");
            // Choosing a value for the combobox
            comboboxForm.Value = "Low";
            
            // Display all available choices
            foreach (var choice in comboboxForm.Choices)
            {
                Console.WriteLine(choice);
            }
            pdf.SaveAs("checkboxAndComboboxFormEdited.pdf");
        }
    }
}
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/checkboxAndComboboxFormEdited.pdf#zoom=100" width="100%" height="400px">
</iframe>

<hr class="separator">

## Radio buttons Forms

For radio buttons within IronPDF, every group of buttons is encapsulated within one form object. To adjust a selection, set the **Value** property to your preferred option. You can also list all options using the **Annotations** property.

```cs
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
            
            // Selecting a radio button option
            radioForm.Value = "Airplane";
            
            // Display all radio options
            foreach(var annotation in radioForm.Annotations)
            {
                Console.WriteLine(annotation.OnAppearance);
            }
            
            pdf.SaveAs("radioButtomFormEdited.pdf");
        }
    }
}
```

To deselect a radio button, make use of the `Clear` function available specifically for **RadioFormField** objects. After retrieving the radio form from the PDF, cast it to the **RadioFormField** type.

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/edit-forms/radioButtomFormEdited.pdf#zoom=110" width="100%" height="400px">
</iframe>

Discover how to create PDF forms programmatically in the subsequent article: "[How to Create PDF Forms](https://ironpdf.com/how-to/create-forms/)."