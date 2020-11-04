@ModelType ProjektInzynierskiMVC.Hobby
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Hobby</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.HobbyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.HobbyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdHobby }) |
    @Html.ActionLink("Back to List", "Index")
</p>
