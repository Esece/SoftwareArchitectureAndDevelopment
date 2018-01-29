### Views

#### General View Design Guidelines 
* "Index.cshtml" as default
* Organize in a folder by controller
* Refer views by name (view name and controller name) rather than file path
* Avoid calling methods other than built-in helpers inside a view
* Avoid creating variables inside a view
* Avoid RenderAction()
* Avoid ViewBag
* Do not minify manually




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

