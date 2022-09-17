namespace GSuite.Models.Templates;

public record GTemplateObject : IGTemplateObject
{
    protected GTemplateObject(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; init; }
    public string Description { get; init; }
}

