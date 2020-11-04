@ModelType IEnumerable(Of ProjektInzynierskiMVC.User)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Surname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Birthday)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Avatar)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Surname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Birthday)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Avatar)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdUser }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdUser }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdUser })
        </td>
    </tr>
Next

</table>
