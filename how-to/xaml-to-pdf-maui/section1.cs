using IronPdf;
namespace IronPdf.Examples.HowTo.XamlToPdfMaui
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Render your MAUI XAML page to PDF in one line!
            var pdf = new IronPdf.ChromePdfRenderer().RenderContentPageToPdf<MainPage,App>().SaveAs("page.pdf");
        }
    }
}