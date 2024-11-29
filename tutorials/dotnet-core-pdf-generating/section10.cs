using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section10
    {
        public void Run()
        {
            public static class ControllerExtensions
            {
                public static async Task<string> RenderViewAsync<TModel>(this Controller controller, string viewName, TModel model, bool partial = false)
                {
                    if (string.IsNullOrEmpty(viewName))
                    {
                        viewName = controller.ControllerContext.ActionDescriptor.ActionName;
                    }
                    controller.ViewData.Model = model;
                    using (var writer = new StringWriter())
                    {
                        IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                        ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, !partial);
                        if (viewResult.Success == false)
                        {
                            return $"A view with the name {viewName} could not be found";
                        }
                        ViewContext viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, writer, new HtmlHelperOptions());
                        await viewResult.View.RenderAsync(viewContext);
                        return writer.GetStringBuilder().ToString();
                    }
                }
            }
        }
    }
}