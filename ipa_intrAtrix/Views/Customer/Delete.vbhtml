@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3></h3>
<fieldset>
    <legend>Kundenentzwerk</legend>

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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
