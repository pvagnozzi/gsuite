namespace GSuite.Core;

/// <summary>
/// GSuite parameter.
/// </summary>
public class GParameter : GObject
{
    #region Properties

    /// <summary>
    /// Gets or sets a value indicating whether if the parameter is mandatory
    /// </summary>
    public bool Required { get; set; }

    /// <summary>
    /// Gets or sets the parameter type.
    /// </summary>
    public GType? Type { get; set; }

    /// <summary>
    /// Gets or sets the default parameter value.
    /// </summary>
    public object? Default { get; set; }

    #endregion
}