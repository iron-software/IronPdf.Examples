***Based on <https://ironpdf.com/examples/javascript-html-to-pdf/>***

IronPDF enables the direct embedding of images into PDF documents by incorporating them into HTML strings instead of using external resources.

Included assets may comprise:

- Image Files
- `System.Drawing.Image`
- `System.Drawing.Bitmap`

This approach is advantageous as it eliminates the need to load external resources during the [HTML to PDF conversion process with IronPDF](https://ironpdf.com/tutorials/html-to-pdf/). This not only enhances the conversion speed but also reduces loading durations. Additionally, it facilitates the storage of the entire rendering file in alternative locations like strings or databases, bypassing traditional file systems.

Here, we demonstrate how to seamlessly integrate images into your PDFs.

A recommended practice in handling HTML strings and documents is to avoid reliance on a physical directory of assets. By employing DataURIs, it’s possible to directly insert images, files, and even fonts into an HTML document as strings. This technique proves extremely valuable in managing files and images within your PDF projects.