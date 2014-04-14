@ModelType IEnumerable(Of ipa_intrAtrix.Models.Contracts.CustomerNetwork)

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
            @Html.DisplayNameFor(Function(model) model.CustId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SpiderId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.InternalDescr)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Schema)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Starting)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Shutdown)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WarantyExp)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CustId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.SpiderId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.InternalDescr)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Schema)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Starting)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Shutdown)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.WarantyExp)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.CustId}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.CustId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.CustId})
        </td>
    </tr>
Next

</table>
