using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspxToPdfTutorial
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var AspxToPdfOptions = new IronPdf.ChromePdfRenderOptions()
            {
                MarginTop = 50, // make sufficiant space for an HTML header
                HtmlHeader = new IronPdf.HtmlHeaderFooter()
                {
                    HtmlFragment = "<div style='text-align:right'><em style='color:pink'>page {page} of {total-pages}</em></div>"
                }
            };
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "MyDocument.pdf", AspxToPdfOptions);
        }
    }
}