IronPDF provides the functionality to seamlessly integrate images into PDFs by embedding them directly within HTML strings, as opposed to relying on external sources.

Assets that can be embedded include:

- Image Files
- `System.Drawing.Image`
- `System.Drawing.Bitmap`

This capability is beneficial as it eliminates the need to fetch external assets during the [HTML to PDF](https://ironpdf.com/tutorials/html-to-pdf/) conversion process. This enhancement not only accelerates the rendering speed but also reduces loading times. Additionally, it facilitates storing the complete render file in unconventional storage mediums like strings or databases.

In the forthcoming example, we will demonstrate how to embed images directly into your PDFs using IronPDF.

Adopting best practices for working with HTML strings and documents includes avoiding reliance on a directory of assets. Utilizing DataURIs allows for the direct insertion of images, files, and even typefaces right into an HTML document represented as a string. This technique proves to be incredibly effective for managing files and images within your PDF documents.