# Creating PDF Forms with IronPDF

***Based on <https://ironpdf.com/how-to/create-forms/>***


IronPDF delivers a robust toolkit for generating PDF forms, enabling you to include a variety of form elements such as input fields, text areas, checkboxes, comboboxes, radio buttons, and images. This functionality allows the creation of dynamic, interactive PDF forms that enhance user interaction by letting them complete and save their entries across diverse applications and use cases.

## Quickstart: Construct Your Initial PDF Form Using IronPDF

Jumpstart your PDF project with IronPDF by creating fillable, dynamic PDF forms using straightforward C# programming. IronPDF's API simplifies the addition of text inputs, checkboxes, and other form elements with minimal coding required. Follow this quick tutorial to learn how to easily specify form elements and save your document, an ideal solution for developers looking to quickly deploy PDF form functionalities.

```cs
:title=Construct your PDF form effortlessly!
var pdfRenderer = new IronPdf.ChromePdfRenderer { RenderingOptions = { CreatePdfFormsFromHtml = true } };
pdfRenderer
    .RenderHtmlAsPdf("<html><body><form>First name: <input type='text' name='firstname' value=''>Last name: <input type='text' name='lastname' value=''></form></body></html>")
    .SaveAs("editableForm.pdf");
```

<div class="alert alert-info iron-variant-1" role="alert">
Your organization may be overpaying for annual PDF security and compliance subscriptions. Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for managing digital signature, redaction, encryption, and protection services through a one-off payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Access IronSecureDoc Documentation</a>
</div>

---

## Creating Forms

IronPDF excels in embedding dynamic form fields into PDFs, transitioning them from static documents to interactive, user-friendly forms.

### Efficient Generation of Text and Input Forms

#### Render From HTML

Develop text and input forms effortlessly using HTML to gather user inputs directly inside your PDFs. Text areas are ideal for collecting extensive text, while input forms are suited for precise user responses.

```csharp
using IronPdf;

// HTML content for forms
string formHtml = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        <form>
            First name: <br> <input type='text' name='firstname' value=''> <br>
            Last name: <br> <input type='text' name='lastname' value=''> <br>
            Address: <br> <textarea name='address' rows='4' cols='50'></textarea>
        </form>
    </body>
</html>
";

// Set up the PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer { RenderingOptions = { CreatePdfFormsFromHtml = true } };
pdfRenderer.RenderHtmlAsPdf(formHtml).SaveAs("textAreaAndInputForm.pdf");
```

### Output PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/textAreaAndInputForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

#### Adding Text Forms Through Code

While the previous examples illustrate how to create forms from HTML, it's equally possible to add form fields programmatically. Start by creating a **TextFormField**, then use the `Add` method on the **Form** property to integrate the text field into your PDF.

```csharp
using IronPdf;
using IronSoftware.Forms;

// Set up the PDF Renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

PdfDocument pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");

// Set up form elements
string name = "firstname";
string value = "First Name";
uint pageIndex = 0;
double x = 100;
double y = 700;
double width = 50;
double height = 15;

// Prepare the text form field
var textForm = new TextFormField(name, value, pageIndex, x, y, width, height);

// Integrate form into PDF
pdfDocument.Form.Add(textForm);
pdfDocument.SaveAs("addTextForm.pdf");
```

### Output PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addTextForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

Refine your document by labeling the form field using `IronPdfGraphics`. Discover how in our guide on [Enhancing PDFs with Text and Images](https://ironpdf.com/how-to/draw-text-and-bitmap/).

## Handling More Complex Forms: Checkboxes, Comboboxes, and Radio Buttons

### Building Checkboxes and Comboboxes from HTML

```csharp
using IronPdf;

// HTML setup for checkboxes and comboboxes
string formHtml = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        <h2>Task Completion</h2>
        <label><input type='checkbox' id='taskCompleted' name='taskCompleted'> Mark task as completed</label>
        <h2>Select Priority Level</h2>
        <label for='priority'>Choose:</label>
        <select id='priority' name='priority'>
            <option value='high'>High</option>
            <option value='medium'>Medium</option>
            <option value='low'>Low</option>
        </select>
    </body>
</html>
";

// Generate the forms in PDF
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer { RenderingOptions = { CreatePdfFormsFromHtml = true } };
pdfRenderer.RenderHtmlAsPdf(formHtml).SaveAs("checkboxAndComboboxForm.pdf");
```

### Output PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/checkboxAndComboboxForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Adding Checkbox and Combobox Fields Programmatically

#### Checkbox

```csharp
using IronPdf;
using IronSoftware.Forms;

// Set up the renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

PdfDocument pdf = pdfRenderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");

string name = "checkbox";
string value = "no";
uint pageIndex = 0;
double x = 100;
double y = 700;
double width = 15;
double height = 15;

// Prepare the checkbox field
var checkbox = new CheckboxFormField(name, value, pageIndex, x, y, width, height);

// Add the checkbox to the form
pdf.Form.Add(checkbox);
pdf.SaveAs("addCheckboxForm.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addCheckboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

#### Combobox

Create and manage combobox fields with a range of options, using a similar approach:

```csharp
using IronPdf;
using IronSoftware.Forms;
using System.Collections.Generic;

// Set up the renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

PdfDocument pdf = pdfRenderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");

string name = "combobox";
string value = "Car";
uint pageIndex = 0;
double x = 100;
double y = 700;
double width = 60;
double height = 15;
var choices = new List<string> { "Car", "Bike", "Airplane" };

// Prepare the combobox field
var comboBox = new ComboboxFormField(name, value, pageIndex, x, y, width, height, choices);

// Add the combobox to the form
pdf.Form.Add(comboBox);
pdf.SaveAs("addComboboxForm.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addComboboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

Explore further applications such as adding radio buttons and other types of forms in our extensive tutorial collection, like [How to Sign and Secure PDFs](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial).