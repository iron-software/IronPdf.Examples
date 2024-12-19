# Utilizing UTF-8 Encoding for International Languages in PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/utf-8/>***


IronPDF adeptly manages UTF-8 encoding, aligning with the Chrome standard. This ensures that any character that Chrome can display will be effectively supported, guaranteeing accurate rendering of international characters when creating PDFs. Below, we will guide you through the process of utilizing UTF-8 encoding in your PDFs using IronPDF.

### Starting with IronPDF

---

---

---

## A Basic Coding Example

In scenarios involving IronPDF, it's common to work with extended character sets like UTF-8. Consider the following instance where a multi-language string is directed to the `RenderHtmlAsPdf` method, expecting an HTML string:

```text
周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。更火識将回興継時億断保媛全職。
文造画念響竹都務済約記求生街東。天体無適立年保輪動元念足総地作靖権瀬内。
失文意芸野画美暮実刊切心。感変動技実視高療試意写表重車棟性作家薄井。
陸瓶右覧撃稿法真勤振局夘決。任堀記文市物第前兜純響限。囲石整成先尾未展退幹販山令手北結。

أم يذكر النفط قبضتهم على, الصين وفنلندا ما حدى. تم لكل أملاً المنتصر,
٣٠ حدى مارد القوى. شرسة للسيطرة قامفي. حتى أم يطول المحيط,
زهاء وحلفاؤها من فعل. لم قامت الجو الساحلية وتم, ويعزى واقتصار قبل كل.

ภคันทลาพาธสตาร์เซฟตี้ แชมป์ มาร์เก็ตติ้งล้มเหลวโยเกิร์ต แลนด์บาบูนอึมครึม รุสโซ แบรนด์ไคลแม็กซ์ พิซซ่าโมเดลเสือโคร่ง ม็อบโซนรายชื่อ
แอดมิชชั่น ด็อกเตอร์ พะเรอ มาร์คเจไดโมจิราสเบอร์รี เอนทรานซ์ออดิชั่นศิลปวัฒนธรรมเปราะบาง โมจิซีเ...
```
Next, we enclose our text within `<p>` tags as part of an HTML structure and feed the resulting HTML to IronPDF's rendering engine:

```cs
using IronPdf;

const string html_with_utf_8 = 
    @"<p>周態告応立待太記行神正用真最。音日独素円政進任見引際初携食...أم يذكر النفط ق...แชมป์ มาร...
    </p>";

var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;

var pdf = renderer.RenderHtmlAsPdf(html_with_utf_8);
pdf.SaveAs("Unicode.pdf");
```

This code snippet creates the file displayed here:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/utf-8/Unicode.pdf" width="100%" height="500px">
</iframe>

To ensure flawless encoding of your HTML into a PDF, IronPDF allows you to specify your charset preference in two key locations:

- Within `ChromePdfRenderer.RenderingOptions` using `System.Text.Encoding.UTF8`
- Within the HTML Header:

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

## Understanding International Languages Support

IronPDF excels at converting HTML-to-PDF for scripts beyond the Latin alphabet, supporting a myriad of languages like Chinese, Japanese, Arabic, and more, embracing all characters defined in Unicode, including documents combining multiple languages.

### Considerations for International Language Support

#### Typefaces
Ensure that your server has typefaces that support your specific character set. Modern servers generally have updated fonts, but older installations might require updates or alternative setups, such as using Web Fonts provided by Google Fonts. Learn more in [Utilizing Google Fonts in Web Projects](https://medium.freecodecamp.org/how-to-use-google-fonts-in-your-next-web-design-project-e1ad48f1adfa).

#### Input Encoding
Additionally, you might need to define your document's input encoding properly to render accurately, by including in your HTML document a "Meta Charset" Tag:

```html
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>
```