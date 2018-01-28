### Views

Create _Layout.cshtml Files Wherever Possible
``` html
<main>
    @RenderBody()
</main>
```

Use Helpers and Models for Dynamic Data
``` html
<div>
    <a href="@Url.Action("Index")">Click</a>
</div>
```

Avoid Using Helpers that Generate Markup
``` html
<div>
    @Html.TextBoxFor(m => m.Name)
</div>
```

