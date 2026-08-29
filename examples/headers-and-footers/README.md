> Full guide: [Headers and footers](https://ironpdf.com/examples/headers-and-footers/)

This article discusses two primary methods for adding headers and footers to PDF documents. You can either incorporate them using traditional text, with capabilities for embedding dynamic data, or employ HTML for more dynamism through custom HTML content.

## How to Insert Headers and Footers into PDFs Using IronPDF

This guide adds text headers and footers to a PDF. Declare `using IronPdf;` in the project, then create a `ChromePdfRenderer` instance to render the HTML.

The next step involves configuring the header settings. Utilize the `FirstPageNumber` property to set where headers begin, useful for documents with a title page. Customize your headers through the `TextHeader` options, where you can choose settings such as a divider line, centered text displaying the document URL, a specific font style and size, and a top margin for proper placement.

For footers, apply similar settings through the `TextFooter` properties. Here, you can incorporate elements like divider lines, select fonts, and dynamically display the date, time, and pagination details. Ensure footers are adequately spaced by setting a bottom margin.

These steps put headers and footers on every page of the document.

[Discover How to Add Headers and Footers with IronPDF](https://ironpdf.com/how-to/headers-and-footers/)