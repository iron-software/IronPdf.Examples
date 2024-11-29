using IronPdf;
using System.IO;

// Instantiate the Renderer and create PdfDocument from HTML
var renderer = new ChromePdfRenderer();
var myPdf = renderer.RenderHtmlFileAsPdf("my-content.html");

// Load your own attachment
byte[] attachment = File.ReadAllBytes("path/to/attachment");

// Here we can add an attachment with a name and a byte[]
PdfAttachment exampleAttachment = myPdf.Attachments.AddAttachment("exampleAttachment", attachment);

// And here is an example of removing an attachment
myPdf.Attachments.RemoveAttachment(exampleAttachment);

myPdf.SaveAs("my-content.pdf");
