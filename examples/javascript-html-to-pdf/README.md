***Based on <https://ironpdf.com/examples/javascript-html-to-pdf/>***

IronPDF provides a feature that seamlessly incorporates images into PDFs by embedding them within HTML strings, eliminating the need for external assets.

The types of assets that can be embedded include:

- Image Files
- `System.Drawing.Image`
- `System.Drawing.Bitmap`

This capability is particularly beneficial during the [HTML to PDF conversion process with IronPDF](https://ironpdf.com/tutorials/html-to-pdf/). By embedding images directly, you enhance the rendering speed and reduce load times. Furthermore, this approach supports storing the rendered output in alternative formats such as strings or databases, instead of relying on traditional file-system storage.

Here, we'll demonstrate how you can embed images directly into your PDFs.

A key recommendation for handling HTML strings and documents is to avoid relying on external asset directories. Instead, using DataURIs enables the direct embedding of images, files, and even fonts into an HTML document as a string. This technique proves highly effective for integrating and managing files and images within your PDF documents.