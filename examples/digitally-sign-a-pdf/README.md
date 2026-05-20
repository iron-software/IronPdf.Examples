***Based on <https://ironpdf.com/examples/digitally-sign-a-pdf/>***

<div class="alert alert-info iron-variant-1" role="alert">
  If your company is burdened by hefty annual fees related to PDF security and compliance, consider switching to <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>. This robust offering includes tools for digital signing, redaction, encryption, and document protection within a single, one-time payment model. Learn more about it by exploring the <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc documentation</a>.
</div>

Adding a digital signature to a PDF can be pivotal in ensuring the document's authenticity and security. This functionality allows you to confirm the origin and integrity of the PDF. With IronPDF, users have several avenues available for signing PDFs. Options range from using a digital certificate, incorporating a graphic representation of a handwritten signature, stamping the document with an image of the certificate, to integrating a form field specifically for applying a user's signature.

## Steps to Digitally Sign a PDF Using IronPDF

Start by deciding whether to load an existing PDF or create a new one from scratch. In this guide, we opt for the latter, crafting a fresh PDF from HTML content. First, instantiate a new `ChromePdfRenderer`, IronPDF's robust engine for converting HTML, CSS, and JavaScript into a flawless PDF document. Utilize the `RenderHtmlAsPdf` method to transform your HTML code into a pristine PDF ready for signing, saved into the `doc` variable.

Following this, a signature must be prepared. Here we'll digitally sign the PDF using a specified certificate by leveraging the `PdfSignature` class. This entails specifying the path to your `.pfx` file, plus the corresponding password for file access. You can introduce additional signature details like `SigningContact` (for email or phone info), `SigningLocation` (to denote where the signature was applied), and `SigningReason` (to explain the purpose behind the signature).

With the `PdfSignature` object ready, apply it to your PDF by invoking the `Sign` method. This command consolidates the application of the digital signature into a streamlined process. You can also apply multiple certificates if needed.

Finally, preserve your newly signed PDF document by calling `SaveAs`, which will store the file in your designated location.

<a href="https://ironpdf.com/how-to/signing/" class="code_content__related-link__doc-cta-link">Learn more about Secure PDF Signing with IronPDF.</a>