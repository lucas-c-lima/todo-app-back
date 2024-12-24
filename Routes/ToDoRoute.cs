﻿
public static class ToDoRoute
{
    public static void ToDoRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");

        route.MapPost("",
            async (ToDoRequest req, ToDoContext context) =>
        {
            var task = new ToDoModel(req.name);
            await context.AddAsync(task);
            await context.SaveChangesAsync();
        });
    }
}
