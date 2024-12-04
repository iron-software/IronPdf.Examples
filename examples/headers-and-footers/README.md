***Based on <https://ironpdf.com/examples/headers-and-footers/>***

There are two primary methods for incorporating headers and footers into PDF documents:

1. **Text-based Headers and Footers**: This traditional method enables the inclusion of text headers, and allows for the integration of dynamic data within them.
2. **[HTML Headers and Footers with IronPDF](https://ironpdf.com/examples/html-headers-and-footers/)**: This technique permits developers to embed HTML content as headers and footers in PDF files, enhancing flexibility with the capability to template dynamic data. This approach offers greater versatility but may be more complex to implement.

The `TextHeaderFooter` class within IronPDF is specifically designed to manage the display options for PDF headers and footers, providing a structured method to apply these elements in typical scenarios.

Here’s how you can add traditional text headers and footers to your PDFs using IronPDF:

When configuring headers and footers, you have the flexibility to center the header text across the PDF. Additionally, dynamic metadata can be incorporated into the header via placeholder strings, which are detailed in the [TextHeaderFooter API Documentation](https://ironpdf.com/object-reference/api/IronPdf.TextHeaderFooter.html). It's also possible to insert a horizontal line to separate the header or footer from the main content on each page. This feature enforces the use of standard fonts and sizes, making it an exceptionally beneficial tool that meets diverse needs.