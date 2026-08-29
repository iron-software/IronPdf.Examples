using IronPdf;
namespace IronPdf.Examples.HowTo.CreateForms
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { CreatePdfFormsFromHtml = true } }
                .RenderHtmlAsPdf("<html><body><form>First name: <input type='text' name='firstname' value=''>Last name: <input type='text' name='lastname' value=''></form></body></html>")
                .SaveAs("editableForm.pdf");
        }
    }
}