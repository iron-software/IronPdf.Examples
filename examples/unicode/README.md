***Based on <https://ironpdf.com/examples/unicode/>***

IronPDF seamlessly integrates Unicode support to enable the rendering of various global languages in PDF files, along with UTF-8 encoding to facilitate the display of modern alphabetic languages. It's important to note that your system must have Unicode fonts installed for this feature to function properly. While Windows and Mac systems generally come with these fonts pre-installed, Linux users might need to install these fonts manually.

This functionality is particularly beneficial for incorporating languages such as:

- Hindi
- Chinese (including various dialects)
- Arabic
- Japanese
- Thai

### Step-by-Step Guide to Using IronPDF's Unicode and UTF-8 Features for PDFs

The initial step in leveraging IronPDF’s UTF-8 and Unicode support is to craft a new HTML string in your preferred language. This is the first building block in creating a PDF document that will accurately display the characters you intend to use. Subsequently, create a `ChromePdfRenderer` object which allows access to IronPDF’s robust rendering capabilities, essential for converting HTML to PDF efficiently.

Following this setup, employ the `RenderHtmlAsPdf` method to transform your HTML string into a PDF. This PDF is then stored in a `PdfDocument` object, ready for further manipulation. The final step involves saving this freshly created PDF to a desired directory using the `SaveAs` method.

IronPDF’s handling of UTF-8 encoding and Unicode simplifies the task of incorporating several languages within a single PDF document. Incorporating a line like `<meta charset="UTF-8">` in your HTML ensures smooth rendering of various languages, whether from files or URLs.

[Explore IronPDF's UTF-8 Guide for Multilingual PDFs](https://ironpdf.com/how-to/utf-8/).