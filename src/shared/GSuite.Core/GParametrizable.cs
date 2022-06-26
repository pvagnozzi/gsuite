namespace GSuite.Core;

/// <summary>
/// GSuite parametrizable object
/// </summary>
public class GParametrizable : GObject, IGParametrizable
{
    /// <summary>
    /// Gets or sets the parameters list.
    /// </summary>
    public IList<GParameter> Parameters { get; set; } = new List<GParameter>();
}