Headers and footers in HTML are treated as separate HTML documents that can include their own resources and styles. This allows developers to have full control over the appearance of their document headers and footers. Additionally, the height of these headers and footers can be precisely adjusted to align perfectly with their content.

In this guide, we demonstrate the addition of HTML headers and footers using IronPDF.

Once introduced to your project, HTML headers and footers will appear on every page of the generated PDF document. This feature can be utilized to replace [traditional headers and footers](https://ironpdf.com/examples/headers-and-footers/).

It's crucial to use the `HtmlHeaderFooter` class and assign the `HtmlFragment` property. This should contain an HTML fragment, not a full HTML page, and can include style elements and images.

Moreover, you can incorporate dynamic content into your HTML through placeholders like `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, and `{pdf-title}` to merge metadata seamlessly.