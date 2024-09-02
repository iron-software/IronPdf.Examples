Headers and footers can be integrated into PDF documents using two primary methods:

- Traditional text-based headers and footers allow for the inclusion of text, including dynamic data.
- [HTML-based headers and footers](https://ironpdf.com/examples/html-headers-and-footers/), which provide the ability to incorporate HTML content into the headers and footers of a PDF. This technique offers greater flexibility but may pose greater challenges in usage.

IronPDF's `TextHeaderFooter` class is specifically designed for setting up the configuration of PDF headers and footers. It provides a straightforward method tailored for typical requirements.

Below, we illustrate how to implement conventional text headers and footers within your PDF documents using IronPDF:

When applying headers and footers, you can align the header text centrally within the PDF document. Additionally, dynamic data can be inserted into your header through placeholders, the details of which can be located [here](https://ironpdf.com/object-reference/api/IronPdf.TextHeaderFooter.html). You may also include a horizontal line to visually separate the header or footer from the main content on each page of the PDF. This feature allows adjustments in font styles and sizes, offering a complete solution for header and footer customization.