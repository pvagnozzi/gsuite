namespace GSuite.Models.Templates;

public record GParameterType : GTemplateObject
{
    protected GParameterType(string name, string description) : base(name, description)
    {
    }
}

