# Managing UTF-8 Encoding and Global Languages in PDF Creation with IronPDF

***Based on <https://ironpdf.com/how-to/utf-8/>***


IronPDF fully supports UTF-8 encoding in PDF generation, adhering to the Chrome standard. This means any character that can be displayed in a Chrome browser is also supported in IronPDF. This ensures accurate rendering of global languages in your PDF documents. Below, we'll explore how to implement UTF-8 encoding in your PDF projects using IronPDF.

***

## Overview with Code Examples

When utilizing IronPDF for creating PDF files, we often deal with various character sets, particularly UTF-8. Here’s a look at how to handle HTML strings with diverse global characters, hence ensuring their correct representation in the final PDF.

Below is an illustration where a multiline string filled with international characters is passed to the `RenderHtmlAsPdf` function, which expects an HTML string:

```text
周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。更火識将回興継時億断保媛全職。
文造画念響竹都務済約記求生街東。天体無適立年保輪動元念足総地作靖権瀬内。
失文意芸野画美暮実刊切心。感変動技実視高療試意写表重車棟性作家薄井。
陸瓶右覧撃稿法真勤振局夘決。任堀記文市物第前兜純響限。囲石整成先尾未展退幹販山令手北結。

أم يذكر النفط قبضتهم على, الصين وفنلندا ما حدى. تم لكل أملاً المنتصر,
٣٠ حدى مارد القوى. شرسة للسيطرة قامفي. حتى أم يطول المحيط,
زهاء وحلفاؤها من فعل. لم قامت الجو الساحلية وتم, ويعزى واقتصار قبل كل.

ภคันทลาพาธสตาร์เซฟตี้ แชมป์ มาร์เก็ตติ้งล้มเหลวโยเกิร์ต แลนด์บาบูนอึมครึม รุสโซ แบรนด์ไคลแม็กซ์ พิซซ่าโมเดลเสือโคร่ง ม็อบโซนรายชื่อ
แอดมิ...
```
To accommodate HTML formatting, each string is encapsulated within `<p>` tags. The processed HTML string is then converted into a PDF via IronPDF's Chrome-based renderer:

```cs
using IronPdf;

namespace ironpdf.Utf8
{
    public class Section1
    {
        public void Run()
        {
            const string html_with_utf_8 =
                @"<p>周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。更火識将回興継時億断保媛全職。
                文造画念響竹都務済約記求生街東。天体無適立年保輪動元念足総地作靖権瀬内...
                </p>";
            
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;
            
            var pdf = renderer.RenderHtmlAsPdf(html_with_utf_8);
            pdf.SaveAs("Unicode.pdf");
        }
    }
}
```

This final PDF can be viewed using the following embedded display:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/utf-8/Unicode.pdf" width="100%" height="500px">
</iframe>

To guarantee precise encoding from your HTML to PDF:

1. Define the charset in the `ChromePdfRenderer.RenderingOptions` using `System.Text.Encoding.UTF8`.
2. Incorporate a charset specification in your HTML header:

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

## Additional Considerations for International Language Support

IronPDF is designed to handle HTML-to-PDF conversions in various scripts, such as Chinese, Japanese, Arabic, and more. Here are additional points to consider:

### Typefaces
Ensure the fonts supporting your chosen scripts are installed on your server. If not, you can use web fonts like Google Fonts. For more details on using Google fonts in your project, refer to [How to Use Google Fonts in Your Next Web Design Project](https://medium.freecodecamp.org/how-to-use-google-fonts-in-your-next-web-design-project-e1ad48f1adfa).

### Input Encoding
It's crucial to specify the correct input encoding for your HTML to render properly. Add a charset specification using the HTML meta tag like so:

```html
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>
```