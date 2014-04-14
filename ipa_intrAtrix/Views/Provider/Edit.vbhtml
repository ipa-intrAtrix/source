@ModelType ipa_intrAtrix.Models.Contracts.Providers

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Providers</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.ProviderId)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.ProviderId)
            @Html.ValidationMessageFor(Function(model) model.ProviderId)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Company)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Company)
            @Html.ValidationMessageFor(Function(model) model.Company)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.LockBox)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LockBox)
            @Html.ValidationMessageFor(Function(model) model.LockBox)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustomerRef)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CustomerRef)
            @Html.ValidationMessageFor(Function(model) model.CustomerRef)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Phone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Phone)
            @Html.ValidationMessageFor(Function(model) model.Phone)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Email)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Email)
            @Html.ValidationMessageFor(Function(model) model.Email)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Weblink)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Weblink)
            @Html.ValidationMessageFor(Function(model) model.Weblink)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
