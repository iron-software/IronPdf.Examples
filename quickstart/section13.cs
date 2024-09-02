using IronOcr;
using System;

IronTesseract ocr = new IronTesseract();
using (OcrInput Input = new OcrInput())
{
    // OCR entire document
    Input.LoadPdf("Invoice.pdf", Password: "password");

    // Use filters to increase image quality
    Input.Deskew();
    Input.DeNoise();

    OcrResult Result = ocr.Read(Input);

    Console.WriteLine(Result.Text);
    var Barcodes = Result.Barcodes;
    string Text = Result.Text;
}