### Model Binders

#### Add Custom Model Binders to Isolate Mapping Logic from Action
Implement
``` csharp
public class UserModel
{
    :
}

public class UserModelBinder : IModelBinder
{
    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    {
        var type = bindingContext.ModelType;
        UserModel instance;
        :
        return instance;
    }
}
```

Register Globally
``` csharp
ModelBinders.Binders.Add(typeof(UserModel), new UserModelBinder());
```

Register per Parameter
``` csharp
public ActionResult Login([ModelBinder(typeof(UserModelBinder)]UserModel model)
{
    :
}
```
