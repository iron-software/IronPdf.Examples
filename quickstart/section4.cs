using IronPdf;
using System;
using System.Web.UI;

namespace WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.InBrowser);
        }
    }
}