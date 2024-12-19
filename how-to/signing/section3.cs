using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section3
    {
        public static void Run()
        {
            // Create PdfSignature object
            var sig = new PdfSignature("IronSoftware.pfx", "123456");
            
            // Add image by property
            sig.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));
            
            // Add image by LoadSignatureImageFromFile method
            sig.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));
            
            // Import image using IronSoftware.Drawing
            AnyBitmap image = AnyBitmap.FromFile("IronSoftware.png");
            
            sig.LoadSignatureImageFromStream(image.ToStream(), 0, new Rectangle(0, 600, 100, 100));
        }
    }
}