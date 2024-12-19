using IronPdf;
namespace IronPdf.Examples.HowTo.RazorViewToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}