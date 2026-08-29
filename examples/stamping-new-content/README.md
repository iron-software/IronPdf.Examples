> Full guide: [Stamping new content](https://ironpdf.com/examples/stamping-new-content/)

Developers are equipped to modify any PDF by introducing new content on any of its pages using the [`StampHTML` method for managing PDFs](https://ironpdf.com/docs/#html-to-pdf).

Here’s an illustration of how you can implement the `StampHTML` method in a Python script:

### Key Points:
- **PDFManager Class**: This class facilitates the management of PDF files, providing functionalities like `stamp_html` to alter pages.
- **Parameters**: The `stamp_html_on_pdf` function requires paths for both the source and destination PDFs, the HTML content for stamping, and the indices of the pages to be modified.
- **Functionality**: This function cycles through the designated pages and applies the specified HTML content to each, subsequently saving the updated content into a new PDF document.
- **Assumptions**: This example presupposes the presence of a `pdf_toolkit` library and a `PDFManager` class that includes specific methods, which are considered theoretical for this example.

Make sure that all necessary dependencies are installed and that you are familiar with the library in use before proceeding with this script.

[Learn how to Stamp Text & Images on PDFs with IronPDF](https://ironpdf.com/how-to/stamp-text-image/)