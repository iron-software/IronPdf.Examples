***Based on <https://ironpdf.com/examples/barcode-htmltopdf/>***

IronPDF not only supports custom fonts but also extends its capabilities to include web fonts like [Barcode Fonts with IronPDF](https://ironpdf.com/examples/barcode-htmltopdf/), allowing for the easy inclusion of barcode details in your PDF projects. This feature lets developers efficiently integrate barcode representations directly into PDF files.

Here's how you can utilize IronPDF to embed barcodes in your PDF documents.

Nonetheless, there might be instances where specific barcode types, such as QR codes, aren't supported directly. For these scenarios, you can use [IronOCR for generating barcodes](https://ironsoftware.com/csharp/ocr/) and subsequently incorporate them into your PDFs as images.

To discover various styles for barcode rendering, visit Google Fonts which offers seven Google WebFont-based barcode styles. However, it's important to note certain restrictions with this approach, including the necessity for a `RenderDelay`. Additionally, due to security precautions, web fonts are not supported on Azure's shared Windows Web App hosting environments.