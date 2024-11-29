using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section5
    {
        public void Run()
        {
            @model IronPdfMVCHelloWorld.Models.ClientModel
            @{
              ViewBag.Title = "Book Ticket";
            }
            <h2>Index</h2>
            @using (Html.BeginForm())
            {
              <div class="form-horizontal">
                @Html.ValidationSummary(true, "", new { @class = "text-danger" })
                <div class="form-group">
                  @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" })
                  <div class="col-md-10">
                    @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" })
                  </div>
                </div>
                <div class="form-group">
                  @Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" })
                  <div class="col-md-10">
                    @Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" })
                  </div>
                </div>
                <div class="form-group">
                  @Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" })
                  <div class="col-md-10">
                    @Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" })
                  </div>
                </div>
                <div class="form-group">
                  <div class="col-md-10 pull-right">
                    <button type="submit" value="Save" class="btn btn-sm">
                      <i class="fa fa-plus"></i>
                      <span>
                        Save
                      </span>
                    </button>
                  </div>
                </div>
              </div>
            }
        }
    }
}