***Based on <https://ironpdf.com/examples/page-numbers-and-page-breaks/>***

IronPDF provides unparalleled flexibility for customizing and implementing headers and footers according to developer preferences and needs. This capability facilitates the integration of additional page numbering information within headers or footers.

Here, we'll demonstrate the management of page numbers and page breaks using IronPDF.

The functionality spans across the two main header and footer options—`HtmlHeaderFooter` and `TextHeaderFooter`. Utilizing these options is straightforward.

`TextHeaderFooter` is a class that lays out the PDF header and footer settings, adopting a straightforward methodology in the rendering process for typical scenarios. It allows you to position page numbers at the right, center, or left of the header or footer and modify the font type and size for uniformity with your document's main text.

To force a page break in an HTML to PDF conversion in .NET, employ the following HTML code:

```txt
<div style="page-break-after:always;"></div>
```

For further insights on leveraging these features proficiently, consult the [IronPDF Documentation for Headers and Footers](https://ironpdf.com/docs) on the official website.