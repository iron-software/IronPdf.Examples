# How to Create PDF Forms

***Based on <https://ironpdf.com/how-to/create-forms/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Save on yearly subscriptions for PDF security and compliance by considering <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>. It provides a range of features including digital signing, redaction, encryption, and protection, all at a one-time cost. Explore it in detail at <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc Documentation</a>.
</div>

IronPDF offers a robust solution for form creation in PDF documents. It supports a variety of form elements such as input fields, text areas, checkboxes, comboboxes, radio buttons, and image forms. With IronPDF, you can create dynamic PDF forms that are interactive, enabling users to fill out fields, make selections, and save the information, making your PDFs more engaging and useful across multiple use cases.

## Form Creation Features

With IronPDF, inserting embedded form fields of various types into your PDFs is straightforward, turning a static document into a flexible, interactive experience.

## Text Areas and Input Fields

### Generate from HTML

You can efficiently create forms for text areas and input fields to gather user inputs directly within your PDF files. Text area forms are ideal for capturing longer text blocks, while input forms are perfect for shorter, specific entries.

```cs
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section1
    {
        public void Run()
        {
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
            
            // Create a new Renderer
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("textAreaAndInputForm.pdf");
        }
    }
}
```

### Display PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/textAreaAndInputForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Adding Text Forms Programmatically

Besides rendering HTML to create forms, it is also feasible to programmatically add text form fields. Begin by instantiating a **TextFormField** and then add it to the PDF document using the `Add` method of the **Form** property.

```cs
using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section2
    {
        public void Run()
        {
            // Set up PDF Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");
            
            // Define form field parameters
            string name = "firstname";
            string value = "first name";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 50;
            double height = 15;
            
            // Create and add a text form field
            var textForm = new TextFormField(name, value, pageIndex, x, y, width, height);
            
            pdf.Form.Add(textForm);
            
            pdf.SaveAs("addTextForm.pdf");
        }
    }
}
```

### Display PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addTextForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

For adding context and clarity, consider labeling the form field, leveraging the `DrawText` method. Further information on embedding text and images in PDFs can be found [here](https://ironpdf.com/how-to/draw-text-and-bitmap/).

<hr>

## Checkbox and Combobox Forms

### Creation from HTML

Creating checkbox and combobox forms can also be done by rendering HTML code that includes these elements. Ensure that the **CreatePdfFormsFromHtml** setting is activated to produce these interactive forms.

Comboboxes give users a dropdown menu to provide inputs effectively within PDFs.

```cs
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section3
    {
        public void Run()
        {
            // HTML for Checkbox and Combobox forms
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
            
            // Initialize the Renderer
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("checkboxAndComboboxForm.pdf");
        }
    }
}
```

### View PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/checkboxAndComboboxForm.pdf#zoom=100" width="100%" height="400px">
</iframe>

### Code-based Form Addition

#### Checkbox Form Addition

To incorporate a checkbox form field, create an instance of **CheckboxFormField** and then simply append it to your PDF using the `Add` method of the **Form** property.

```cs
using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section4
    {
        public void Run()
        {
            // Initialize the PDF Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");
            
            // Set form parameters
            string name = "checkbox";
            string value = "no";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 15;
            double height = 15;
            
            // Create and add a checkbox form field
            var checkboxForm = new CheckboxFormField(name, value, pageIndex, x, y, width, height);
            
            pdf.Form.Add(checkboxForm);
            
            pdf.SaveAs("addCheckboxForm.pdf");
        }
    }
}
```

### View PDF Form

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addCheckboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

#### Combobox Addition

Creating a combobox form field involves similar steps; instantiate a **ComboboxFormField** and add it to the PDF.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section5
    {
        public void Run()
        {
            // Configure the Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Combobox Form Field</h2>");
            
            // Define combobox parameters
            string name = "combobox";
            string value = "Car";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 60;
            double height = 15;
            var choices = new List<string> { "Car", "Bike", "Airplane" };
            
            // Create and add a combobox form field
            var comboboxForm = new ComboboxFormField(name, value, pageIndex, x, y, width, height, choices);
            
            pdf.Form.Add(comboboxForm);
            
            pdf.SaveAs("addComboboxForm.pdf");
        }
    }
}
```

### View PDF Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addComboboxForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

<hr>

## Creating Radio Button Forms

### Form Creation from HTML

Using IronPDF, managing radio button forms is straightforward, as they are grouped within a single form object, retrievable through `FindFormField`. If a button within the group is selected, its **Value** property holds the respective value.

```cs
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section6
    {
        public void Run()
        {
            // HTML for Radio buttons
            string FormHtml = @"
            <html>
                <body>
                    <h2>Editable PDF Form</h2>
                    Choose your preferred travel type: <br>
                    <input type='radio' name='traveltype' value='Bike'>
                    Bike <br>
                    <input type='radio' name='traveltype' value='Car'>
                    Car <br>
                    <input type='radio' name='traveltype' value='Airplane'>
                    Airplane
                </body>
            </html>
            ";
            
            // Set up PDF Renderer
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            
            Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("radioButtomForm.pdf");
        }
    }
}
```

### Display Radio Button PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/radioButtomForm.pdf#zoom=110" width="100%" height="400px">
</iframe>

### Adding Radio Buttons via Code

Programmatic addition of radio buttons is executed by creating instances of **RadioFormField**, configuring parameters, and including them in your PDF.

```cs
using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section7
    {
        public void Run()
        {
            // Initialize the PDF Renderer
            ChromePdfRenderer renderer = a new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");
            
            // Radio form configurations
            string name = "choice";
            string value = "yes";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 15;
            double height = 15;
            
            // Creation and addition of radio forms
            var yesRadioForm = new RadioFormField(name, value, pageIndex, x, y, width, height);
            
            value = "no";
            x = 200;
            
            // Second radio form
            var noRadioForm = new RadioFormField(name, value, pageIndex, x, y, width, height);
            
            pdf.Form.Add(yesRadioForm);
            pdf.Form.Add(noRadioForm);
            
            pdf.SaveAs("addRadioForm.pdf");
        }
    }
}
```

### View Radio Button PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/create-forms/addRadioForm.pdf#zoom=100" width="100%" height="300px">
</iframe>

For clarity and to provide orientation, include labels for the radio buttons using the `DrawText` method. Discover more about setting text and images on PDFs in the comprehensive guide [here](https://ironpdf.com/how-to/draw-text-and-bitmap/).

<hr>

## Implementing Image Forms Programmatically

Image forms are exclusively added through code. Start by creating an **ImageFormField** with configured parameters, and then append it to your PDF document.

```cs
using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section8
    {
        publi