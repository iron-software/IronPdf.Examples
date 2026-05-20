# Utilizing UTF-8 Encoding and International Languages in PDF Documents

***Based on <https://ironpdf.com/how-to/utf-8/>***


IronPDF seamlessly supports UTF-8 encoding in PDF documents, adhering to the Chrome standard. This means that any character that renders correctly within a Chrome browser is also supported by IronPDF, ensuring accurate representations of foreign languages in your PDFs. In the following guide, we will showcase the steps to enable UTF-8 encoding in your PDFs using IronPDF.

## Quickstart: Create PDFs with UTF-8 Encoding Using IronPDF

This quick guide illustrates how to create a PDF that includes UTF-8 encoding with IronPDF. By setting the `InputEncoding` to UTF-8 and utilizing the `RenderHtmlAsPdf` function, developers can effortlessly ensure that international characters are correctly displayed in the PDF. This method is straightforward and only requires a few lines of code, perfect for developers eager to start producing Unicode-enabled PDFs.

```cs
// Example: Instantly Creating a UTF-8 Encoded PDF
var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;
var pdf = renderer.RenderHtmlAsPdf("<html><head><meta charset='utf-8'></head><body>こんにちは世界</body></html>");
pdf.SaveAs("utf8-example.pdf");
```

## Basic Code Demonstration

When leveraging IronPDF for dealing with multi-linguistic content, UTF-8 Encoding plays a pivotal role.

Below is an example where we prepare an HTML string to feed into the `RenderHtmlAsPdf` method, demonstrating input with multiple international languages:

```csharp
string htmlContent = @"
<p>周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。<p>
<p>أم يذكر النفط قبضتهم على, الصين وفنلندا ما حدى. تم لكل أملا المنتصر, ٣٠ حدى مارد القوى.</p>
<p>ภคนทลาพาธสตารเซฟต แชมป มารเกตตงลมเหลวโยเกรต.</p>
";
```

This markdown structure is then used to generate a PDF:

```cs
using IronPdf;

string html_with_utf_8 = "{ [ HTML CONTENT FROM ABOVE ] }";
var renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;
var pdf = renderer.RenderHtmlAsPdf(html_with_utf_8);
pdf.SaveAs("Unicode.pdf");
```

This is the resultant file:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/utf-8/Unicode.pdf" width="100%" height="500px">
</iframe>

Additionally, declare the character set in both the HTML header and `ChromePdfRenderer.RenderingOptions` to guarantee accurate encoding:

```html
<html>
    <head>
        <meta charset='utf-8'>
    </head>
    <body>
        こんにちは世界
    </body>
</html>
```

## Detailed Insights on International Languages

IronPDF excels in converting HTML to PDF for documents in non-Latin scripts like Chinese, Japanese, Arabic, and others, supporting all Unicode-inclusive international languages even in mixed-language documents.

### Considerations for International Text

#### Typefaces
Ensure your server has typefaces that support your specific characters. Modern servers typically have these, but older ones might require updates or using web fonts like Google Fonts. For further reading, see [How to Use Google Fonts in Your Web Projects](https://medium.freecodecamp.org/how-to-use-google-fonts-in-your-next-web-design-project-e1ad48f1adfa).

#### Input Encoding

Properly set the input encoding of your document to ensure correct rendering. This can be specified using:

```html
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>
```

Explore more techniques at: [Additional IronPDF Features](https://ironpdf.com/tutorials/pdf-assets-and-performance-csharp/)