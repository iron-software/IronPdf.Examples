using IronPdf.Rendering;
using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpCreatePdfCompleteTutorial
{
    public static class Section9
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