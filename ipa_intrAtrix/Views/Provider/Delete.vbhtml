@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
