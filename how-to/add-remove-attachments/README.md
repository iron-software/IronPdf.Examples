# Managing PDF Attachments with IronPDF

***Based on <https://ironpdf.com/how-to/add-remove-attachments/>***


Attachments within a PDF are essentially files or extras embedded separately from the visible main contents such as text, images, and layout. These attachments might be diverse types of files like images, textual documents, spreadsheets, and so forth. These are particularly useful for incorporating extra reference materials or additional data that can enhance the functionality or information delivered by the PDF.

IronPDF offers an intuitive and straightforward approach to manipulate these attachments.

## Example: Adding an Attachment

To begin, you need to load the file you intend to attach into your program, typically as a **byte[]**. The simplest method to accomplish this is by utilizing the `File.ReadAllBytes` method. Once the file is loaded, it can be attached to a PDF document using the `AddAttachment` method as shown below:

```cs
using IronPdf;
using System.IO;

// Load file data
byte[] fileData = File.ReadAllBytes(@"path/to/file");

// Load an existing PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Attach the file to the PDF
pdf.Attachments.AddAttachment("Example", fileData);

// Save the updated PDF
pdf.SaveAs("addAttachment.pdf");
```

This method returns a **PdfAttachment** object which can be managed or even removed later if necessary.

After saving the updated PDF, any attached files can be accessed and downloaded using the attachment feature in PDF viewers like the one in Google Chrome, as shown in the image below:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/attachment-example.png)

## Example: Removing an Attachment

To delete an attachment from a PDF, use the `RemoveAttachment` method. This process involves retrieving a reference to the desired attachment, which you can obtain from the **Attachments** property. The steps below illustrate how to remove an attachment using the previously modified file:

```cs
using IronPdf;
using System.Linq;

// Load the previously modified PDF
PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");

// Access the collection of attachments
PdfAttachmentCollection retrieveAttachments = pdf.Attachments;

// Remove the first attachment
pdf.Attachments.RemoveAttachment(retrieveAttachments.First());

// Save the updated PDF
pdf.SaveAs("removeAttachment.pdf");
```

Once the attachment has been removed and you open the updated PDF in a viewer, it's evident that the attachment is no longer included:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/removeattachment-example.png)