***Based on <https://ironpdf.com/examples/page-numbers-and-page-breaks/>***

IronPDF offers unparalleled flexibility when it comes to customizing and adding headers and footers according to a developer's specific requirements and functionality. This capability enables the inclusion of detailed information such as page numbers within the headers or footers.

In the following demonstration, we will guide you through the process of managing page numbers and introducing page breaks using IronPDF.

IronPDF supports two types of header and footer configurations: `HtmlHeaderFooter` and `TextHeaderFooter`. Managing these configurations is straightforward.

The `TextHeaderFooter` class is designed to set up header and footer configurations for PDFs using a straightforward method, accommodating most typical scenarios. This allows developers to position page numbers on the right, center, or left of the header or footer. Additionally, it's possible to modify the font style and size to maintain consistency with the main content of your PDF.

To insert a page break when converting HTML to PDF in .NET, you can utilize the following HTML markup:

```txt
<div style="page-break-after:always;"></div>
```

For a comprehensive guide on effectively utilizing these features, please visit the [IronPDF Documentation for Headers and Footers](https://www.ironpdf.com/docs) available on the official website.