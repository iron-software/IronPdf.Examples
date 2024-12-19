using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.PageOrientationRotation
{
    public static class Section2
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("landscape.pdf");
            
            // Set all pages
            pdf.SetAllPageRotations(PdfPageRotation.Clockwise90);
            
            // Set a single page
            pdf.SetPageRotation(1, PdfPageRotation.Clockwise180);
            
            // Set multiple pages
            List<int> selectedPages = new List<int>() { 0, 3 };
            pdf.SetPageRotations(selectedPages, PdfPageRotation.Clockwise270);
            
            pdf.SaveAs("rotatedLandscape.pdf");
        }
    }
}