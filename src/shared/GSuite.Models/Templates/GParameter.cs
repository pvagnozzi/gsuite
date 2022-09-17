namespace GSuite.Models.Templates;


public record GParameter : GTemplateObject
{
    protected GParameter(string name, string description, GParameterTypeClass typeClass = GParameterTypeClass.Text,
        object? defaultValue = null, bool mandatory = false) : base(name, description)
    {
        ParameterTypeClass = typeClass;
        Mandatory = mandatory;
        Default = defaultValue;
    }

    public bool Mandatory { get; init; }

    public GParameterTypeClass ParameterTypeClass { get; init; }

    public object? Default { get; init; }
}

