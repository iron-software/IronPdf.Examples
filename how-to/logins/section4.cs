using IronPdf;
namespace IronPdf.Examples.HowTo.Logins
{
    public static class Section4
    {
        public static void Run()
        {
            // This snippet is a member of a larger component from the accompanying README, not a standalone program.
            // Kept verbatim; see README.md for the full context.
            // // Converts an MVC partial view to a string
            // public static string RenderPartialViewToString(this Controller controller, string viewPath, object model = null)
            // {
            // try
            // {
            // // Set the model
            // var context = controller.ControllerContext;
            // controller.ViewData.Model = model;
            //
            // using (var sw = new StringWriter())
            // {
            // // Find the partial view
            // var viewResult = ViewEngines.Engines.FindPartialView(context, viewPath);
            //
            // if (viewResult.View == null)
            // {
            // throw new Exception($"Partial view {viewPath} could not be found.");
            // }
            //
            // // Create a view context
            // var viewContext = new ViewContext(context, viewResult.View, context.Controller.ViewData, context.Controller.TempData, sw);
            //
            // // Render the view
            // viewResult.View.Render(viewContext, sw);
            // viewResult.ViewEngine.ReleaseView(context, viewResult.View);
            //
            // return sw.GetStringBuilder().ToString();
            // }
            // }
            // catch (Exception ex)
            // {
            // // Return error message if there is an exception
            // return ex.Message;
            // }
            // }
        }
    }
}