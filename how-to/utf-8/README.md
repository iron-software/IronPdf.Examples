# Using UTF-8 Encoding and International Languages in PDFs with IronPDF

IronPDF effectively supports UTF-8 encoding in PDF documents. This is based on the compatibility with the Chrome browser's rendering capabilities, ensuring virtually any character displayed in Chrome can also be rendered in IronPDF. This guide will walk you through the process of using UTF-8 encoding to produce PDFs with IronPDF, ensuring characters from various international languages are accurately presented.

---

---

## Step-by-Step Code Example

IronPDF frequently handles documents using extended character sets, including UTF-8 encoding.

Below is a code snippet where a string containing characters from multiple languages is converted into a PDF using the `RenderHtmlAsPdf` method. This method accepts an HTML string:

```text
周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。更火識将回興継時億断保媛全職。
文造画念響竹都務済約記求生街東。天体無適立年保輪動元念足総地作靖権瀬内。
失文意芸野画美暮実刊切心。感変動技実視高療試意写表重車棟性作家薄井。
陸瓶右覧撃稿法真勤振局夘決。任堀記文市物第前兜純響限。囲石整成先尾未展退幹販山令手北結。

أم يذكر النفط قبضتهم على, الصين وفنلندا ما حدى. تم لكل أملاً المنتصر,
٣٠ حدى مارد القوى. شرسة للسيطرة قامفي. حتى أم يطول المحيط,
زهاء وحلفاؤها من فعل. لم قامت الجو الساحلية وتم, ويعزى واقتصار قبل كل.

ภคันทลาพาธสตาร์เซฟตี้ แชมป์ มาร์เก็ตติ้งล้มเหลวโยเกิร์ต แลนด์บาบูนอึมครึม รุสโซ แบรนด์ไคลแม็กซ์ พิซซ่าโมเดลเสือโคร่ง ม็อบโซนรายชื่อ
แอดมิชชั่น ด็อกเตอร์ พะเรอ มาร์คเจไดโมจิราสเบอร์รี เอนทรานซ์ออดิชั่นศิลปวัฒนธรรมเปราะบาง โมจิซีเรียสวอลนัตทริปลีเมอร์ ทิป วาไรตี้บิ๊กเมเปิ...
```

This string will be wrapped in `<p>` tags to fit the HTML format required by the IronPDF's Chrome PDF Renderer:

```cs
using IronPdf;

const string html_with_utf_8 =
    @"<p>周態告応立待太記行神正用真最。音日独素円政進任見引際初携食。更火識将回興継時億断保媛全職...
    </p>";
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.InputEncoding = System.Text.Encoding.UTF8;

var pdf = renderer.RenderHtmlAsPdf(html_with_utf_8);
pdf.SaveAs("Unicode.pdf");
```

The result is encapsulated in the following embedded PDF:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/utf-8/Unicode.pdf" width="100%" height="500px">
</iframe>

To achieve flawless encoding, two adjustments are crucial:

- Setting the `InputEncoding` property in the `ChromePdfRenderer.RenderingOptions` to `System.Text.Encoding.UTF8`.
- Including a charset specification in your HTML's head:

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

## Insights into International Languages Support

IronPDF excels in converting HTML to PDF for documents written in non-Latin scripts, including but not limited to Chinese, Japanese, Arabic, and Russian. When working with these scripts, you should consider two main aspects:

### Typefaces
Ensure your server has typefaces that support your language's character set. Most modern servers will have these by default. Alternatively, you can use web fonts from services like Google Fonts. Further details are available [here](https://medium.freecodecamp.org/how-to-use-google-fonts-in-your-next-web-design-project-e1ad48f1adfa).

### Input Encoding
Proper input encoding must be specified to accurately render characters. This can be achieved using a HTML "Meta Charset" Tag:

```html
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8"/>
```