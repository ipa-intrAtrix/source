@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>CustomerNetwork</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CustId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CustId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.SpiderId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.SpiderId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.InternalDescr)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.InternalDescr)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Schema)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Schema)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Starting)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Starting)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Shutdown)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Shutdown)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.WarantyExp)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.WarantyExp)
    </div>
</fieldset>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.CustId}) 
    @Html.ActionLink("Back to List", "Index")
</p>
