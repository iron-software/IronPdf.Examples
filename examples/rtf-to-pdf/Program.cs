using IronPdf;

const string exampleRtfString = @"
    {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fnil\fcharset2 Symbol;}}
    {\*\generator Riched20 10.0.15063}\viewkind4\uc1
    \pard\sa200\sl276\slmult1\f0\fs22\lang9 Paragraph\par

    \pard{\pntext\f1\'B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-360\li720\sa200\sl276\slmult1 Bullet\par
    {\pntext\f1\'B7\tab}Bullet 2\par

    \pard\sa200\sl276\slmult1 Paragraph 2\par

    \pard
    {\pntext\f0 1.\tab}{\*\pn\pnlvlbody\pnf0\pnindent0\pnstart1\pndec{\pntxta.}}
    \fi-360\li720\sa200\sl276\slmult1 List 1\par
    {\pntext\f0 2.\tab}List 2\par
    }
    ";

// Instantiate Renderer
var renderer = new ChromePdfRenderer();

// Load the RTF as File or String
PdfDocument pdfFromFile = renderer.RenderRtfFileAsPdf("report.rtf");
PdfDocument pdfFromString = renderer.RenderRtfStringAsPdf(exampleRtfString);

pdfFromFile.SaveAs("report.pdf");
pdfFromString.SaveAs("string.pdf");
