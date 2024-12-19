# How to Secure PDF Documents with Passwords and Permissions

***Based on <https://ironpdf.com/how-to/pdf-permissions-passwords/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Tired of overpaying for annual PDF security subscriptions? Switch to <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a one-time cost solution handling all your SaaS needs like digital signatures, redaction, encryption, and protection. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Check out the IronSecureDoc Documentation</a>
</div>

Securing a PDF involves encryption to prevent unauthorized viewing. Typically, there are two types of passwords involved: a user password that's needed to open the document, and an owner password that restricts permissions such as editing and printing.

IronPDF is equipped to handle all your needs related to password protection and permission settings for your PDF files. It lets you apply detailed security and metadata settings, such as making documents non-printable, read-only, or fully encrypted using 128-bit encryption methods.

<h3>Getting Started with IronPDF</h3>

---

## Protect a PDF with a Password

Consider this [example PDF](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/unprotected.pdf) which we'll protect using IronPDF. Below is how you can add a password to your PDF. We'll use `password123` as the user password for illustration purposes.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Confidential Info:</h1> Greetings Everyone");

// Sets the owner password
pdf.SecuritySettings.OwnerPassword = "123password";

// Sets the user password
pdf.SecuritySettings.UserPassword = "password123";

pdf.SaveAs("protected.pdf");
```

Access the resulting [protected PDF](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/protected.pdf) by entering the password `password123`.

## How to Access a Password-Protected PDF

The following illustrates opening a password-protected PDF document using IronPDF. The `PdfDocument.FromFile` method accepts a password as its optional second argument.

```cs
using IronPdf;

var pdf = PdfDocument.FromFile("protected.pdf", "password123");

//... further PDF operations

pdf.SaveAs("updated_protected.pdf"); // Save modifications to another file
```

<hr>

## Enhanced Security and Permission Options

For more control over your PDF's security, the `PdfDocument` object allows setting metadata like **Author** and **ModifiedDate**. You can also disable User Annotations, User Printing, and more.

```cs
using IronPdf;

// Open a previously encrypted PDF or generate a new one from HTML
var pdf = PdfDocument.FromFile("protected.pdf", "password123");

// Updating file security settings
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Store the newly secured PDF
pdf.SaveAs("fully_secured.pdf");
```

Permission settings directly correlate with the set document passwords. For instance, disabling the **AllowUserCopyPasteContent** works as follows:

- **No password applied**: Copy/paste remains blocked.
- **User password applied**: Entering the appropriate user password enables copy/paste functionality.
- **Owner password applied**: Entering just the user password will not enable copy/paste; however, the right owner password will.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/permissions.webp" alt="Permissions window" class="img-responsive add-shadow">
    </div>
</div>

A related topic of interest includes setting and modifying PDF metadata. Further details can be found in the article: "[How to Set and Edit PDF Metadata](https://ironpdf.com/how-to/metadata/)."