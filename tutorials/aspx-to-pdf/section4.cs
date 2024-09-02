using IronSoftware.Drawing;
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
                TextHeader = new IronPdf.TextHeaderFooter()
                {
                    CenterText = "Invoice",
                    DrawDividerLine = false,
                    Font = FontTypes.Arial,
                    FontSize = 12
                },
                TextFooter = new IronPdf.TextHeaderFooter()
                {
                    LeftText = "{date} - {time}",
                    RightText = "Page {page} of {total-pages}",
                    Font = IronSoftware.Drawing.FontTypes.Arial,
                    FontSize = 12,
                },
            };
            IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Invoice.pdf", AspxToPdfOptions);
        }
    }
}