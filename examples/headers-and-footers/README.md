***Based on <https://ironpdf.com/examples/headers-and-footers/>***

PDF documents can be enhanced with headers and footers in two primary ways:

- Traditional text headers and footers provide a straightforward method to incorporate text elements, with capabilities to integrate dynamic content.
- [HTML headers and footers via IronPDF](https://ironpdf.com/examples/html-headers-and-footers/), this method allows developers to integrate HTML content into PDF headers and footers, offering a more adaptable approach to embedding dynamic content, though it can be more complex to utilize.

`TextHeaderFooter`, a class provided by IronPDF, is tailored to set up headers and footers efficiently for common scenarios.

Here, we illustrate how to implement traditional text headers and footers in your PDFs using IronPDF.

When you're setting up headers and footers, there is an option to align the header text centrally within the document. Additionally, incorporating metadata into your header is possible by utilizing placeholders found in the [TextHeaderFooter API Documentation](https://ironpdf.com/object-reference/api/IronPdf.TextHeaderFooter.html). Features like adding a line separator between the page content and the headers or footers, customizing font styles and sizes are also available. This functionality is extremely handy, covering a comprehensive range of needs.