using IronPdf;

private void Form1_Load(object sender, EventArgs e)
{
    //Changes the ASPX output into a pdf instead of HTML
    IronPdf.AspxToPdf.RenderThisPageAsPdf();
}
