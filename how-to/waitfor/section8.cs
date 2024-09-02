using IronPdf;

string htmlContent = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <title>Test Registration of Extension</title>
  <script type=""text/javascript"">
	setTimeout(function() {
		var img = document.createElement(""img"");
		img.onload = function() {
			img.setAttribute(""id"", ""myid"");
			img.setAttribute(""class"", ""blablastyle"");
			var block = document.getElementById(""x"");
			block.appendChild(img);
		};
		img.src = ""https://www.w3schools.com/images/picture.jpg"";	// .src after .onload to ignore cached, if any
	}, 1000);
  </script>
</head>
<body>
	<h1>This is Delayed Render Test!</h1>
    <div id=""x""></div>
</body>
</html>";

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.WaitFor.HtmlQuerySelector("img#myid.blablastyle", 5000);

PdfDocument pdf = renderer.RenderHtmlAsPdf(htmlContent);