using IronPdf;
namespace IronPdf.Examples.HowTo.Logins
{
    public static class Section3
    {
        public static void Run()
        {
            public static string RenderPartialViewToString(this Controller controller, string viewPath, object model = null)
            {
                try
                {
                    var context = controller.ControllerContext;
            
                    controller.ViewData.Model = model;
            
                    using (var sw = new StringWriter())
                    {
                        var viewResult = ViewEngines.Engines.FindPartialView(context, viewPath);
            
                        if (viewResult.View == null)
                        {
                            throw new Exception($"Partial view {viewPath} could not be found.");
                        }
            
                        var viewContext = new ViewContext(context, viewResult.View, context.Controller.ViewData, context.Controller.TempData, sw);
            
                        viewResult.View.Render(viewContext, sw);
                        viewResult.ViewEngine.ReleaseView(context, viewResult.View);
            
                        return sw.GetStringBuilder().ToString();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}