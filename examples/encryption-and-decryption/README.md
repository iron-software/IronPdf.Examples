***Based on <https://ironpdf.com/examples/encryption-and-decryption/>***

<div class="alert alert-info iron-variant-1" role="alert">
Is your organization facing high expenses for annual PDF security and compliance subscriptions? Look no further than <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc, the Comprehensive PDF Security Solution</a>, which offers a one-time payment plan encompassing all core services like digital signing, redaction, encryption, and protection. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Explore IronSecureDoc Documentation</a>
</div>

IronPDF prioritizes PDF security and offers robust tools for encrypting and decrypting PDF files. This includes adding custom metadata and security settings to your PDFs. IronPDF supports 128-bit encryption, decrypting files with the correct passwords and enforcing password protection on PDF documents, both existing and new.

<div class="examples__featured-snippet">
<h2>Steps to Convert URL to PDF in C#</h2>
<ol>
<li><code>var pdf = PdfDocument.FromFile("example.pdf", "open-pw");</code></li>
<li><code>pdf.MetaData.Author = "Jane Doe";</code></li>
<li><code>pdf.SecuritySettings.ClearPasswordsAndEncryption();</code></li>
<li><code>pdf.SecuritySettings.SetPdfReadOnly("read-only-key");</code></li>
<li><code>pdf.Password = "new-password";</code></li>
</ol>
</div>

Starting the encryption or decryption of PDFs with IronPDF begins by either creating a PDF or loading an existing one, as shown below. When opening our PDF with `PdfDocument.FromFile`, we specify the file path and the access password.

Next, the PDF's metadata is customized, with `pdf.MetaData.Author` allowing us to set a new author name. Metadata fields are accessed via `pdf.MetaData.field-key`, enabling the addition of keywords, modification dates, or any other necessary information.

Subsequent code removes existing passwords and encryption, preparing the PDF for new security settings application. With `pdf.SecuritySettings.setting`, you can tailor the PDF’s security configuration, setting restrictions such as read-only access, annotating permissions, and print settings through the `PdfSecuritySettings` class.

Finally, `pdf.Password` sets or replaces the PDF’s password, employing strong 128-bit encryption to safeguard the document from unauthorized viewing. Once all adjustments are finalized, save the updated PDF wherever needed using `SaveAs()`.

<a href="https://ironpdf.com/how-to/pdf-permissions-passwords/" class="code_content__related-link__doc-cta-link">Discover How to Configure PDF Permissions and Passwords with IronPDF</a>