> Full guide: [Parallel](https://ironpdf.com/examples/parallel/)

IronPDF generates PDFs concurrently, so a `Parallel.ForEach` loop can render several documents at once.

## Steps for Concurrent PDF Generation

Here is how to use `Parallel.ForEach` for simultaneous PDF creation:

### Overview

1. **ChromePdfRenderer**: Begin by creating an instance of `ChromePdfRenderer`. It renders HTML strings into PDF files through the Chromium engine.

2. **HTML Strings List**: Prepare a collection of HTML strings. In this example, we have three HTML segments that will be rendered into individual PDF files.

3. **Parallel Processing**: Utilize `Parallel.ForEach` for simultaneous processing of these HTML strings. This method allows for the concurrent generation of several PDF files, drastically boosting efficiency when producing a large volume of documents.

4. **Rendering and Saving PDFs**: In the `Parallel.ForEach` loop, employ the `RenderHtmlAsPdf` function for each HTML string. This function transforms each HTML string into a corresponding PDF. These PDFs can be saved or further modified using various features provided by IronPDF.

For additional insights and code examples, consider visiting the IronPDF [How-to Guide](https://ironpdf.com/how-to/async/).

<a href="https://ironpdf.com/how-to/async" class="code_content__related-link__doc-cta-link">Discover More about Asynchronous PDF Generation with IronPDF</a>