using IronPdf;

const string html = @"
  <table style='border: 1px solid #000000'>
    <tr>
      <th>Company</th>
      <th>Product</th>
    </tr>
    <tr>
      <td>Iron Software</td>
      <td>IronPDF</td>
    </tr>
    <tr>
      <td>Iron Software</td>
      <td>IronOCR</td>
    </tr>
  </table>

  <div style='page-break-after: always;'> </div>

  <img src='https://ironpdf.com/img/products/ironpdf-logo-text-dotnet.svg'>";

var renderer = new ChromePdfRenderer();

var pdf = renderer.RenderHtmlAsPdf(html);
pdf.SaveAs("Page_Break.pdf");