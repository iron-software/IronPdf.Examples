***Based on <https://ironpdf.com/examples/docx-to-pdf/>***

The example provided describes a detailed method for transforming documents from DOCX to PDF format.

To begin the process of converting a Microsoft Word document to a PDF, you must first instantiate the **DocxToPdfRenderer** class. This class provides access to a variety of features for converting DOCX to PDF. By executing the `RenderDocxAsPdf` method with the file path of the source DOCX document, you will obtain the converted document in the form of a **PdfDocument** object.

Once the PDF has been created, you can perform additional manipulations based on your requirements. This could involve converting the PDF to standards such as [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/), adding a [digital certificate](https://ironpdf.com/how-to/signing/) to increase security, and many other enhancements.

This capability allows not only the conversion of DOCX files into PDF but also the modification and customization of the resulting PDF, tailoring it to fit particular needs.