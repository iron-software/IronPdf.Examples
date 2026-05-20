***Based on <https://ironpdf.com/examples/create-blank-page/>***

Generating a blank PDF page typically involves creating a page in a PDF document that lacks any text, images, or graphical content. This might be strategically done for varying reasons, such as providing space for annotations, dividing sections in a document, or arranging content in a particular format.

To construct a PDF containing a blank page through IronPDF, the process is quite simple. For comprehensive instructions on crafting PDF documents via IronPDF, delve into the [IronPDF Official Documentation](https://ironpdf.com/docs/). You just need to specify two parameters, width and height, to the **PdfDocument** constructor to initiate a PDF with a blank page.

- **Width and Height:** These are the measurements for the PDF page, given in millimeters. This example uses the dimensions typical of an A4 sheet, measuring 210 mm by 297 mm.
- **PdfDocument Constructor:** The `PdfDocument` class from the IronPDF library accepts two integers representing width and height. It enables the creation of a new PDF document featuring a single blank page of the specified dimensions.
- **SaveAs Method:** Apply this method to store the newly minted PDF on your file system. In this specific instance, the file is saved under the name "BlankPage.pdf".
- **Console Output:** Upon completing the PDF generation, a brief message is output to the console to affirm that the process has concluded.

Explore how to craft new PDFs with IronPDF by checking out the following resource: [Learn to Create New PDFs with IronPDF Now!](https://ironpdf.com/how-to/create-new-pdfs/)