using IronPdf;

// Step 1. Create a PDF
var renderer = new ChromePdfRenderer();
var doc = renderer.RenderHtmlAsPdf("<h1>Testing 2048 bit digital security</h1>");

// Step 2. Create a Signature.
// You may create a .pfx or .p12 PDF signing certificate using Adobe Acrobat Reader.
// Read: https://helpx.adobe.com/acrobat/using/digital-ids.html
var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    // Step 3. Optional signing options and a handwritten signature graphic
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "To show how to sign a PDF"
};

//Step 4. Sign the PDF with the PdfSignature. Multiple signing certificates may be used
doc.Sign(signature);

//Step 5. The PDF is not signed until saved to file, steam or byte array.
doc.SaveAs("signed.pdf");