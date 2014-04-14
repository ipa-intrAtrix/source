@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Providers</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.ProviderId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.ProviderId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Company)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Company)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LockBox)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LockBox)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CustomerRef)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CustomerRef)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Phone)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Phone)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Email)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Email)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Weblink)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Weblink)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
