
public static class ToDoRoute
{
    public static void ToDoRoutes(this WebApplication app)
    {
        app.MapGet("person", () => new ToDoModel("Nome Person"));
    }
}
