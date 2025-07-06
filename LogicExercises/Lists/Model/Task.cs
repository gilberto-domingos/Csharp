namespace Lists.Model;

internal class Task
{
    public string Description { get; set; }

    public Task(string description)
    {
        Description = description;
    }

    public override string ToString()
    {
        return Description;
    }
}