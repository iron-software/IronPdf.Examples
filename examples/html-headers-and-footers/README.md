***Based on <https://ironpdf.com/examples/html-headers-and-footers/>***

HTML headers and footers are rendered as separate HTML documents, allowing them to include unique assets and stylesheets. This flexibility grants developers complete control over the appearance of their headers and footers. Additionally, the heights of these headers and footers can be precisely tailored to fit their content.

This example demonstrates how to integrate HTML headers and footers into your PDF documents using IronPDF.

Once you incorporate HTML headers or footers into your project, they will appear on every page of the PDF. This feature can be utilized to replace the [traditional IronPDF headers and footers](https://ironpdf.com/examples/headers-and-footers/).

When employing the `HtmlHeaderFooter` feature, it's crucial to set the `HtmlFragment`. This should be a snippet of HTML, not an entire document, and may include styles and images.

Additionally, you can embed metadata into your HTML headers and footers using placeholders such as `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, and `{pdf-title}`.