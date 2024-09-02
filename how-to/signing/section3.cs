using IronPdf.Signing;
using IronSoftware.Drawing;

// Create PdfSignature object
var sig = new PdfSignature("IronSoftware.pfx", "123456");

// Add image by property
sig.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Add image by LoadSignatureImageFromFile method
sig.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Import image using IronSoftware.Drawing
AnyBitmap image = AnyBitmap.FromFile("IronSoftware.png");

sig.LoadSignatureImageFromStream(image.ToStream(), 0, new Rectangle(0, 600, 100, 100));