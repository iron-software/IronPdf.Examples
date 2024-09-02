IronPDF stands out for its robust capability to customize headers and footers according to developer preferences, enhancing functionality significantly. This feature importantly supports the addition of page numbers within the header or footer.

In this tutorial, I'll demonstrate methods for managing page numbers and implementing page breaks using IronPDF.

IronPDF facilitates this with two main options: `HtmlHeaderFooter` and `TextHeaderFooter`, both of which are straightforward to utilize.

Using the `TextHeaderFooter` class, developers can effortlessly format headers and footers in PDFs. This class allows for the placement of page numbers in the left, center, or right of the header or footer. Additionally, you can fine-tune the font type and size, ensuring it aligns well with your document’s main text.

For inserting a page break when converting HTML to PDF in .NET environments, apply the following HTML tag:

```txt
<div style="page-break-after:always;"></div>
```