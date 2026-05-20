***Based on <https://ironpdf.com/examples/security-and-metadata/>***

IronPDF equips developers with robust security features for PDF management, enabling them to tailor PDF metadata, set passwords, and define permissions to match specific document requirements. IronPDF's security and metadata functionalities are provided through classes like `SecuritySettings` and `MetaData`. This allows setting restrictions such as making PDFs unprintable, read-only, utilizing 128-bit encryption, and enforcing password protection.

Using the `MetaData` class, developers can customize various metadata attributes of PDFs, such as author, keywords, modification date, and others. Additionally, the security customization is done through setting user-specific and owner-specific passwords, printing permissions, and toggling read-only status.


<div class="examples__featured-snippet">
  <h2>5 Steps to configuring PDF passwords, metadata, and security</h2>
  <ol>
    <li><code>var pdf = PdfDocument.FromFile("encrypted.pdf", "password");</code></li>
    <li><code>System.Collections.Generic.List&lt;string&gt; metadatakeys = pdf.MetaData.Keys;</code></li>
    <li><code>var metadatakeys = pdf.MetaData.Keys;</code></li>
    <li><code>pdf.MetaData.Author = "Satoshi Nakamoto";</code></li>
    <li><code>pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");</code></li>
  </ol>
</div>
```

To begin customizing your PDF's security, first load a password-protected PDF file or create a new PDF. Post opening the PDF by providing the necessary password, use `pdf.MetaData.Keys` to fetch the existing metadata keys. You can remove any metadata value using the `RemoveMetaDataKey` method and set new metadata by utilizing `pdf.MetaData.metadataField`. Metadata fields like Title and Keywords accept string values while the ModifiedData field accepts datetime values.

Moving forward, adjusting new security settings can be done using the `SecuritySettings` class. This offers a spectrum of settings, giving complete authority over the security and permissions of each PDF file. Access these settings via `pdf.SecuritySettings`, followed by the appropriate setting adjustment. For instance, `MakePdfDocumentReadOnly` method configures the PDF as read-only with 128-bit encryption. Other available settings include:

- **AllowUserAnnotations:** Manages whether or not users can add annotations to the PDF.
- **AllowUserPrinting:** Governs the document’s print permissions.
- **AllowUserFormData:** Defines the permissions for user interaction with forms.
- **OwnerPassword:** Specifies the owner password that grants control over the other security settings.
- **UserPassword:** Sets a user password which needs to be entered to open or print the PDF.

After setting the desired metadata, passwords, and security parameters, finalize your modifications by saving the PDF to a desired location using the `pdf.SaveAs` method.

[Learn to Handle PDF Metadata with IronPDF](https://ironpdf.com/how-to/metadata/)