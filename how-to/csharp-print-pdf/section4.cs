using IronPdf;
using System.Threading.Tasks;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

await pdf.PrintToFile("PathToFile", false);