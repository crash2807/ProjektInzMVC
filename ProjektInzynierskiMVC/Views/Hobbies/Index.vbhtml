﻿@ModelType IEnumerable(Of ProjektInzynierskiMVC.Hobby)
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
            @Html.DisplayNameFor(Function(model) model.HobbyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.HobbyName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdHobby }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdHobby }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdHobby })
        </td>
    </tr>
Next

</table>