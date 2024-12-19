***Based on <https://ironpdf.com/examples/viewport/>***

Converting an HTML page into a PDF is typically a simple task. However, managing a responsive page involves greater complexity as it may alter over time during user interactions. IronPDF excels in rendering responsive HTML into PDF documents.

In this tutorial, we will guide you through the process of converting a responsive HTML page into a PDF file.

Utilize the `UseResponsiveCssRendering` method found in the `PaperFit` property of the `PdfRenderingOptions` class. This method allows you to set the dimensions of the virtual Chrome window that will be used to render your responsive HTML.

This feature is particularly useful for developers who need to target a specific responsive layout on a webpage that utilizes responsive CSS3, and is compatible with leading HTML5 responsive frameworks like Bootstrap.

`IronPdf.ChromePdfRenderer` converts any webpage or HTML snippet seamlessly into a PDF using a contemporary embedded Chrome browser.

As of 2021, Iron Software designates the `ChromePdfRenderer` as the optimal PDF rendering solution, replacing previous classes. It also provides features like applying cookies using specific login credentials, generating a PDF from an HTML string, and exporting it as a `PdfDocument`. This document can then be modified, stored, or hosted online. For more insights on how to leverage the ChromePdfRenderer, please visit the [IronPDF product page](https://ironpdf.com).