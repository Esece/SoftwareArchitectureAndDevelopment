### Routes

The Listing Order Matters
``` csharp
context.MapRoute(null, "orders/{orderNumber}", new { controller = "OrderData", action = "Cancel" });
context.MapRoute(null, "orders/cancel", new { controller = "OrderData", action = "Index" });

// The first route will catch the URL "orders/cancel"
```
> Routes are looked up in a linear fashion following the order of listing.

A Route can be (or should be) Unnamed if not Directly Referenced. 
``` csharp
context.MapRoute(null, "Orders", new { controller = "OrderData", action = "Index" });
```
