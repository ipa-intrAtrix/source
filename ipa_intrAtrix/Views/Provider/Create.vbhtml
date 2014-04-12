@Code
    ViewData("Title") = "Create"
End Code

<h2>Create Category</h2>
@*    @Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.")
    @Using (Html.BeginForm())
    <fieldset>
        <legend>Fields</legend>
        <p>
            <label for="Name">
                Name:</label>
            @Html.TextBox("Name")
            @Html.ValidationMessage("Name", "*")
        </p>
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
        @End using
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>*@