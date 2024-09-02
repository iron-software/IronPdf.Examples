# How to Design PDF Forms

<div class="alert alert-info iron-variant-1" role="alert">
	Your company might be overpaying for annual PDF security and compliance subscriptions. Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering one-time payment solutions for digital signing, redaction, encryption, and protection in managing SaaS services. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try</a>
</div>

IronPDF provides an extensive suite of tools for crafting PDF forms. This includes support for different kinds of form elements such as input fields, text areas, checkboxes, comboboxes, radio buttons, and images in forms. IronPDF simplifies the creation of dynamic PDF forms, enabling user interaction by filling out fields, making selections, and committing changes, which opens up possibilities for interactive and user-focused PDF forms across various use cases and scenarios.

## Form Creation with IronPDF

IronPDF allows for seamless generation of PDF documents that incorporate various forms of input fields, enhancing both the document’s flexibility and interactivity.

## Text Area and Input Forms

### Generating from HTML

Creating text area and input forms within your PDFs to capture user inputs is straightforward with IronPDF. The text area allows for capturing extensive text, whereas input forms are suited for short and precise data inputs.

```cs
using IronPdf;

// HTML for Input and Text Area forms
string FormHtml = @"
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

// Set up the Renderer
ChromePdfRenderer Renderer = new ChromePdfRenderer();
Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("textAreaAndInputForm.pdf");
```

### Display PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/textAreaAndInputForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Adding Text Forms Programmatically

Besides using HTML, text forms can also be directly added via code. Begin by creating a **TextFormField** and add it using the `Add` method from the **Form** property.

```cs
using IronPdf;
using IronSoftware.Forms;

// Set up the renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");

// Form field details
string name = "firstname";
string value = "Enter your first name";
int pageIndex = 0;
double x = 100;
double y = 700;
double width = 50;
double height = 15;

// Initialize text form field
var textForm = new TextFormField(name, value, pageIndex, x, y, width, height);

// Insert the form into the PDF
pdf.Form.Add(textForm);

pdf.SaveAs("addTextForm.pdf");
```

### Rendered PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addTextForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

It is advisable to add labels within your PDF as descriptions for form fields for clarity using IronPdf's `DrawText` method. Further details on this can be found in the article [How to Draw Text and Bitmap on PDFs](https://ironpdf.com/how-to/draw-text-and-bitmap/).

## Checkbox and Combobox Forms

### HTML Rendering

You can create Checkbox and Combobox forms by rendering them from HTML sources containing such elements. Enable form creation from HTML by setting the **CreatePdfFormsFromHtml** property.

```cs
using IronPdf;

// Combobox and Checkbox form HTML setup
string FormHtml = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        <h2>Task Completed</h2>
        <label>
            <input type='checkbox' id='taskCompleted' name='taskCompleted'> Mark task as completed
        </label>

        <h2>Select Priority</h2>
        <label for='priority'>Choose priority level:</label>
        <select id='priority' name='priority'>
            <option value='high'>High</option>
            <option value='medium'>Medium</option>
            <option value='low'>Low</option>
        </select>
    </body>
</html>
";

// Renderer setup
ChromePdfRenderer Renderer = new ChromePdfRenderer();
Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("checkboxAndComboboxForm.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/checkboxAndComboboxForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Adding Forms through Code

#### Checkbox Configuration

Adding a checkbox form field is done by initializing a **CheckboxFormField** followed by using the `Add` method of the **Form** property.

```cs
using IronPdf;
using IronSoftware.Forms;

// Renderer initialization
ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");

// Checkbox setup
string name = "checkbox";
string value = "unchecked";  // 'yes' for checked, 'no' for unchecked
int pageIndex = 0;
double x = 100;
double y = 700;
double width = 15;
double height = 15;

// Checkbox form creation
var checkboxForm = new CheckboxFormField(name, value, pageIndex, x, y, width, height);

// Adding form to PDF
pdf.Form.Add(checkboxForm);

pdf.SaveAs("addCheckboxForm.pdf");
```

### Displayed PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addCheckboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

#### Combobox Setup

Similarly, add a combobox through code by initializing a **ComboboxFormField** and adding it using the `Add` method.

```cs
using IronPdf;
using IronSoftware.Forms;
using System.Collections.Generic;

// Renderer setup
ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Combobox Form Field</h2>");

// Combobox details
string name = "comboBox";
string selectedValue = "Car";
int pageIndex = 0;
double x = 100;
double y = 700;
double width = 60;
double height = 15;
var options = new List<string>() { "Car", "Bike", "Airplane" };

// Combobox creation
var comboBoxForm = new ComboboxFormField(name, selectedValue, pageIndex, x, y, width, height, options);

// Inserting form into the PDF
pdf.Form.Add(comboBoxForm);

pdf.SaveAs("addComboboxForm.pdf");
```

### Displayed PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addComboboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

## Radio Buttons Forms

### HTML Based Forms

In IronPDF, radio button forms are grouped within a single form object, allowing the `FindFormField` method to retrieve them easily. If a radio option is selected, the **Value** property will record that cho...

```cs
using IronPdf;

// HTML setup for radio button forms
string FormHtml = @"
<html>
    <body>
        <h2>Editable PDF Form</h2>
        Choose your preferred travel type: <br>
        <input type='radio' name='traveltype' value='Bike'> Bike <br>
        <input type='radio' name='traveltype' value='Car'> Car <br>
        <input type='radio' name='traveltype' value='Airplane'> Airplane
    </body>
</html>
";

// Renderer configuration
ChromePdfRenderer Renderer = new ChromePdfRenderer();
Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("radioButtomForm.pdf");
```

### Output Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/radioButtomForm.pdf#zoom=110" width="100%" height="400px">
</iframe>

### Code-based Radio Form addition

Adding radio button forms through code is achieved by initia...