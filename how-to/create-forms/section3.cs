using IronPdf;

// Input and Text Area forms HTML
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

// Instantiate Renderer
ChromePdfRenderer Renderer = new ChromePdfRenderer();
Renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("checkboxAndComboboxForm.pdf");