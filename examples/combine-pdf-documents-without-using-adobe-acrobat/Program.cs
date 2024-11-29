using IronPdf;
using System.Collections.Generic;


public class PDFMerger
{
    public static void MergePDFs()
    {
        // Create an instance of the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();
        // Load the first PDF file
        var firstPdf = PdfDocument.FromFile("First.pdf");


        // Load the second PDF file
        var secondPdf = PdfDocument.FromFile("Second.pdf");
        var combinedPDF = PdfDocument.Merge(firstPdf, secondPdf);
        // Save the merged PDF to a file
        combinedPDF.SaveAs("Merged.pdf");
    }
}
