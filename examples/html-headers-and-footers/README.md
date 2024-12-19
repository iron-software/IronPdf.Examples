***Based on <https://ironpdf.com/examples/html-headers-and-footers/>***

HTML headers and footers are treated as separate HTML entities that can incorporate their own assets and stylesheets, allowing developers comprehensive control over their appearance. The dimension of these headers or footers can be meticulously adjusted to align perfectly with their actual content.

In the following demonstration, we illustrate the process of integrating HTML headers and footers into PDF documents using IronPDF.

Once you incorporate HTML headers or footers into your project, they will consistently appear on every page of the PDF. This feature can effectively replace the standard headers and footers, as seen in the [IronPDF classic headers and footers examples](https://ironpdf.com/examples/headers-and-footers/).

It is essential to utilize the `HtmlHeaderFooter` correctly by setting the `HtmlFragment`. This fragment, ideally an HTML snippet, should be compiled, including necessary styles and images without forming a complete document.

Furthermore, you can enrich your HTML with meta data by utilizing placeholders such as `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, `{pdf-title}`. These can be dynamically inserted to tailor document metadata directly within your HTML structure.