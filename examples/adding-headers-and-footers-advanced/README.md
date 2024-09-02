IronPDF provides functionalities to append headers and footers to PDF documents both existing and newly created.

Additionally, IronPDF enables the customization of headers and footers in PDFs. This can be achieved by implementing methods only **after** the document is fully rendered. Here are the methods used to perform this:

- [`IronPdf.PdfDocument.AddTextHeaders`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddHeaders_IronPdf_TextHeaderFooter_System_Boolean_System_Collections_Generic_IEnumerable_System_Int32__)
- [`IronPdf.PdfDocument.AddTextFooters`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddFooters_IronPdf_TextHeaderFooter_System_Boolean_System_Collections_Generic_IEnumerable_System_Int32__)
- [`IronPdf.PdfDocument.AddHtmlHeaders`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddHTMLHeaders_IronPdf_HtmlHeaderFooter_System_Boolean_System_Collections_Generic_IEnumerable_System_Int32__)
- [`IronPdf.PdfDocument.AddHtmlFooters`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_AddHTMLFooters_IronPdf_HtmlHeaderFooter_System_Boolean_System_Collections_Generic_IEnumerable_System_Int32__)