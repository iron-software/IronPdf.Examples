using IronPdf;

string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Test Registration of Extension</title>
  <!-- for google web fonts -->
  <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
  <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
  <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap"" >

  <style>
  /* for remote fonts */
  @font-face {
    font-family: 'CustomFont';
    src: url('https://stage.gradfinale.co.uk/tcpdf/fonts/avgr65wttf.ttf');
  }
  p#p1 { font-family: CustomFont, sans-serif; }

  /* for local fonts */
  @font-face {
    font-family: 'LocalCustomFont';
    src: local('Arial');
  }
  p#p3 { font-family: LocalCustomFont, sans-serif; }
  </style>
</head>
<body>
	<h1>This is Delayed Render Test!</h1>
	<p style=""font-family: Roboto, monospace;"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla scelerisque ligula venenatis erat <strong>scelerisque</strong> auctor.</p>
	<p id=""p1"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla scelerisque ligula venenatis erat <strong>scelerisque</strong> auctor.</p>
	<p id=""p3"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla scelerisque ligula venenatis erat <strong>scelerisque</strong> auctor.</p>
</body>
</html>)";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.AllFontsLoaded(10000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);