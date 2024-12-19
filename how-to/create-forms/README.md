# How to Create PDF Forms

***Based on <https://ironpdf.com/how-to/create-forms/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your business overpaying for annual PDF security and compliance subscriptions? Check out <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, which delivers a suite of services such as digital signing, redaction, encryption, and protection through a single payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Explore IronSecureDoc Documentation</a>
</div>

IronPDF equips you with a robust suite of features for creating PDF forms. It supports a variety of form elements such as input fields, text areas, checkboxes, comboboxes, radio buttons, and image forms. With IronPDF, you can craft dynamic PDF forms that engage users by allowing them to fill out fields, make selections, and submit changes. This functionality makes it simpler to construct interactive and accessible PDF forms for various needs and contexts.

<h3>Getting Started with IronPDF</h3>

---

---

---

## Create Forms

IronPDF seamlessly generates PDF documents that incorporate interactive form fields. By embedding dynamic form elements into a static PDF, the document becomes more flexible and interactive.

## Text Area and Input Forms

### Render From HTML

Creating text area and input forms in your PDFs is straightforward with IronPDF. Text areas offer plenty of space for large text inputs, while input forms are great for capturing precise user inputs.

```cs
using IronPdf;

// HTML content with form fields
string htmlContent = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        <form>
            First Name: <br> <input type='text' name='firstname' value=''> <br>
            Last Name: <br> <input type='text' name='lastname' value=''> <br>
            Address: <br> <textarea name='address' rows='4' cols='50'></textarea>
        </form>
    </body>
</html>
";

// Create a PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Generate PDF from HTML form and save it
pdfRenderer.RenderHtmlAsPdf(htmlContent).SaveAs("editableForm.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/textAreaAndInputForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Add Text Form via Code

You can add text form fields programmatically as shown in the example below, which starts by creating a PDF from HTML, then adds a form field via code.

```cs
using IronPdf;
using IronSoftware.Forms;

// Create a PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Generate a PDF document
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");

// Define form field parameters
string fieldName = "firstname";
string fieldValue = "Type your first name";
uint pageIndex = 0;
double posX = 100;
double posY = 700;
double fieldWidth = 50;
double fieldHeight = 15;

// Create a text form field
var formField = new TextFormField(fieldName, fieldValue, pageIndex, posX, posY, fieldWidth, fieldHeight);

// Add the form field to the PDF
document.Form.Add(formField);

// Save the PDF with the form
document.SaveAs("textFormField.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addTextForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

It's important to make your text forms valuable by labeling them correctly in the PDF. IronPdf supports adding text labels with its `DrawText` method. Discover more about this in "[How to Draw Text and Bitmap on PDFs](https://ironpdf.com/how-to/draw-text-and-bitmap/)."

---

## Checkbox and Combobox Forms

### Render From HTML

Checkbox and combobox forms can also be rendered from HTML, allowing for interactive forms within your PDFs. Users can check off tasks or select preferences via combobox dropdowns, enriching the data collection process within a PDF.

```cs
using IronPdf;

// Checkbox and Combobox HTML
string htmlContent = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        <h2>Task Completed</h2>
        <label>
            <input type='checkbox' id='taskCompleted' name='taskCompleted'> Mark task as completed
        </label>

        <h2>Select Priority</h2>
        <label for='priority'>Choose a priority level:</label>
        <select id='priority' name='priority'>
            <option value='high'>High</option>
            <option value='medium'>Medium</option>
            <option value='low'>Low</option>
        </select>
    </body>
</html>
";

// Configure renderer to create forms from HTML
ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Create PDF with form fields
renderer.RenderHtmlAsPdf(htmlContent).SaveAs("checkboxComboboxForm.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/checkboxAndComboboxForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Adding Forms via Code

#### Checkbox

To add a checkbox field programmatically, instantiate its form field object with specified parameters, add it to the form, and save the document.

```cs
using IronPdf;
using IronSoftware.Forms;

// Initialize PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Render an empty page as a PDF
PdfDocument pdf = pdfRenderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");

// Setup checkbox parameters
string checkboxName = "agree";
string checkboxValue = "no"; // Initially unchecked
uint pageIndex = 0;
double posX = 100;
double posY = 700;
double width = 15;
double height = 15;

// Create a checkbox form field
var checkbox = new CheckboxFormField(checkboxName, checkboxValue, pageIndex, posX, posY, width, height);

// Add the checkbox to the PDF form
pdf.Form.Add(checkbox);

// Save the PDF
pdf.SaveAs("checkboxForm.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addCheckboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

#### Combobox

For adding a combobox, configure it similarly by defining the parameters and adding it to the form.

```cs
using IronPdf;
using IronSoftware.Forms;
using System.Collections.Generic;

// Initialize renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Create an empty PDF document
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Combobox Form Field</h2>");

// Set up combobox parameters
string comboboxName = "vehicleType";
string selectedValue = "Car";  // Default selected value
uint pageIndex = 0;
double posX = 100;
double posY = 700;
double width = 60;
double height = 15;
var options = new List<string> { "Car", "Bike", "Airplane" };

// Create a combobox form field
var combobox = new ComboboxFormField(comboboxName, selectedValue, pageIndex, posX, posY, width, height, options);

// Add the combobox to the PDF
pdf.Form.Add(combobox);

// Save the PDF with the combobox
pdf.SaveAs("comboboxForm.pdf");
```

### Output PDF document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addComboboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

---

## Creating Forms with Radio Buttons

### Render from HTML

When utilizing radio button forms with IronPDF, bear in mind that all radio buttons in a group are managed within a single form object. You can access this form using the `FindFormField` method. If a radio button i