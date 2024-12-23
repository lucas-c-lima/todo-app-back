
public class ToDoModel
{
    public ToDoModel(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; init; }
    public string Name { get; set; }
}