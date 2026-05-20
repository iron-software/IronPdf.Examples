***Based on <https://ironpdf.com/examples/form-data/>***

<div class="alert alert-info iron-variant-1" role="alert">
  Is your company spending excessive amounts on annual subscriptions for PDF security and compliance? Consider switching to 
  <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc - a holistic PDF Security approach</a>, 
  offering features like digital signatures, redaction, encryption, and protection in a single purchase. 
  <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Discover more about IronSecureDoc</a>.
</div>

With IronPDF, creating editable PDF documents is as straightforward as working with a regular document. The `PdfForm` class hosts a suite of editable form fields within a PDF. This can be integrated into your PDF rendering process to transform a static document into an interactive form.

Here's how you can create editable PDF forms using IronPDF:

Create editable PDF forms from HTML by incorporating `<form>`, `<input>`, and `<textarea>` tags into your HTML structure.

Utilize the `PdfDocument.Form.FindFormField` method to both read and update any form field. The identification of the field corresponds to its 'name' attribute in your HTML.

The `PdfDocument.Form` object can be leveraged in two primary ways:

- **Setting Default Values**: Use this feature to assign default values to form fields, which will be visible in PDF applications like Adobe Reader.
- **Capturing User Input**: Once the form is filled out by a user, retrieve and process the data from the form fields back into your software system.

Consider the following scenario where we import the IronPdf library and establish a function named `CreateEditablePdfDocument`. This function orchestrates the creation of an editable PDF by defining an HTML form with input elements for a username and comments. With the `HtmlToPdf` converter, we transform this HTML into an interactive PDF.

The form fields within the `pdfDocument.Form` are then accessed and manipulated to preset default values visible upon opening the document in a PDF application. The finished document, titled "EditableForm.pdf", is saved and can be distributed with its editable fields intact.

<a href="https://ironpdf.com/how-to/edit-forms/" class="code_content__related-link__doc-cta-link">Discover How to Edit PDF Forms with IronPDF - How-To Guide</a>