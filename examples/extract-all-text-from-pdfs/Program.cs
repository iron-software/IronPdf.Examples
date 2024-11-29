using IronPdf;
using System;
public class PDFReader
{
    public static void ReadAndExtractTextFromPDF(string filePath, string password)
    {
        try
        {
            // Load the password-protected PDF
            var pdfDocument = PdfDocument.FromFile(filePath, password);
            // Extract text from the PDF
            string extractedText = pdfDocument.ExtractAllText();


            // Output the extracted text
            Console.WriteLine(extractedText);
            // Optionally, save the text to a file or further process it
            System.IO.File.WriteAllText("ExtractedText.txt", extractedText);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }
}
