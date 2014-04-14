@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Create"
End Code

<h2>Neuen Kunden erfassen</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Kundennetzwek</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustId)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CustId)
            @Html.ValidationMessageFor(Function(model) model.CustId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.SpiderId)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.SpiderId)
            @Html.ValidationMessageFor(Function(model) model.SpiderId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.InternalDescr)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.InternalDescr)
            @Html.ValidationMessageFor(Function(model) model.InternalDescr)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Schema)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Schema)
            @Html.ValidationMessageFor(Function(model) model.Schema)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Starting)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Starting)
            @Html.ValidationMessageFor(Function(model) model.Starting)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Shutdown)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Shutdown)
            @Html.ValidationMessageFor(Function(model) model.Shutdown)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.WarantyExp)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.WarantyExp)
            @Html.ValidationMessageFor(Function(model) model.WarantyExp)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
