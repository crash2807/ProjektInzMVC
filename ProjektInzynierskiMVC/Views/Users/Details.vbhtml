@ModelType ProjektInzynierskiMVC.User
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdUser }) |
    @Html.ActionLink("Back to List", "Index")
</p>
