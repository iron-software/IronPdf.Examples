<div class="alert alert-info iron-variant-1" role="alert">
    Are your yearly expenditures on PDF security and compliance too high? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a comprehensive solution that includes digital signing, redaction, encryption, and protection, all available for a one-time fee. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try</a>
</div>

IronPDF enables you to construct editable PDF documents with the same ease as creating standard documents. The `PdfForm` class encompasses a suite of user-editable form fields within a PDF document. This class can be integrated into your PDF rendering process to transform it into a form or an editable document.

Here's a guide on how to produce editable PDF forms using IronPDF.

Creating PDFs with editable forms is straightforward using HTML by integrating `<form>`, `<input>`, and `<textarea>` elements into your HTML content.

To access and modify any form field, utilize the `PdfDocument.Form.GetFieldByName` method. The name of the field corresponds to the 'name' attribute assigned to that field in your HTML.

The `PdfDocument.Form` object can be utilized in a couple of different ways:

- Firstly, to preset the default values of form fields, which require activation in Adobe Reader to show these values.
- Secondly, to extract data from PDF forms that users have completed, irrespective of the language used.