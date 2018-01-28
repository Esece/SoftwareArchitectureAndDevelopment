## web.config

### Global


### Views
Add Namespaces used in the Views
``` xml
<system.web.webPages.razor>
  <pages ..>
    <namespaces>
      <add namespace="Esece.Core" />
    </namespaces>
  </pages>
</system.web.webPages.razor>


AVOID (in cshtml):
@using Esece.Core
:
```
