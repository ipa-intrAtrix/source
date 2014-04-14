@ModelType ipa_intrAtrix.Models.Contracts.CustomerNetwork

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Kundennetzwerk</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustId, "Kunden ID:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CustId)
            @Html.ValidationMessageFor(Function(model) model.CustId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.SpiderId, "Spider ID:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.SpiderId)
            @Html.ValidationMessageFor(Function(model) model.SpiderId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.InternalDescr, "Interne Beschreibung:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.InternalDescr)
            @Html.ValidationMessageFor(Function(model) model.InternalDescr)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Schema, "Netzwerkschema:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Schema)
            @Html.ValidationMessageFor(Function(model) model.Schema)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Starting, "Inbetriebnahme:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Starting)
            @Html.ValidationMessageFor(Function(model) model.Starting)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Shutdown, "Ausserbetriebnahme:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Shutdown)
            @Html.ValidationMessageFor(Function(model) model.Shutdown)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Waranty.WarantyDescr, "Garantieart:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Waranty.WarantyDescr)
            @Html.ValidationMessageFor(Function(model) model.Waranty.WarantyDescr)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.WarantyExp, "Garantie:")
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.WarantyExp)
            @Html.ValidationMessageFor(Function(model) model.WarantyExp)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Zurück", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
