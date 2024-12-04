# Managing Attachments in PDF Files Using IronPDF

***Based on <https://ironpdf.com/how-to/add-remove-attachments/>***


Attachments within a PDF are essentially files or data that are embedded in the PDF itself, separate from the primary content like text and images. These may be in various file formats such as images, text documents, spreadsheets, and are embedded to provide additional information or supporting data to the PDF viewer.

IronPDF provides an efficient and straightforward approach to handle these attachments.

## Example: Adding an Attachment

To embed a file into a PDF, you'll initially need to load the file as a `byte[]` array. This is commonly achieved by employing the `File.ReadAllBytes` method. Once the file is in the proper format, you can add it to your existing PDF document using the `AddAttachment` method:

```cs
using System.IO;
using IronPdf;
namespace ironpdf.AddRemoveAttachments
{
    public class Section1
    {
        public void Run()
        {
            // Load file as byte array
            byte[] fileData = File.ReadAllBytes(@"path/to/file");
            
            // Open an existing PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Incorporate the file as an attachment
            pdf.Attachments.AddAttachment("Example", fileData);
            
            // Save the file with attachments
            pdf.SaveAs("addAttachment.pdf");
        }
    }
}
```

Once you save the PDF and open it using a PDF viewer like Google Chrome, the attachment shows up in the toolbar. Click the attachment for a preview and the option to save it locally, as illustrated below:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/attachment-example.png)

## Example: Removing an Attachment

Removing an attachment is just as intuitive. Use the `RemoveAttachment` method, which requires the attachment reference obtained from the **Attachments** list in the PDF document. Here’s how you can access and remove an attachment:

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.AddRemoveAttachments
{
    public class Section2
    {
        public void Run()
        {
            // Access the PDF with the attachment
            PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");
            
            // Retrieve attachment reference
            PdfAttachmentCollection retrieveAttachments = pdf.Attachments;
            
            // Detach the referenced attachment
            pdf.Attachments.RemoveAttachment(retrieveAttachments.First());
            
            // Save the updated PDF
            pdf.SaveAs("removeAttachment.pdf");
        }
    }
}
```

After the attachment is removed and the document is reopened in a PDF viewer, the attachment will no longer be present:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/removeattachment-example.png)