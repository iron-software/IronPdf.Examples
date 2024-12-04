@using IronPdf;

public void ExportData()
{
    try
    {
        string fileName = "Demo.pdf";
        var Renderer = new IronPdf.ChromePdfRenderer();
        var pdf = Renderer.RenderUrlAsPdf("https://localhost:7018/fetchdata");
        JSRuntime.InvokeVoidAsync("saveAsFile", fileName, Convert.ToBase64String(pdf.Stream.ToArray()));
    }
    catch (Exception ex)
    {
    }
}
