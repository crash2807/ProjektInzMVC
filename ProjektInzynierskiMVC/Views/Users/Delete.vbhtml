@ModelType ProjektInzynierskiMVC.User
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Surname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Surname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Password)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Birthday)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Birthday)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Avatar)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Avatar)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
