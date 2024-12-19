***Based on <https://ironpdf.com/examples/form-data/>***

<div class="alert alert-info iron-variant-1" role="alert">
  Your organization may be overspending on annual subscriptions for PDF security and compliance. We recommend checking out <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc, a Comprehensive PDF Security Solution</a>. This product offers a robust suite of features for managing SaaS services, including digital signing, redaction, encryption, and protection, available with a single purchase. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">View IronSecureDoc Documentation</a>
</div>

IronPDF allows you to effortlessly create editable PDF documents just as you would create any regular document. The `PdfForm` class contains a series of user-editable form fields within a PDF document. This can be integrated into your PDF rendering process to transform it into an interactive form or an editable document.

Here’s a guide on how to construct editable PDF forms using IronPDF.

Creating PDFs with editable forms is straightforward. Simply include `<form>`, `<input>`, and `<textarea>` tags within the parts of your HTML document.

To access and modify any form field, utilize `PdfDocument.Form.FindFormField`. The field's name in the PDF will match the 'name' attribute assigned to that field in the HTML source.

The `PdfDocument.Form` object provides two functionalities:

- Firstly, it allows setting the default values of form fields, which Adobe Reader requires to be in focus to display these values.
- Secondly, it enables the extraction of data from PDF forms that have been filled out by users, supporting various languages.