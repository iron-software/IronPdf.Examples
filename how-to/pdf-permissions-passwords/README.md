# Implementing PDF Security: Passwords and Permissions Explained

***Based on <https://ironpdf.com/how-to/pdf-permissions-passwords/>***


<div class="alert alert-info iron-variant-1" role="alert">
    Is your company overspending on PDF security and compliance yearly subscriptions? Discover <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> which offers a suite of features including digital signing, redaction, and encryption in a cost-effective, one-time payment model. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Learn More About IronSecureDoc</a>
</div>

Securing a PDF involves encrypting the file to avoid access by unauthorized users. Typically, there are two types of passwords involved: a user password, which needs to be entered to open the PDF, and an owner password, which allows setting varying permissions such as the ability to edit or print the document.

IronPDF provides comprehensive support for securing your PDFs. Whether you are working with new or existing documents, IronPDF enables you to apply detailed security settings including encryption, making documents unprintable or read-only, and using advanced encryption techniques like 128-bit encryption for securing your documents.

## Adding a Password to a PDF

Here is a scenario where we need to secure an [example PDF](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/unprotected.pdf) using IronPDF. Below, we'll apply a password using the IronPDF library. In this case, our choice of password is **password123**.

```cs
using IronPdf;
namespace ironpdf.PdfPermissionsPasswords
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Create a PDF from HTML content.
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Confidential Report:</h1> Hello World");
            
            // Set Owner Password which allows editing.
            pdf.SecuritySettings.OwnerPassword = "123password";
            
            // Set User Password required to open the PDF.
            pdf.SecuritySettings.UserPassword = "password123";
            
            // Save the encrypted PDf
            pdf.SaveAs("protected.pdf");
        }
    }
}
```

After protecting the PDF, you will need the password **password123** to open it.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/protected.pdf" width="100%" height="500px">
</iframe>

## Accessing a Password-Protected PDF

The following segment shows how to access and interact with a PDF that is protected by a password using IronPDF. The `PdfDocument.FromFile` method facilitates this by accepting a password for the encrypted PDF.

```cs
using IronPdf;
namespace ironpdf.PdfPermissionsPasswords
{
    public class Section2
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("protected.pdf", "password123");
            
            // Example operations on the PDF
            
            // Save the manipulated PDF to a new file
            pdf.SaveAs("protected_2.pdf");
        }
    }
}
```

<hr>

## Setting Advanced Security and Permissions

The **PdfDocument** object allows further customization of security settings and metadata, such as **Author** and **ModifiedDate**. Below we demonstrate how various permissions and settings can be modified to enhance document security.

```cs
using IronPdf;
namespace ironpdf.PdfPermissionsPasswords
{
    public class Section3
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("protected.pdf", "password123");
            
            // Modify security settings to enforce restrictions
            pdf.SecuritySettings.RemovePasswordsAndEncryption();
            pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserFormData = false;
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;
            
            // Finalizing and saving the secured PDF
            pdf.SaveAs("secured.pdf");
        }
    }
}
```

Document permissions interact with password settings in the following ways:

- **No password**: Copy/pasting content remains blocked.
- **User password**: Granting the user password will unlock copy/paste features.
- **Owner password**: Access with only the user password restricts copy/paste operations; an owner password is required for these permissions.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/permissions.webp" alt="Permissions window" class="img-responsive add-shadow">
    </div>
</div>

Explore a related topic on handling PDF metadata with this detailed guide: "[Setting and Editing PDF Metadata](https://ironpdf.com/how-to/metadata/)."