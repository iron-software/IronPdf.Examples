using IronPdf;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdf.Print();
