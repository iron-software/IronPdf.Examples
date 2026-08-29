> Full guide: [Barcode htmltopdf](https://ironpdf.com/examples/barcode-htmltopdf/)

IronPDF extends its functionality by not only supporting a wide variety of custom fonts, like those from Google Fonts, but also by enabling the embedding of barcodes into PDF documents. This feature greatly simplifies the process for developers to incorporate barcode data into their PDF outputs.

## Steps to Generate a PDF with a Barcode Using IronPDF

To begin, make sure that the IronPDF library is properly installed and included in your project. Following installation, instantiate the `ChromePdfRenderer` class. This class is instrumental in converting HTML content into high-quality PDF files.

The next step involves constructing your barcode display. For illustration, consider an HTML string that utilizes a Google Fonts link for the "Libre Barcode 128" font. Convert this HTML string into a PDF document using the `RenderHtmlAsPdf` method.

After rendering the HTML, create a barcode stamp, which in this example will display "Hello World" using the Code39 barcode format, and apply this stamp to the PDF with the `ApplyStamp` method.

Conclude the operation by saving your newly created PDF file as "bc-test.pdf" with the `SaveAs` method. This method furnishes an effective way to combine styled text and barcode data into a single document in your C# applications. It's important to note that certain barcode types, like QR Codes, may not be directly supported. For these types, it is advisable to use [IronBarcode](https://ironsoftware.com/csharp/barcode/) to create the barcode or QR Code and then integrate it as an image into the PDF.

[Discover how to incorporate images into PDFs using IronPDF](https://ironpdf.com/how-to/add-images-to-pdfs/)