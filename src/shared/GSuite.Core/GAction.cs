namespace GSuite.Core;

/// <summary>
/// GSuite action
/// </summary>
public class GAction : GParametrizable
{
    /// <summary>
    /// Gets or sets the action items list.
    /// </summary>
    public IList<GParametrizable> Items { get; set; } = new List<GParametrizable>();
}