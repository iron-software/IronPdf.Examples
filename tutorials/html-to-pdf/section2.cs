using IronPdf;

// this will render C:\MyProject\Assets\image1.png
var pdf = renderer.RenderHtmlAsPdf("<img src='image1.png'/>", @"C:\MyProject\Assets\");