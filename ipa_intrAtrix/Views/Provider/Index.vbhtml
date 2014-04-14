@ModelType IEnumerable(Of ipa_intrAtrix.Models.Contracts.Providers)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ProviderId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Company)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LockBox)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CustomerRef)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Phone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Weblink)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.ProviderId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Company)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LockBox)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CustomerRef)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Phone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Weblink)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.ProviderId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.ProviderId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.ProviderId})
        </td>
    </tr>
Next

</table>
