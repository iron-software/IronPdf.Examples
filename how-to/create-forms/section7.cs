using IronPdf;
using IronSoftware.Forms;

// Instantiate ChromePdfRenderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");

// Configure required parameters
string name = "choice";
string value = "yes";
int pageIndex = 0;
double x = 100;
double y = 700;
double width = 15;
double height = 15;

// Create the first radio form
var yesRadioform = new RadioFormField(name, value, pageIndex, x, y, width, height);

value = "no";
x = 200;

// Create the second radio form
var noRadioform = new RadioFormField(name, value, pageIndex, x, y, width, height);

pdf.Form.Add(yesRadioform);
pdf.Form.Add(noRadioform);

pdf.SaveAs("addRadioForm.pdf");