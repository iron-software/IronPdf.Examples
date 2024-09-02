using IronPdf;
using System.Linq;

// Open existing PDF
PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");

// Add attachment to the PDF
PdfAttachmentCollection retrieveAttachments = pdf.Attachments;

// Remove attachment from PDF
pdf.Attachments.RemoveAttachment(retrieveAttachments.First());

pdf.SaveAs("removeAttachment.pdf");