***Based on <https://ironpdf.com/examples/google-fonts-htmltopdf/>***

Utilizing custom fonts is essential for creating PDFs with a distinct style. Many enterprises and organizations choose to embed custom fonts alongside unique icons or graphics to enhance their branding. IronPDF accommodates this need by supporting web fonts, such as the extensive Google Fonts library.

The following example illustrates how to incorporate your own custom fonts into PDF documents using the custom fonts capability provided by IronPDF.

This feature grants developers complete control over font choices, eliminating reliance on default system typefaces.

However, there's a slight complication when using custom fonts in your PDFs. You'll need to consider a `RenderDelay`. Additionally, web fonts are not supported on Azure's shared Windows Web App hosting due to Microsoft's security policies.

Supported Web Fonts Include:

- [Font Awesome](https://fontawesome.com/)
- [Bootstrap Glyphs](https://getbootstrap.com/docs/3.3/components/)
- [Google Fonts](https://fonts.google.com/)
- [Barcode Fonts with IronPDF HTML to PDF Conversion Example](https://ironpdf.com/examples/barcode-htmltopdf/)
- Your personalized WOFF or SVG-based CSS font packages.